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
    public partial class Q2Form : Q1Form
    {
        public static new string GlobalVar
        {
            get { return _q2Score.ToString(); }
            set { _q2Score = int.Parse(value); }
        }

        public Q2Form()
        {
            InitializeComponent();
        }

        private void Q2Form_Load(object sender, EventArgs e)
        {

        }

        private void q2_nextButton_Click(object sender, EventArgs e)
        {
            if (q2_answer1.Visible == false)
            {
                q2_answer1.Visible = true;
                return;
            }

            if ((q2_answer1.Visible == true))
            {
                q2_nextButton.Text = "Suivant";
                q2_signLeave.Visible = true;
                return;
            }

            if ((q2_answer1.Visible == true) && (q2_signLeave.Visible == true))
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
