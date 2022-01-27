using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDPP_lab4_8
{
    public partial class Form1 : Form
    {
        private static byte[] arrBytes = Enumerable.Range(192, 64).Select(x => (byte)x).ToArray();
        private static Encoding w1251 = Encoding.GetEncoding(1251);
        private static char[] arrChars = w1251.GetChars(arrBytes);
        private static Dictionary<byte, char> alfabet = new Dictionary<byte, char>();
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            for (int i = 0; i < arrBytes.Length; i++)
            {
                alfabet.Add(arrBytes[i], arrChars[i]);
            }
            alfabet.Add(178, 'І');
            alfabet.Add(179, 'і');
        }

        private void btnSelectDriver_Click(object sender, EventArgs e)
        {
            fBrowserDriver.ShowDialog();
            tBoxDriverPath.Text = fBrowserDriver.SelectedPath;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            tBoxFilePath.Text = openFileDialog.FileName;
            ReadFromFile(tBoxFilePath.Text);
            tBoxEdit.Enabled = true;
        }

        private void ReadFromFile(string path)
        {
            tBoxEdit.Clear();
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                tBoxEdit.Text += reader.ReadLine();
            }
            reader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(tBoxDriverPath.Text + @"\test.txt");
            writer.Write(tBoxEdit.Text);
            writer.Close();
            ShowByte();
        }

        private void ShowByte()
        {
            int byteNumber = Decimal.ToInt32(numByteNumber.Value);
            chart1.Series["Signal"].Points.Clear();
            var a = alfabet.FirstOrDefault(pair => pair.Value == tBoxEdit.Text[byteNumber]);
            string bits = (Convert.ToString(a.Key, 2).PadLeft(8, '0'));

            int last = 1;
            int x = 0;
            foreach (var item in bits)
            {
                int y = Int32.Parse(item.ToString());
                if (y == 0)
                {
                    if (last == 0)
                        last = 1;
                    else
                        last = 0;
                    chart1.Series["Signal"].Points.AddXY(x, last);
                }
                else
                {
                    chart1.Series["Signal"].Points.AddXY(x, last);
                }
                x++;
            }
            chart1.Series["Signal"].Points.AddXY(x, last);
            lblByte.Text = a.Value + " = " + bits; 
        }

        private void numByteNumber_ValueChanged(object sender, EventArgs e)
        {
            if (numByteNumber.Value >= tBoxEdit.Text.Length)
                MessageBox.Show("There are no such byte");
            else
                ShowByte();
        }
    }
}
