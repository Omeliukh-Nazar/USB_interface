
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
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
            this.btnSelectDriver.Location = new System.Drawing.Point(17, 21);
            this.btnSelectDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectDriver.Name = "btnSelectDriver";
            this.btnSelectDriver.Size = new System.Drawing.Size(167, 36);
            this.btnSelectDriver.TabIndex = 0;
            this.btnSelectDriver.Text = "SelectDrive";
            this.btnSelectDriver.UseVisualStyleBackColor = true;
            this.btnSelectDriver.Click += new System.EventHandler(this.btnSelectDrive_Click);
            // 
            // fBrowserDriver
            // 
            this.fBrowserDriver.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFile.Location = new System.Drawing.Point(17, 64);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(167, 36);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(13, 404);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(509, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBoxEdit
            // 
            this.tBoxEdit.Enabled = false;
            this.tBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxEdit.Location = new System.Drawing.Point(16, 112);
            this.tBoxEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxEdit.Multiline = true;
            this.tBoxEdit.Name = "tBoxEdit";
            this.tBoxEdit.Size = new System.Drawing.Size(509, 286);
            this.tBoxEdit.TabIndex = 3;
            // 
            // tBoxFilePath
            // 
            this.tBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxFilePath.Location = new System.Drawing.Point(192, 64);
            this.tBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxFilePath.Name = "tBoxFilePath";
            this.tBoxFilePath.Size = new System.Drawing.Size(336, 34);
            this.tBoxFilePath.TabIndex = 4;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAction.Location = new System.Drawing.Point(213, 394);
            this.lblAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 29);
            this.lblAction.TabIndex = 5;
            // 
            // tBoxDriverPath
            // 
            this.tBoxDriverPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDriverPath.Location = new System.Drawing.Point(192, 21);
            this.tBoxDriverPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxDriverPath.Name = "tBoxDriverPath";
            this.tBoxDriverPath.Size = new System.Drawing.Size(333, 34);
            this.tBoxDriverPath.TabIndex = 6;
            // 
            // openFileDialog
            // 
            
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(536, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.Name = "Signal";
            series4.Points.Add(dataPoint25);
            series4.Points.Add(dataPoint26);
            series4.Points.Add(dataPoint27);
            series4.Points.Add(dataPoint28);
            series4.Points.Add(dataPoint29);
            series4.Points.Add(dataPoint30);
            series4.Points.Add(dataPoint31);
            series4.Points.Add(dataPoint32);
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(892, 384);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // numByteNumber
            // 
            this.numByteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numByteNumber.Location = new System.Drawing.Point(536, 406);
            this.numByteNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numByteNumber.Name = "numByteNumber";
            this.numByteNumber.Size = new System.Drawing.Size(75, 34);
            this.numByteNumber.TabIndex = 8;
            this.numByteNumber.ValueChanged += new System.EventHandler(this.numByteNumber_ValueChanged);
            // 
            // lblByte
            // 
            this.lblByte.AutoSize = true;
            this.lblByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByte.Location = new System.Drawing.Point(657, 412);
            this.lblByte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblByte.Name = "lblByte";
            this.lblByte.Size = new System.Drawing.Size(0, 29);
            this.lblByte.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 449);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

