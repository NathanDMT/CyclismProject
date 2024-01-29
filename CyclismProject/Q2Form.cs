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
    public partial class Q2Form : Form
    {
        public Q2Form()
        {
            InitializeComponent();
            ScoreService.q2_score = ScoreService.q1_score;
            q2_labelScore.Text = "Score : " + ScoreService.q1_score;
        }

        private void q2_backButton_Click(object sender, EventArgs e)
        {

        }

        private async void q2_confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (checkBoxCyclablePiste.Checked == true)
            {
                q2_answerLabel.Visible = true;

                q2_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q2_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q2_score = ScoreService.q2_score + 5;
                q2_labelScore.Text = "Score : " + ScoreService.q2_score;

                q2_nextButton.Visible = true;
                q2_nextButton.Enabled = false;
                q2_backButton.Enabled = false;
                q2_confirmAnswerButton.Visible = false;

                await Task.Delay(10000);

                q2_confirmAnswerButton.Visible = false;
                q2_nextButton.Enabled = true;
            }
            else
            {
                q2_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q2_groupBoxQuestionnaire.ForeColor = Color.Red;

                if (ScoreService.q2_score == 0)
                { }
                else
                {
                    ScoreService.q2_score--;
                    q2_labelScore.Text = "Score : " + ScoreService.q2_score;
                }
            }
        }

        private void q2_nextButton_Click(object sender, EventArgs e)
        {
            if (q2_answerLabel.Visible == false)
            {
                q2_answerLabel.Visible = true;
                return;
            }

            if ((q2_answerLabel.Visible == true))
            {
                q2_nextButton.Text = "Suivant";
                q2_signLeave.Visible = true;
                return;
            }

            if ((q2_answerLabel.Visible == true) && (q2_signLeave.Visible == true))
            {
                Q2Form Q2Form = new Q2Form();
                this.Hide();
                Q2Form.StartPosition = FormStartPosition.Manual;
                Q2Form.Location = new Point(10, 10);
                Q2Form.Show();
            }
        }

        private void checkBoxCyclablePiste_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCyclablePiste.Checked == true)
            {
                checkBoxGreenTrack.Checked = false;
                checkBoxForrbidenRoad.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreenTrack.Checked == true)
            {
                checkBoxCyclablePiste.Checked = false;
                checkBoxForrbidenRoad.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxForrbidenRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxForrbidenRoad.Checked == true)
            {
                checkBoxCyclablePiste.Checked = false;
                checkBoxGreenTrack.Checked = false;
                checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxAutoRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoRoad.Checked == true)
            {
                checkBoxCyclablePiste.Checked = false;
                checkBoxGreenTrack.Checked = false;
                checkBoxForrbidenRoad.Checked = false;
            }
        }
    }
}
