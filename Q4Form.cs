using CyclismProject.Services;
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
    public partial class Q4Form : Form
    {
        public Q4Form()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            ScoreService.q4_score = ScoreService.q3_score;

            q4_labelScore.Text = "Score : " + ScoreService.q4_score;
            q4_labelPseudo.Text = "";
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void q4_buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            if (q4_checkBoxCyclesLane.Checked == true)
            {
                q4_checkBoxCyclesLane.ForeColor = Color.Red;
            }
            if (q4_checkBoxDeadEnd.Checked == true)
            {
                q4_checkBoxDeadEnd.ForeColor = Color.Red;
            }
            if (q4_checkBoxOneWay.Checked == true)
            {
                q4_checkBoxOneWay.ForeColor = Color.Red;
            }

            if ((q4_checkBoxCyclesBan.Checked == true))
            {
                q4_checkBoxCyclesLane.ForeColor = Color.Red;
                q4_checkBoxDeadEnd.ForeColor = Color.Red;
                q4_checkBoxOneWay.ForeColor = Color.Red;

                q4_labelAnswer.Visible = true;

                q4_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q4_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q4_score = ScoreService.q4_score + 5;
                q4_labelScore.Text = "Score : " + ScoreService.q4_score;
                q4_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q4_buttonNext.Visible = true;
                q4_buttonNext.Enabled = false;
                q4_buttonBack.Enabled = false;
                q4_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q4_buttonNext.Enabled = true;
            }
            else
            {
                q4_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q4_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q4_groupBoxQuestionnaire.ForeColor = Color.Red;

                await Task.Delay(500);

                q4_groupBoxQuestionnaire.Text = "";
                q4_groupBoxQuestionnaire.ForeColor = Color.Black;

                if (ScoreService.q4_score == 0)
                { }
                else
                {
                    ScoreService.q1_score--;
                    q4_labelScore.Text = "Score : " + ScoreService.q4_score;
                }
            }
        }

        private void checkBoxCyclesBan_CheckedChanged(object sender, EventArgs e)
        {
            if(q4_checkBoxCyclesBan.Checked == true)
            {
                q4_checkBoxOneWay.Checked = false;
                q4_checkBoxDeadEnd.Checked = false;
                q4_checkBoxCyclesLane.Checked = false;
            }
        }

        private void checkBoxOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if(q4_checkBoxOneWay.Checked == true)
            {
                q4_checkBoxCyclesBan.Checked = false;
                q4_checkBoxDeadEnd.Checked = false;
                q4_checkBoxCyclesLane.Checked = false;
            }
        }

        private void checkBoxDeadEnd_CheckedChanged(object sender, EventArgs e)
        {
            if(q4_checkBoxDeadEnd.Checked == true)
            {
                q4_checkBoxCyclesBan.Checked = false;
                q4_checkBoxOneWay.Checked = false;
                q4_checkBoxCyclesLane.Checked = false;
            }
        }

        private void checkBoxCyclesLane_CheckedChanged(object sender, EventArgs e)
        {
            if(q4_checkBoxCyclesLane.Checked == true)
            {
                q4_checkBoxCyclesBan.Checked = false;
                q4_checkBoxOneWay.Checked = false;
                q4_checkBoxDeadEnd.Checked = false;
            }
        }

        private void q4_buttonBack_Click(object sender, EventArgs e)
        {
            Q3Form Q3Form = new Q3Form();
            this.Hide();
            Q3Form.StartPosition = FormStartPosition.Manual;
            Q3Form.Location = new Point(10, 10);
            Q3Form.Show();
        }

        private void q4_buttonNext_Click(object sender, EventArgs e)
        {
            Q5Form Q5Form = new Q5Form();
            this.Hide();
            Q5Form.StartPosition = FormStartPosition.Manual;
            Q5Form.Location = new Point(10, 10);
            Q5Form.Show();
        }
    }
}
