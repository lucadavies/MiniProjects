using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizUI
{
    public partial class FormMain : Form
    {
        Panel[] PanTs;
        Panel[] PanTCols;
        Label[] LblTs;
        Label[] LblTNames;
        Label[] LblTPs;
        Button[] BtnTU10s;
        Button[] BtnTU5s;
        Button[] BtnTD5s;

        public FormMain()
        {
            InitializeComponent();
            InitArrays();

        }

        public void InitArrays()
        {
            PanTs = new Panel[8] { PanT1, PanT2, PanT3, PanT4, PanT5, PanT6, PanT7, PanT8 };
            PanTCols = new Panel[8] { PanT1Col, PanT2Col, PanT3Col, PanT4Col, PanT5Col, PanT6Col, PanT7Col, PanT8Col };
            LblTs = new Label[8] { LblT1, LblT2, LblT3, LblT4, LblT5, LblT6, LblT7, LblT8 };
            LblTNames = new Label[8] { LblT1Name, LblT2Name, LblT3Name, LblT4Name, LblT5Name, LblT6Name, LblT7Name, LblT8Name };
            LblTPs = new Label[8] { LblT1P, LblT2P, LblT3P, LblT4P, LblT5P, LblT6P, LblT7P, LblT8P };
            BtnTU10s = new Button[8] { BtnT1U10, BtnT1U10, BtnT3U10, BtnT4U10, BtnT5U10, BtnT6U10,BtnT7U10, BtnT8U10 };
            BtnTU5s = new Button[8] { BtnT1U5, BtnT1U5, BtnT3U5, BtnT4U5, BtnT5U5, BtnT6U5, BtnT7U5, BtnT8U5 };
            BtnTD5s = new Button[8] { BtnT1D5, BtnT1D5, BtnT3D5, BtnT4D5, BtnT5D5, BtnT6D5, BtnT7D5, BtnT8D5 };
        }

        public void Score(int index, int val)
        {
           LblTPs[index].Text =  Convert.ToString(Convert.ToInt16(LblTPs[index].Text) + val);
        }

        #region "Points Buttons"
        private void BtnT1U10_Click(object sender, EventArgs e)
        {
            Score(0, 10);
        }
        private void BtnT2U10_Click(object sender, EventArgs e)
        {
            Score(1, 10);
        }
        private void BtnT3U10_Click(object sender, EventArgs e)
        {
            Score(2, 10);
        }
        private void BtnT4U10_Click(object sender, EventArgs e)
        {
            Score(3, 10);
        }
        private void BtnT5U10_Click(object sender, EventArgs e)
        {
            Score(4, 10);
        }
        private void BtnT6U10_Click(object sender, EventArgs e)
        {
            Score(5, 10);
        }
        private void BtnT7U10_Click(object sender, EventArgs e)
        {
            Score(6, 10);
        }
        private void BtnT8U10_Click(object sender, EventArgs e)
        {
            Score(7, 10);
        }

        private void BtnT1U5_Click(object sender, EventArgs e)
        {
            Score(0, 5);
        }
        private void BtnT2U5_Click(object sender, EventArgs e)
        {
            Score(1, 5);
        }
        private void BtnT3U5_Click(object sender, EventArgs e)
        {
            Score(2, 5);
        }
        private void BtnT4U5_Click(object sender, EventArgs e)
        {
            Score(3, 5);
        }
        private void BtnT5U5_Click(object sender, EventArgs e)
        {
            Score(4, 5);
        }
        private void BtnT6U5_Click(object sender, EventArgs e)
        {
            Score(5, 5);
        }
        private void BtnT7U5_Click(object sender, EventArgs e)
        {
            Score(6, 5);
        }
        private void BtnT8U5_Click(object sender, EventArgs e)
        {
            Score(7, 5);
        }

        private void BtnT1D5_Click(object sender, EventArgs e)
        {
            Score(0, -5);
        }
        private void BtnT2D5_Click(object sender, EventArgs e)
        {
            Score(1, -5);
        }
        private void BtnT3D5_Click(object sender, EventArgs e)
        {
            Score(2, -5);
        }
        private void BtnT4D5_Click(object sender, EventArgs e)
        {
            Score(3, -5);
        }
        private void BtnT5D5_Click(object sender, EventArgs e)
        {
            Score(4, -5);
        }
        private void BtnT6D5_Click(object sender, EventArgs e)
        {
            Score(5, -5);
        }
        private void BtnT7D5_Click(object sender, EventArgs e)
        {
            Score(6, -5);
        }
        private void BtnT8D5_Click(object sender, EventArgs e)
        {
            Score(7, -5);
        }

        #endregion


    }
}
