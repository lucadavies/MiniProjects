using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMapper
{
    public partial class ErrorList : Form
    {
        public ErrorList()
        {
            InitializeComponent();
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {

        }

        public void AddError(string error)
        {
            txtErrors.AppendText(error + Environment.NewLine);
        }

        public void ClearErrorText()
        {
            txtErrors.Text = "";
        }

        public bool HasErrorLog()
        {
            if (txtErrors.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
