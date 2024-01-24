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
    public partial class Q1Form : Form
    {
        public Q1Form()
        {
            InitializeComponent();
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
