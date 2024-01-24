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
    public partial class Q0Form : Form
    {
        public Q0Form()
        {
            InitializeComponent();
        }

        private async void nextButton_Click(object sender, EventArgs e)
        {
            if (q0_question.Visible == false)
            {
                q0_nextButton.Text = "Réponse";
                q0_question.Visible = true;
                return;
            }

            if ((q0_question.Visible == true) && (q0_answer.Visible == false))
            {
                q0_nextButton.Text = "Suivant";
                q0_answer.Visible = true;
                return;
            }

            if ((q0_question.Visible == true) && (q0_answer.Visible == true))
            {
                Q1Form Q1Form = new Q1Form();
                this.Hide();
                Q1Form.StartPosition = FormStartPosition.Manual;
                Q1Form.Location = new Point(10,10);
                Q1Form.Show();
            }
        }
    }
}
