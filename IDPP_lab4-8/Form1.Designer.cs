
namespace IDPP_lab4_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.btnSelectDriver = new System.Windows.Forms.Button();
            this.fBrowserDriver = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBoxEdit = new System.Windows.Forms.TextBox();
            this.tBoxFilePath = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.tBoxDriverPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numByteNumber = new System.Windows.Forms.NumericUpDown();
            this.lblByte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numByteNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectDriver
            // 
            this.btnSelectDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectDriver.Location = new System.Drawing.Point(13, 17);
            this.btnSelectDriver.Name = "btnSelectDriver";
            this.btnSelectDriver.Size = new System.Drawing.Size(125, 29);
            this.btnSelectDriver.TabIndex = 0;
            this.btnSelectDriver.Text = "SelectDriver";
            this.btnSelectDriver.UseVisualStyleBackColor = true;
            this.btnSelectDriver.Click += new System.EventHandler(this.btnSelectDriver_Click);
            // 
            // fBrowserDriver
            // 
            this.fBrowserDriver.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFile.Location = new System.Drawing.Point(13, 52);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(125, 29);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(12, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(382, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBoxEdit
            // 
            this.tBoxEdit.Enabled = false;
            this.tBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxEdit.Location = new System.Drawing.Point(12, 91);
            this.tBoxEdit.Multiline = true;
            this.tBoxEdit.Name = "tBoxEdit";
            this.tBoxEdit.Size = new System.Drawing.Size(383, 233);
            this.tBoxEdit.TabIndex = 3;
            // 
            // tBoxFilePath
            // 
            this.tBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxFilePath.Location = new System.Drawing.Point(144, 52);
            this.tBoxFilePath.Name = "tBoxFilePath";
            this.tBoxFilePath.Size = new System.Drawing.Size(253, 29);
            this.tBoxFilePath.TabIndex = 4;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAction.Location = new System.Drawing.Point(160, 320);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 24);
            this.lblAction.TabIndex = 5;
            // 
            // tBoxDriverPath
            // 
            this.tBoxDriverPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDriverPath.Location = new System.Drawing.Point(144, 17);
            this.tBoxDriverPath.Name = "tBoxDriverPath";
            this.tBoxDriverPath.Size = new System.Drawing.Size(251, 29);
            this.tBoxDriverPath.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "oFileDialog";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(402, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(669, 312);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // numByteNumber
            // 
            this.numByteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numByteNumber.Location = new System.Drawing.Point(402, 330);
            this.numByteNumber.Name = "numByteNumber";
            this.numByteNumber.Size = new System.Drawing.Size(56, 29);
            this.numByteNumber.TabIndex = 8;
            this.numByteNumber.ValueChanged += new System.EventHandler(this.numByteNumber_ValueChanged);
            // 
            // lblByte
            // 
            this.lblByte.AutoSize = true;
            this.lblByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByte.Location = new System.Drawing.Point(493, 335);
            this.lblByte.Name = "lblByte";
            this.lblByte.Size = new System.Drawing.Size(0, 24);
            this.lblByte.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 365);
            this.Controls.Add(this.lblByte);
            this.Controls.Add(this.numByteNumber);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tBoxDriverPath);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.tBoxFilePath);
            this.Controls.Add(this.tBoxEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSelectDriver);
            this.Name = "Form1";
            this.Text = "USB IDPP";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numByteNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDriver;
        private System.Windows.Forms.FolderBrowserDialog fBrowserDriver;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBoxEdit;
        private System.Windows.Forms.TextBox tBoxFilePath;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox tBoxDriverPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numByteNumber;
        private System.Windows.Forms.Label lblByte;
    }
}

