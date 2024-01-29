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
            ScoreService.q1_score =+ ScoreService.q0_score;
            q1_labelScore.Text = "Score : " + ScoreService.q1_score;
            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void q1_backButton_Click(object sender, EventArgs e)
        {

        }

        private async void q1_confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (checkBoxGreenTrack.Checked == true)
            {
                q1_answerLabel.Visible = true;
                q1_signLeave.Visible = true;

                q1_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q1_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q1_score = ScoreService.q0_score + 5;
                q1_labelScore.Text = "Score : " + ScoreService.q1_score;

                q1_nextButton.Visible = true;
                q1_nextButton.Enabled = false;
                q1_backButton.Enabled = false;
                q1_confirmAnswerButton.Visible = false;

                await Task.Delay(10000);

                q1_confirmAnswerButton.Visible = false;
                q1_nextButton.Enabled = true;
            }
            else
            {
                q1_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q1_groupBoxQuestionnaire.ForeColor = Color.Red;

                if (ScoreService.q1_score == 0)
                { }
                else
                {
                    ScoreService.q1_score--;
                    q1_labelScore.Text = "Score : " + ScoreService.q1_score;
                }
            }
        }

        private async void q1_nextButton_Click(object sender, EventArgs e)
        {
            if (q1_answerLabel.Visible == false)
            {
                q1_answerLabel.Visible = true;
                return;
            }

            if ((q1_answerLabel.Visible == true) && (q1_signLeave.Visible == true))
            {
                Q2Form Q2Form = new Q2Form();
                this.Hide();
                Q2Form.StartPosition = FormStartPosition.Manual;
                Q2Form.Location = new Point(10, 10);
                Q2Form.Show();
            }
        }

        private void checkBoxCycleTrack_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCycleTrack.Checked == true)
            {
                checkBoxCycleArea.Checked = false;
                checkBoxGreenTrack.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxCycleArea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCycleArea.Checked == true)
            {
                checkBoxCycleTrack.Checked = false;
                checkBoxGreenTrack.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreenTrack.Checked == true)
            {
                checkBoxCycleArea.Checked = false;
                checkBoxCycleTrack.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxAutoRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoRoad.Checked == true)
            {
                checkBoxCycleArea.Checked = false;
                checkBoxGreenTrack.Checked = false;
                checkBoxCycleTrack.Checked = false;
            }
        }
    }
}