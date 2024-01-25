using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyclismProject
{
    public partial class Q1Form : Q0Form
    {
        public static new string GlobalVar
        {
            get { return _q1Score.ToString(); }
            set { _q1Score = int.Parse(value); }
        }

        public Q1Form()
        {
            InitializeComponent();
            _q1Score = _q0Score;
            q1_labelScore.Text = "Score : " + _q1Score;
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private async void q1_nextButton_Click(object sender, EventArgs e)
        {
            if (q1_answer1.Visible == false)
            {
                q1_answer1.Visible = true;
                return;
            }

            if ((q1_answer1.Visible == true) && (q1_signLeave.Visible == true))
            {
                Q2Form Q2Form = new Q2Form();
                this.Hide();
                Q2Form.StartPosition = FormStartPosition.Manual;
                Q2Form.Location = new Point(10, 10);
                Q2Form.Show();
            }
        }
    }
}
