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
    public partial class Q5Form : Form
    {
        public Q5Form()
        {
            InitializeComponent();

            ScoreService.q5_score = ScoreService.q4_score;
            q5_labelScore.Text = "Score : " + ScoreService.q5_score;
            q5_labelPseudo.Text = "";

            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void q5_confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (q5_checkBoxCyclableArea.Checked == true)
            {
                q5_checkBoxCyclableArea.ForeColor = Color.Red;
            }
            if (q5_checkBoxDeadEndWithoutIssue.Checked == true)
            {
                q5_checkBoxDeadEndWithoutIssue.ForeColor = Color.Red;
            }
            if (q5_checkBoxGreenTrack.Checked == true)
            {
                q5_checkBoxGreenTrack.ForeColor = Color.Red;
            }

            if (q5_checkBoxDeadEnd.Checked == true)
            {
                q5_checkBoxCyclableArea.ForeColor = Color.Red;
                q5_checkBoxDeadEndWithoutIssue.ForeColor = Color.Red;
                q5_checkBoxGreenTrack.ForeColor = Color.Red;

                q5_labelAnswer.Visible = true;

                q5_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q5_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q5_score = ScoreService.q4_score + ScoreService.win;
                q5_labelScore.Text = "Score : " + ScoreService.q5_score;
                q5_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q5_buttonNext.Visible = true;
                q5_buttonNext.Enabled = false;
                q5_buttonBack.Enabled = false;
                q5_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q5_buttonNext.Enabled = true;
            }
            else
            {
                q5_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q5_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q5_groupBoxQuestionnaire.ForeColor = Color.Red;

                await Task.Delay(500);

                q5_groupBoxQuestionnaire.Text = "";
                q5_groupBoxQuestionnaire.ForeColor = Color.Black;

                if (ScoreService.q5_score == 0)
                { }
                else
                {
                    ScoreService.q5_score = ScoreService.q5_score--;
                    q5_labelScore.Text = "Score : " + ScoreService.q5_score;
                }
            }
        }

        private void q5_checkBoxCyclablePiste_CheckedChanged(object sender, EventArgs e)
        {
            if (q5_checkBoxCyclableArea.Checked == true)
            {
                q5_checkBoxGreenTrack.Checked = false;
                q5_checkBoxDeadEnd.Checked = false;
                q5_checkBoxDeadEndWithoutIssue.Checked = false;
            }
        }

        private void q5_checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (q5_checkBoxGreenTrack.Checked == true)
            {
                q5_checkBoxCyclableArea.Checked = false;
                q5_checkBoxDeadEnd.Checked = false;
                q5_checkBoxDeadEndWithoutIssue.Checked = false;
            }
        }

        private void q5_checkBoxAutoRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (q5_checkBoxDeadEnd.Checked == true)
            {
                q5_checkBoxCyclableArea.Checked = false;
                q5_checkBoxGreenTrack.Checked = false;
                q5_checkBoxDeadEndWithoutIssue.Checked = false;
            }
        }

        private void q5_checkBoxForrbidenRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (q5_checkBoxDeadEndWithoutIssue.Checked == true)
            {
                q5_checkBoxCyclableArea.Checked = false;
                q5_checkBoxGreenTrack.Checked = false;
                q5_checkBoxDeadEnd.Checked =false;
            }
        }

        private void q5_buttonBack_Click(object sender, EventArgs e)
        {
            Q4Form Q4Form = new Q4Form();
            this.Hide();
            Q4Form.StartPosition = FormStartPosition.Manual;
            Q4Form.Location = new Point(10, 10);
            Q4Form.Show();
        }

        private void q5_buttonNext_Click(object sender, EventArgs e)
        {
            Q6Form Q6Form = new Q6Form();
            this.Hide();
            Q6Form.StartPosition = FormStartPosition.Manual;
            Q6Form.Location = new Point(10, 10);
            Q6Form.Show();
        }
    }
}
