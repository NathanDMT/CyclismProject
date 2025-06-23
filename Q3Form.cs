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
    public partial class Q3Form : Form
    {
        public Q3Form()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            ScoreService.q3_score = ScoreService.q2_score;

            AnswerService.AnswerRemaining = 2;
            q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining.ToString() + " restantes";

            q3_labelScore.Text = "Score : " + ScoreService.q3_score;
            q3_labelPseudo.Text = "";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void q3_buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            if (q3_checkBoxFakeConditions.Checked == true)
            {
                q3_checkBoxFakeConditions.ForeColor = Color.Red;
            }
            if (q3_checkBoxGoLeft.Checked == true)
            {
                q3_checkBoxGoLeft.ForeColor = Color.Red;
            }
            if (q3_checkBoxGoRight.Checked == true)
            {
                q3_checkBoxGoRight.ForeColor = Color.Red;
            }

            if ((q3_checkBoxGoEverywhere.Checked == true) && (q3_checkBoxConditionValide.Checked == true))
            {
                q3_labelAnswer.Visible = true;
                q3_pictureBoxOtherSign.Visible = true;
                q3_pictureBoxOtherSign1.Visible = true;

                q3_checkBoxFakeConditions.ForeColor = Color.Red;
                q3_checkBoxGoLeft.ForeColor = Color.Red;
                q3_checkBoxGoRight.ForeColor = Color.Red;

                q3_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q3_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q3_score = ScoreService.q3_score + ScoreService.win;
                q3_labelScore.Text = "Score : " + ScoreService.q3_score;
                q3_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q3_buttonNext.Visible = true;
                q3_buttonNext.Enabled = false;
                q3_buttonBack.Enabled = false;
                q3_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q3_buttonNext.Enabled = true;
            }
            else
            {
                q3_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q3_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q3_groupBoxQuestionnaire.ForeColor = Color.Red;

                await Task.Delay(500);

                q3_groupBoxQuestionnaire.Text = "";
                q3_groupBoxQuestionnaire.ForeColor = Color.Black;

                if (ScoreService.q3_score == 0)
                { }
                else
                {
                    ScoreService.q3_score = ScoreService.q3_score--;
                    q3_labelScore.Text = "Score : " + ScoreService.q3_score;
                }
            }
        }

        private void q3_checkBoxGoLeft_CheckedChanged(object sender, EventArgs e)
        {
            if(q3_checkBoxGoLeft.Checked == true)
            {
                q3_checkBoxGoRight.Checked = false;
                q3_checkBoxGoEverywhere.Checked = false;

                AnswerService.AnswerRemaining--;

                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }

            if (q3_checkBoxGoLeft.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q3_checkBoxGoRight_CheckedChanged(object sender, EventArgs e)
        {
            if (q3_checkBoxGoRight.Checked == true)
            {
                q3_checkBoxGoLeft.Checked = false;
                q3_checkBoxGoEverywhere.Checked = false;

                AnswerService.AnswerRemaining--;

                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }

            if (q3_checkBoxGoRight.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q3_checkBoxGoEverywhere_CheckedChanged(object sender, EventArgs e)
        {
            if (q3_checkBoxGoEverywhere.Checked == true)
            {
                q3_checkBoxGoLeft.Checked = false;
                q3_checkBoxGoRight.Checked = false;

                AnswerService.AnswerRemaining--;

                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }

            if (q3_checkBoxGoEverywhere.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q3_checkBoxConditionValide_CheckedChanged(object sender, EventArgs e)
        {
            if(q3_checkBoxConditionValide.Checked == true)
            {
                q3_checkBoxFakeConditions.Checked = false;

                AnswerService.AnswerRemaining--;

                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }

            if (q3_checkBoxConditionValide.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q3_checkBoxFakeConditions_CheckedChanged(object sender, EventArgs e)
        {
            if (q3_checkBoxFakeConditions.Checked == true)
            {
                q3_checkBoxConditionValide.Checked = false;

                AnswerService.AnswerRemaining--;

                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }

            if (q3_checkBoxFakeConditions.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q3_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q3_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q3_backButton_Click(object sender, EventArgs e)
        {
            Q2Form Q2Form = new Q2Form();
            this.Hide();
            Q2Form.StartPosition = FormStartPosition.Manual;
            Q2Form.Location = new Point(10, 10);
            Q2Form.Show();
        }

        private void q3_buttonNext_Click(object sender, EventArgs e)
        {
            Q4Form Q4Form = new Q4Form();
            this.Hide();
            Q4Form.StartPosition = FormStartPosition.Manual;
            Q4Form.Location = new Point(10, 10);
            Q4Form.Show();
        }

        private void Q3Form_Load(object sender, EventArgs e)
        {

        }
    }
}
