using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileMapper
{
    public partial class FileMapper : Form
    {
        private CommonOpenFileDialog browser;
        private DirectoryInfo root;
        private List<DirectoryInfo> subdirs;
        private List<long> data;
        private bool showErrors;
        private ErrorList formErrorList;
        private decimal size;

        public FileMapper()
        {
            InitializeComponent();
            browser = new CommonOpenFileDialog { InitialDirectory = "C:", IsFolderPicker = true };
            showErrors = false;
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (browser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                size = 0;
                formErrorList = new ErrorList();
                root = new DirectoryInfo(browser.FileName);
                txtFolder.Text = root.FullName;
                txtDirs.Text = "";
                formErrorList.ClearErrorText();
                foreach (DirectoryInfo d in root.GetDirectories())
                {
                    txtDirs.AppendText(d.Name + "; ");
                }
            }
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            subdirs = new List<DirectoryInfo> { };
            data = new List<long> { };
            size = DirSize(new DirectoryInfo(root.FullName));
            if (formErrorList.HasErrorLog())
            {
                formErrorList.Show();
            }
            AddData();
        }

        private long DirSize(DirectoryInfo d)
        {
            long size = 0;
            long diSize = 0;
            // Add file sizes.
            FileInfo[] fis = null;
            try
            {
                fis = d.GetFiles();
            }
            catch (AccessViolationException e)
            {
                if (showErrors)
                {
                    MessageBox.Show("Error reading files. " + e.Message, "File Error");
                }
                formErrorList.AddError(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                if (showErrors)
                {
                    MessageBox.Show("Error reading files. " + e.Message, "File Error");
                }
                formErrorList.AddError(e.Message);
            }
            if (fis != null)
            {
                foreach (FileInfo fi in fis)
                {
                    if (radBtnSize.Checked)
                    {
                        size += fi.Length;
                    }
                    else
                    {
                        size += 1;
                    }
                    
                }
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = null;
            try
            {
                dis = d.GetDirectories();
            }
            catch (AccessViolationException e)
            {
                if (showErrors)
                {
                    MessageBox.Show("Error reading files. " + e.Message, "Folder Error");
                }
                formErrorList.AddError(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                if (showErrors)
                {
                    MessageBox.Show("Error reading files. " + e.Message, "Folder Error");
                }
                formErrorList.AddError(e.Message);
            }
            if (dis != null)
            {
                foreach (DirectoryInfo di in dis)
                {
                    diSize = DirSize(di);
                    size += diSize;
                    if (di.Parent.FullName == root.FullName)
                    {
                        subdirs.Add(di);
                        data.Add(diSize);
                    }
                }
            }
            return size;
        }

        private void AddData()
        {
            chart.Series["Default"].Points.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                chart.Series["Default"].Points.AddY(data[i]);
                chart.Series["Default"].Points[i].Label = subdirs[i].Name + Environment.NewLine + (radBtnSize.Checked ? Math.Round((decimal)data[i] / 1000000, 1) + "MB" : data[i].ToString());
            }
            chart.Series["Default"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
            if (radBtnSize.Checked)
            {
                lblTBd.Text = Convert.ToString(Math.Round(size / 1000000000000, 5));
                lblGBd.Text = Convert.ToString(Math.Round(size / 1000000000, 5));
                lblMBd.Text = Convert.ToString(Math.Round(size / 1000000, 5));
                lblkBd.Text = Convert.ToString(Math.Round(size / 1000, 5));
                lblTiBd.Text = Convert.ToString(Math.Round(size / 1099511628000, 5)); // 1024^4 | 2^40
                lblGiBd.Text = Convert.ToString(Math.Round(size / 1073741824, 5));    // 1024^3 | 2^30
                lblMiBd.Text = Convert.ToString(Math.Round(size / 1048576, 5));       // 1024^2 | 2^20
                lblKiBd.Text = Convert.ToString(Math.Round(size / 1024, 5));          // 1024   | 2^10
            }
            else
            {
                lblFilesd.Text = Convert.ToString(size);
            }
        }

        private void ChkBoxShowErrors_CheckedChanged(object sender, EventArgs e)
        {
            showErrors = chkBoxShowErrors.Checked;
        }

        private void RadBtnSize_Click(object sender, EventArgs e)
        {
            switchFilesSize();
        }

        private void RadBtnFiles_Click(object sender, EventArgs e)
        {
            switchFilesSize();
        }

        private void switchFilesSize()
        {
            if (radBtnFiles.Checked)
            {
                gBoxFiles.Visible = true;
                gBoxSI.Visible = false;
                gBoxBin.Visible = false;
            }
            else
            {
                gBoxFiles.Visible = false;
                gBoxSI.Visible = true;
                gBoxBin.Visible = true;
            }
        }
    }
}
