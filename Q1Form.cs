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
    public partial class Q1Form : Form
    {
        public Q1Form()
        {
            InitializeComponent();
            ScoreService.q1_score = ScoreService.q0_score;
            q1_labelScore.Text = "Score : " + ScoreService.q1_score;
            q1_labelPseudo.Text = "";
            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void q1_confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (q1_checkBoxAutoRoad.Checked == true)
            {
                q1_checkBoxAutoRoad.ForeColor = Color.Red;
            }
            if (q1_checkBoxCycleArea.Checked == true)
            {
                q1_checkBoxCycleArea.ForeColor = Color.Red;
            }
            if (q1_checkBoxCycleTrack.Checked == true)
            {
                q1_checkBoxCycleTrack.ForeColor = Color.Red;
            }

            if (q1_checkBoxGreenTrack.Checked == true)
            {
                q1_checkBoxAutoRoad.ForeColor = Color.Red;
                q1_checkBoxCycleArea.ForeColor = Color.Red;
                q1_checkBoxCycleTrack.ForeColor = Color.Red;

                q1_labelAnswer.Visible = true;
                q1_pictureBoxSignLeave.Visible = true;

                q1_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q1_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q1_score = ScoreService.q1_score + ScoreService.win;
                q1_labelScore.Text = "Score : " + ScoreService.q1_score;
                q1_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q1_buttonNext.Visible = true;
                q1_buttonNext.Enabled = false;
                q1_buttonBack.Enabled = false;
                q1_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q1_buttonNext.Enabled = true;
            }
            else
            {
                q1_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q1_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q1_groupBoxQuestionnaire.ForeColor = Color.Red;
                q1_buttonConfirmAnswer.Enabled = false;

                await Task.Delay(500);

                q1_groupBoxQuestionnaire.Text = "";
                q1_groupBoxQuestionnaire.ForeColor = Color.Black;
                q1_buttonConfirmAnswer.Enabled = true;

                if (ScoreService.q1_score == 0)
                { }
                else
                {
                    ScoreService.q1_score--;
                    q1_labelScore.Text = "Score : " + ScoreService.q1_score;
                }
            }
        }

        private void checkBoxCycleTrack_CheckedChanged(object sender, EventArgs e)
        {
            if(q1_checkBoxCycleTrack.Checked == true)
            {
                q1_checkBoxCycleArea.Checked = false;
                q1_checkBoxGreenTrack.Checked = false;
                q1_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxCycleArea_CheckedChanged(object sender, EventArgs e)
        {
            if (q1_checkBoxCycleArea.Checked == true)
            {
                q1_checkBoxCycleTrack.Checked = false;
                q1_checkBoxGreenTrack.Checked = false;
                q1_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (q1_checkBoxGreenTrack.Checked == true)
            {
                q1_checkBoxCycleArea.Checked = false;
                q1_checkBoxCycleTrack.Checked = false;
                q1_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxAutoRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (q1_checkBoxAutoRoad.Checked == true)
            {
                q1_checkBoxCycleArea.Checked = false;
                q1_checkBoxGreenTrack.Checked = false;
                q1_checkBoxCycleTrack.Checked = false;
            }
        }

        private void q1_nextButton_Click(object sender, EventArgs e)
        {
            Q2Form Q2Form = new Q2Form();
            this.Hide();
            Q2Form.StartPosition = FormStartPosition.Manual;
            Q2Form.Location = new Point(10, 10);
            Q2Form.Show();
        }

        private void q1_backButton_Click(object sender, EventArgs e)
        {
            Q0Form Q0Form = new Q0Form();
            this.Hide();
            Q0Form.StartPosition = FormStartPosition.Manual;
            Q0Form.Location = new Point(10, 10);
            Q0Form.Show();
        }
    }
}