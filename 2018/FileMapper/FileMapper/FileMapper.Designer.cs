namespace FileMapper
{
    partial class FileMapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0");
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gBoxFolder = new System.Windows.Forms.GroupBox();
            this.lblDirs = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.txtDirs = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.gBoxOptions = new System.Windows.Forms.GroupBox();
            this.radBtnFiles = new System.Windows.Forms.RadioButton();
            this.radBtnSize = new System.Windows.Forms.RadioButton();
            this.chkBoxShowErrors = new System.Windows.Forms.CheckBox();
            this.gBoxSI = new System.Windows.Forms.GroupBox();
            this.gBoxFiles = new System.Windows.Forms.GroupBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblFilesd = new System.Windows.Forms.Label();
            this.lblkBd = new System.Windows.Forms.Label();
            this.lblMBd = new System.Windows.Forms.Label();
            this.lblGBd = new System.Windows.Forms.Label();
            this.lblTBd = new System.Windows.Forms.Label();
            this.lblkB = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblGB = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblKiB = new System.Windows.Forms.Label();
            this.lblMiB = new System.Windows.Forms.Label();
            this.lblGiB = new System.Windows.Forms.Label();
            this.lblTiB = new System.Windows.Forms.Label();
            this.gBoxBin = new System.Windows.Forms.GroupBox();
            this.lblKiBd = new System.Windows.Forms.Label();
            this.lblMiBd = new System.Windows.Forms.Label();
            this.lblGiBd = new System.Windows.Forms.Label();
            this.lblTiBd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.gBoxFolder.SuspendLayout();
            this.gBoxOptions.SuspendLayout();
            this.gBoxSI.SuspendLayout();
            this.gBoxFiles.SuspendLayout();
            this.gBoxBin.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(206, 97);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Default";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.Label = "C";
            series1.Points.Add(dataPoint1);
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(750, 548);
            this.chart.TabIndex = 0;
            this.chart.Text = "Memory Chart";
            // 
            // gBoxFolder
            // 
            this.gBoxFolder.Controls.Add(this.lblDirs);
            this.gBoxFolder.Controls.Add(this.btnMap);
            this.gBoxFolder.Controls.Add(this.txtDirs);
            this.gBoxFolder.Controls.Add(this.btnFolder);
            this.gBoxFolder.Controls.Add(this.txtFolder);
            this.gBoxFolder.Location = new System.Drawing.Point(12, 12);
            this.gBoxFolder.Name = "gBoxFolder";
            this.gBoxFolder.Size = new System.Drawing.Size(745, 79);
            this.gBoxFolder.TabIndex = 1;
            this.gBoxFolder.TabStop = false;
            this.gBoxFolder.Text = "Folder";
            // 
            // lblDirs
            // 
            this.lblDirs.AutoSize = true;
            this.lblDirs.Location = new System.Drawing.Point(21, 52);
            this.lblDirs.Name = "lblDirs";
            this.lblDirs.Size = new System.Drawing.Size(60, 13);
            this.lblDirs.TabIndex = 4;
            this.lblDirs.Text = "Directories:";
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(664, 48);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // txtDirs
            // 
            this.txtDirs.Location = new System.Drawing.Point(87, 50);
            this.txtDirs.Name = "txtDirs";
            this.txtDirs.Size = new System.Drawing.Size(571, 20);
            this.txtDirs.TabIndex = 3;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(6, 19);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Browse...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(87, 21);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(571, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.radBtnFiles);
            this.gBoxOptions.Controls.Add(this.radBtnSize);
            this.gBoxOptions.Controls.Add(this.chkBoxShowErrors);
            this.gBoxOptions.Location = new System.Drawing.Point(763, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(193, 79);
            this.gBoxOptions.TabIndex = 2;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Options";
            // 
            // radBtnFiles
            // 
            this.radBtnFiles.AutoSize = true;
            this.radBtnFiles.Location = new System.Drawing.Point(87, 22);
            this.radBtnFiles.Name = "radBtnFiles";
            this.radBtnFiles.Size = new System.Drawing.Size(46, 17);
            this.radBtnFiles.TabIndex = 2;
            this.radBtnFiles.TabStop = true;
            this.radBtnFiles.Text = "Files";
            this.radBtnFiles.UseVisualStyleBackColor = true;
            this.radBtnFiles.Click += new System.EventHandler(this.RadBtnFiles_Click);
            // 
            // radBtnSize
            // 
            this.radBtnSize.AutoSize = true;
            this.radBtnSize.Checked = true;
            this.radBtnSize.Location = new System.Drawing.Point(6, 22);
            this.radBtnSize.Name = "radBtnSize";
            this.radBtnSize.Size = new System.Drawing.Size(45, 17);
            this.radBtnSize.TabIndex = 1;
            this.radBtnSize.TabStop = true;
            this.radBtnSize.Text = "Size";
            this.radBtnSize.UseVisualStyleBackColor = true;
            this.radBtnSize.Click += new System.EventHandler(this.RadBtnSize_Click);
            // 
            // chkBoxShowErrors
            // 
            this.chkBoxShowErrors.AutoSize = true;
            this.chkBoxShowErrors.Location = new System.Drawing.Point(6, 48);
            this.chkBoxShowErrors.Name = "chkBoxShowErrors";
            this.chkBoxShowErrors.Size = new System.Drawing.Size(168, 17);
            this.chkBoxShowErrors.TabIndex = 0;
            this.chkBoxShowErrors.Text = "Shows errors during execution";
            this.chkBoxShowErrors.UseVisualStyleBackColor = true;
            this.chkBoxShowErrors.CheckedChanged += new System.EventHandler(this.ChkBoxShowErrors_CheckedChanged);
            // 
            // gBoxSI
            // 
            this.gBoxSI.Controls.Add(this.lblkBd);
            this.gBoxSI.Controls.Add(this.lblMBd);
            this.gBoxSI.Controls.Add(this.lblGBd);
            this.gBoxSI.Controls.Add(this.lblTBd);
            this.gBoxSI.Controls.Add(this.lblkB);
            this.gBoxSI.Controls.Add(this.lblMB);
            this.gBoxSI.Controls.Add(this.lblGB);
            this.gBoxSI.Controls.Add(this.lblTB);
            this.gBoxSI.Location = new System.Drawing.Point(12, 97);
            this.gBoxSI.Name = "gBoxSI";
            this.gBoxSI.Size = new System.Drawing.Size(188, 172);
            this.gBoxSI.TabIndex = 3;
            this.gBoxSI.TabStop = false;
            this.gBoxSI.Text = "Size (SI Prefixes)";
            // 
            // gBoxFiles
            // 
            this.gBoxFiles.Controls.Add(this.lblFiles);
            this.gBoxFiles.Controls.Add(this.lblFilesd);
            this.gBoxFiles.Location = new System.Drawing.Point(12, 97);
            this.gBoxFiles.Name = "gBoxFiles";
            this.gBoxFiles.Size = new System.Drawing.Size(188, 56);
            this.gBoxFiles.TabIndex = 12;
            this.gBoxFiles.TabStop = false;
            this.gBoxFiles.Text = "Number of Files";
            this.gBoxFiles.Visible = false;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(133, 26);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(28, 13);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "Files";
            // 
            // lblFilesd
            // 
            this.lblFilesd.AutoSize = true;
            this.lblFilesd.Location = new System.Drawing.Point(35, 26);
            this.lblFilesd.Name = "lblFilesd";
            this.lblFilesd.Size = new System.Drawing.Size(13, 13);
            this.lblFilesd.TabIndex = 8;
            this.lblFilesd.Text = "0";
            // 
            // lblkBd
            // 
            this.lblkBd.AutoSize = true;
            this.lblkBd.Location = new System.Drawing.Point(35, 125);
            this.lblkBd.Name = "lblkBd";
            this.lblkBd.Size = new System.Drawing.Size(13, 13);
            this.lblkBd.TabIndex = 7;
            this.lblkBd.Text = "0";
            // 
            // lblMBd
            // 
            this.lblMBd.AutoSize = true;
            this.lblMBd.Location = new System.Drawing.Point(35, 92);
            this.lblMBd.Name = "lblMBd";
            this.lblMBd.Size = new System.Drawing.Size(13, 13);
            this.lblMBd.TabIndex = 6;
            this.lblMBd.Text = "0";
            // 
            // lblGBd
            // 
            this.lblGBd.AutoSize = true;
            this.lblGBd.Location = new System.Drawing.Point(35, 59);
            this.lblGBd.Name = "lblGBd";
            this.lblGBd.Size = new System.Drawing.Size(13, 13);
            this.lblGBd.TabIndex = 5;
            this.lblGBd.Text = "0";
            // 
            // lblTBd
            // 
            this.lblTBd.AutoSize = true;
            this.lblTBd.Location = new System.Drawing.Point(35, 26);
            this.lblTBd.Name = "lblTBd";
            this.lblTBd.Size = new System.Drawing.Size(13, 13);
            this.lblTBd.TabIndex = 4;
            this.lblTBd.Text = "0";
            // 
            // lblkB
            // 
            this.lblkB.AutoSize = true;
            this.lblkB.Location = new System.Drawing.Point(135, 125);
            this.lblkB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblkB.Name = "lblkB";
            this.lblkB.Size = new System.Drawing.Size(23, 13);
            this.lblkB.TabIndex = 3;
            this.lblkB.Text = " kB";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(135, 92);
            this.lblMB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 2;
            this.lblMB.Text = "MB";
            // 
            // lblGB
            // 
            this.lblGB.AutoSize = true;
            this.lblGB.Location = new System.Drawing.Point(135, 59);
            this.lblGB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblGB.Name = "lblGB";
            this.lblGB.Size = new System.Drawing.Size(22, 13);
            this.lblGB.TabIndex = 1;
            this.lblGB.Text = "GB";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(135, 26);
            this.lblTB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(21, 13);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "TB";
            // 
            // lblKiB
            // 
            this.lblKiB.AutoSize = true;
            this.lblKiB.Location = new System.Drawing.Point(131, 125);
            this.lblKiB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblKiB.Name = "lblKiB";
            this.lblKiB.Size = new System.Drawing.Size(23, 13);
            this.lblKiB.TabIndex = 7;
            this.lblKiB.Text = "KiB";
            // 
            // lblMiB
            // 
            this.lblMiB.AutoSize = true;
            this.lblMiB.Location = new System.Drawing.Point(131, 92);
            this.lblMiB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblMiB.Name = "lblMiB";
            this.lblMiB.Size = new System.Drawing.Size(25, 13);
            this.lblMiB.TabIndex = 6;
            this.lblMiB.Text = "MiB";
            // 
            // lblGiB
            // 
            this.lblGiB.AutoSize = true;
            this.lblGiB.Location = new System.Drawing.Point(132, 59);
            this.lblGiB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblGiB.Name = "lblGiB";
            this.lblGiB.Size = new System.Drawing.Size(24, 13);
            this.lblGiB.TabIndex = 5;
            this.lblGiB.Text = "GiB";
            // 
            // lblTiB
            // 
            this.lblTiB.AutoSize = true;
            this.lblTiB.Location = new System.Drawing.Point(133, 26);
            this.lblTiB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblTiB.Name = "lblTiB";
            this.lblTiB.Size = new System.Drawing.Size(23, 13);
            this.lblTiB.TabIndex = 4;
            this.lblTiB.Text = "TiB";
            // 
            // gBoxBin
            // 
            this.gBoxBin.Controls.Add(this.lblKiBd);
            this.gBoxBin.Controls.Add(this.lblKiB);
            this.gBoxBin.Controls.Add(this.lblMiBd);
            this.gBoxBin.Controls.Add(this.lblTiB);
            this.gBoxBin.Controls.Add(this.lblGiBd);
            this.gBoxBin.Controls.Add(this.lblGiB);
            this.gBoxBin.Controls.Add(this.lblTiBd);
            this.gBoxBin.Controls.Add(this.lblMiB);
            this.gBoxBin.Location = new System.Drawing.Point(12, 275);
            this.gBoxBin.Name = "gBoxBin";
            this.gBoxBin.Size = new System.Drawing.Size(188, 172);
            this.gBoxBin.TabIndex = 4;
            this.gBoxBin.TabStop = false;
            this.gBoxBin.Text = "Size (Binary Prefixes)";
            // 
            // lblKiBd
            // 
            this.lblKiBd.AutoSize = true;
            this.lblKiBd.Location = new System.Drawing.Point(35, 125);
            this.lblKiBd.Name = "lblKiBd";
            this.lblKiBd.Size = new System.Drawing.Size(13, 13);
            this.lblKiBd.TabIndex = 11;
            this.lblKiBd.Text = "0";
            // 
            // lblMiBd
            // 
            this.lblMiBd.AutoSize = true;
            this.lblMiBd.Location = new System.Drawing.Point(35, 92);
            this.lblMiBd.Name = "lblMiBd";
            this.lblMiBd.Size = new System.Drawing.Size(13, 13);
            this.lblMiBd.TabIndex = 10;
            this.lblMiBd.Text = "0";
            // 
            // lblGiBd
            // 
            this.lblGiBd.AutoSize = true;
            this.lblGiBd.Location = new System.Drawing.Point(35, 59);
            this.lblGiBd.Name = "lblGiBd";
            this.lblGiBd.Size = new System.Drawing.Size(13, 13);
            this.lblGiBd.TabIndex = 9;
            this.lblGiBd.Text = "0";
            // 
            // lblTiBd
            // 
            this.lblTiBd.AutoSize = true;
            this.lblTiBd.Location = new System.Drawing.Point(35, 26);
            this.lblTiBd.Name = "lblTiBd";
            this.lblTiBd.Size = new System.Drawing.Size(13, 13);
            this.lblTiBd.TabIndex = 8;
            this.lblTiBd.Text = "0";
            // 
            // FileMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 657);
            this.Controls.Add(this.gBoxFiles);
            this.Controls.Add(this.gBoxBin);
            this.Controls.Add(this.gBoxSI);
            this.Controls.Add(this.gBoxOptions);
            this.Controls.Add(this.gBoxFolder);
            this.Controls.Add(this.chart);
            this.Name = "FileMapper";
            this.Text = "File Mapper";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.gBoxFolder.ResumeLayout(false);
            this.gBoxFolder.PerformLayout();
            this.gBoxOptions.ResumeLayout(false);
            this.gBoxOptions.PerformLayout();
            this.gBoxSI.ResumeLayout(false);
            this.gBoxSI.PerformLayout();
            this.gBoxFiles.ResumeLayout(false);
            this.gBoxFiles.PerformLayout();
            this.gBoxBin.ResumeLayout(false);
            this.gBoxBin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox gBoxFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblDirs;
        private System.Windows.Forms.TextBox txtDirs;
        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.CheckBox chkBoxShowErrors;
        private System.Windows.Forms.GroupBox gBoxSI;
        private System.Windows.Forms.Label lblkBd;
        private System.Windows.Forms.Label lblMBd;
        private System.Windows.Forms.Label lblGBd;
        private System.Windows.Forms.Label lblTBd;
        private System.Windows.Forms.Label lblkB;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblGB;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblKiB;
        private System.Windows.Forms.Label lblMiB;
        private System.Windows.Forms.Label lblGiB;
        private System.Windows.Forms.Label lblTiB;
        private System.Windows.Forms.GroupBox gBoxBin;
        private System.Windows.Forms.Label lblKiBd;
        private System.Windows.Forms.Label lblMiBd;
        private System.Windows.Forms.Label lblGiBd;
        private System.Windows.Forms.Label lblTiBd;
        private System.Windows.Forms.RadioButton radBtnFiles;
        private System.Windows.Forms.RadioButton radBtnSize;
        private System.Windows.Forms.GroupBox gBoxFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblFilesd;
    }
}

