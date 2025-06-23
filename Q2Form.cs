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
            q2_labelScore.Text = "Score : " + ScoreService.q2_score;
            q2_labelPseudo.Text = "";
        }

        private async void q2_confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (q2_checkBoxAutoRoad.Checked == true)
            {
                q2_checkBoxAutoRoad.ForeColor = Color.Red;
            }
            if (q2_checkBoxForrbidenRoad.Checked == true)
            {
                q2_checkBoxForrbidenRoad.ForeColor = Color.Red;
            }
            if (q2_checkBoxGreenTrack.Checked == true)
            {
                q2_checkBoxGreenTrack.ForeColor = Color.Red;
            }

            if (q2_checkBoxCyclablePiste.Checked == true)
            {
                q2_checkBoxAutoRoad.ForeColor = Color.Red;
                q2_checkBoxForrbidenRoad.ForeColor = Color.Red;
                q2_checkBoxGreenTrack.ForeColor = Color.Red;

                q2_labelAnswer.Visible = true;
                q2_pictureBoxSignLeave.Visible = true;
                q2_labelAnswer2.Visible = true;
                q2_pictureBSignForced.Visible = true;
                q2_pictureBSignForced1.Visible = true;


                q2_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q2_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q2_score = ScoreService.q2_score + ScoreService.win;
                q2_labelScore.Text = "Score : " + ScoreService.q2_score;
                q2_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q2_buttonNext.Visible = true;
                q2_buttonNext.Enabled = false;
                q2_buttonBack.Enabled = false;
                q2_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q2_buttonNext.Enabled = true;
            }
            else
            {
                q2_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q2_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q2_groupBoxQuestionnaire.ForeColor = Color.Red;

                await Task.Delay(500);

                q2_groupBoxQuestionnaire.Text = "";
                q2_groupBoxQuestionnaire.ForeColor = Color.Black;

                if (ScoreService.q2_score == 0)
                { }
                else
                {
                    ScoreService.q2_score--;
                    q2_labelScore.Text = "Score : " + ScoreService.q2_score;
                }
            }
        }

        private void checkBoxCyclablePiste_CheckedChanged(object sender, EventArgs e)
        {
            if (q2_checkBoxCyclablePiste.Checked == true)
            {
                q2_checkBoxGreenTrack.Checked = false;
                q2_checkBoxForrbidenRoad.Checked = false;
                q2_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (q2_checkBoxGreenTrack.Checked == true)
            {
                q2_checkBoxCyclablePiste.Checked = false;
                q2_checkBoxForrbidenRoad.Checked = false;
                q2_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxForrbidenRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (q2_checkBoxForrbidenRoad.Checked == true)
            {
                q2_checkBoxCyclablePiste.Checked = false;
                q2_checkBoxGreenTrack.Checked = false;
                q2_checkBoxAutoRoad.Checked = false;
            }
        }

        private void checkBoxAutoRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (q2_checkBoxAutoRoad.Checked == true)
            {
                q2_checkBoxCyclablePiste.Checked = false;
                q2_checkBoxGreenTrack.Checked = false;
                q2_checkBoxForrbidenRoad.Checked = false;
            }
        }
        private void q2_buttonBack_Click(object sender, EventArgs e)
        {
            Q1Form Q1Form = new Q1Form();
            this.Hide();
            Q1Form.StartPosition = FormStartPosition.Manual;
            Q1Form.Location = new Point(10, 10);
            Q1Form.Show();
        }

        private void q2_nextButton_Click(object sender, EventArgs e)
        {
            Q3Form Q3Form = new Q3Form();
            this.Hide();
            Q3Form.StartPosition = FormStartPosition.Manual;
            Q3Form.Location = new Point(10, 10);
            Q3Form.Show();
        }
    }
}
