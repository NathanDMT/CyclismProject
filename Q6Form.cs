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
    public partial class Q6Form : Form
    {
        public Q6Form()
        {
            InitializeComponent();

            q6_labelScore.Text = "Score : " + ScoreService.q5_score;
            q6_labelPseudo.Text = "";

            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void q6_buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            if (q6_checkBoxCyclableArea.Checked == true)
            {
                q6_checkBoxCyclableArea.ForeColor = Color.Red;
            }
            if (q6_checkBoxGreenTrack.Checked == true)
            {
                q6_checkBoxGreenTrack.ForeColor = Color.Red;
            }
            if (q6_checkBoxMarketArea.Checked == true)
            {
                q6_checkBoxMarketArea.ForeColor = Color.Red;
            }

            if (q6_checkBoxMettingArea.Checked == true)
            {
                q6_checkBoxCyclableArea.ForeColor = Color.Red;
                q6_checkBoxGreenTrack.ForeColor = Color.Red;
                q6_checkBoxMarketArea.ForeColor = Color.Red;

                q6_labelAnswer.Visible = true;
                q6_pictureBoxSignLeave.Visible = true;

                q6_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q6_groupBoxQuestionnaire.ForeColor = Color.Green;
                ScoreService.q6_score = ScoreService.q5_score + ScoreService.win;
                q6_labelScore.Text = "Score : " + ScoreService.q6_score;
                q6_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q6_buttonNext.Visible = true;
                q6_buttonNext.Enabled = false;
                q6_buttonBack.Enabled = false;
                q6_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q6_buttonNext.Enabled = true;
            }
            else
            {
                q6_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q6_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q6_groupBoxQuestionnaire.ForeColor = Color.Red;

                await Task.Delay(500);

                q6_groupBoxQuestionnaire.Text = "";
                q6_groupBoxQuestionnaire.ForeColor = Color.Black;

                if (ScoreService.q6_score == 0)
                { }
                else
                {
                    ScoreService.q6_score = ScoreService.q6_score--;
                    q6_labelScore.Text = "Score : " + ScoreService.q6_score;
                }
            }
        }


        private void q6_checkBoxCyclableArea_CheckedChanged(object sender, EventArgs e)
        {
            if (q6_checkBoxCyclableArea.Checked == true)
            {
                q6_checkBoxGreenTrack.Checked = false;
                q6_checkBoxMettingArea.Checked = false;
                q6_checkBoxMarketArea.Checked = false;
            }
        }

        private void q6_checkBoxGreenTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (q6_checkBoxGreenTrack.Checked == true)
            {
                q6_checkBoxCyclableArea.Checked = false;
                q6_checkBoxMettingArea.Checked = false;
                q6_checkBoxMarketArea.Checked = false;
            }
        }

        private void q6_checkBoxMettingArea_CheckedChanged(object sender, EventArgs e)
        {
            if (q6_checkBoxMettingArea.Checked == true)
            {
                q6_checkBoxCyclableArea.Checked = false;
                q6_checkBoxGreenTrack.Checked = false;
                q6_checkBoxMarketArea.Checked = false;
            }
        }

        private void q6_checkBoxMarketArea_CheckedChanged(object sender, EventArgs e)
        {
            if (q6_checkBoxMarketArea.Checked == true)
            {
                q6_checkBoxCyclableArea.Checked = false;
                q6_checkBoxGreenTrack.Checked = false;
                q6_checkBoxMettingArea.Checked = false;
            }
        }

        private void q6_buttonBack_Click(object sender, EventArgs e)
        {
            Q5Form Q5Form = new Q5Form();
            this.Hide();
            Q5Form.StartPosition = FormStartPosition.Manual;
            Q5Form.Location = new Point(10, 10);
            Q5Form.Show();
        }

        private void q6_buttonNext_Click(object sender, EventArgs e)
        {
            EndForm EndForm = new EndForm();
            this.Hide();
            EndForm.StartPosition = FormStartPosition.Manual;
            EndForm.Location = new Point(10, 10);
            EndForm.Show();
        }
    }
}
