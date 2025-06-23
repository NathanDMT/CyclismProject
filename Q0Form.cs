using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyclismProject.Services;

namespace CyclismProject
{
    public partial class Q0Form : Form
    {
        public Q0Form()
        {
            InitializeComponent();
            // Initialise le score, le pseudo et l'affiche
            q0_labelScore.Text = "Score : " + ScoreService.q0_score;
            q0_labelPseudo.Text = "";

            AnswerService.AnswerAfterConfirm = 6;
            AnswerService.AnswerRemaining = 6;
            q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining.ToString() + " restantes";

            this.FormClosing += Form_FormClosing;
        }

        // Check si l'utilisateur ferme le programme à partir de la croix rouge de la fenêtre
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        // Button vérifiant si la réponse de l'utilisateur est bonne, dans ce cas, un complément d'informations s'affiche, et l'utilisateur gagne ScoreService.win points.
        // Dans le cas contraire, l'utilisateur perd ScoreService.loose points
        private async void q0_buttonNext_Click(object sender, EventArgs e)
        {
            if (q0_groupBoxQuestionnaire.Visible == false)
            {
                q0_buttonNext.Visible = false;
                q0_groupBoxQuestionnaire.Visible = true;
                return;

            }

            if ((q0_labelQuestion.Visible == true) && (q0_labelAnswer.Visible == true))
            {
                Q1Form Q1Form = new Q1Form();
                this.Hide();
                Q1Form.StartPosition = FormStartPosition.Manual;
                Q1Form.Location = new Point(10, 10);
                Q1Form.Show();
            }
        }

        private async void q0_confirmAnswer_Click(object sender, EventArgs e)
        {
            if (q0_checkBoxHelmet.Checked == true && q0_checkBoxGloves.Checked == false && q0_checkBoxRing.Checked == true && q0_checkBoxFrontLight.Checked == true && q0_checkBoxBackLight.Checked == true && q0_checkBoxBrakes.Checked == true && q0_checkBoxGlasses.Checked == false && q0_checkBoxWater.Checked == false && q0_checkBoxReflector.Checked == true && q0_checkBoxFood.Checked == false)
            {
                if (q0_checkBoxGloves.Checked == true)
                {
                    q0_checkBoxGloves.ForeColor = Color.Red;
                }
                if (q0_checkBoxGlasses.Checked == true)
                {
                    q0_checkBoxGlasses.ForeColor = Color.Red;
                }
                if (q0_checkBoxWater.Checked == true)
                {
                    q0_checkBoxWater.ForeColor = Color.Red;
                }
                if (q0_checkBoxFood.Checked == true)
                {
                    q0_checkBoxFood.ForeColor = Color.Red;
                }

                // Affichage de la réponse, du label post-réponse en couleur verte, ajoute ScoreService.win points au score, modification du label score, masque du bouton de validation et du bouton recommencer
                q0_labelAnswer.Visible = true;

                q0_groupBoxQuestionnaire.Text = "Bonne réponse!";
                q0_labelQuestion.ForeColor = Color.Green;
                q0_checkBoxHelmet.ForeColor = Color.Green;
                q0_checkBoxRing.ForeColor = Color.Green;
                q0_checkBoxFrontLight.ForeColor = Color.Green;
                q0_checkBoxBackLight.ForeColor = Color.Green;
                q0_checkBoxBrakes.ForeColor = Color.Green;
                q0_checkBoxReflector.ForeColor = Color.Green;
                ScoreService.q0_score =+ ScoreService.win;
                q0_labelScore.Text = "Score : " + ScoreService.q0_score;
                q0_labelPseudo.Text = OtherService.win + OtherService.pseudo;

                q0_buttonNext.Visible = true;
                q0_buttonNext.Enabled = false;
                q0_buttonBack.Enabled = false;
                q0_buttonConfirmAnswer.Visible = false;

                await Task.Delay(5000);

                q0_buttonNext.Enabled = true;
            }
            else if (q0_checkBoxHelmet.Checked == true && q0_checkBoxGloves.Checked == true && q0_checkBoxRing.Checked == true && q0_checkBoxFrontLight.Checked == true && q0_checkBoxBackLight.Checked == true && q0_checkBoxBrakes.Checked == true && q0_checkBoxGlasses.Checked == true && q0_checkBoxWater.Checked == true && q0_checkBoxReflector.Checked == true && q0_checkBoxFood.Checked == true)
            {
                q0_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q0_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q0_groupBoxQuestionnaire.ForeColor = Color.Red;
                q0_buttonConfirmAnswer.Enabled = false;

                await Task.Delay(600);

                q0_groupBoxQuestionnaire.Text = "";
                q0_labelPseudo.Text = "Essaie encore ! " + OtherService.pseudo;
                q0_groupBoxQuestionnaire.ForeColor = Color.Black;
                q0_buttonConfirmAnswer.Enabled = true;


                if (ScoreService.q0_score == 0)
                { }
                else
                {
                    ScoreService.q0_score = -3;
                    q0_labelScore.Text = "Score : " + ScoreService.q0_score;
                }
            }
            else
            {
                if (q0_checkBoxHelmet.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxHelmet.ForeColor = Color.Green;
                }
                if (q0_checkBoxRing.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxRing.ForeColor = Color.Green;
                }
                if (q0_checkBoxFrontLight.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxFrontLight.ForeColor = Color.Green;
                }
                if (q0_checkBoxBackLight.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxBackLight.ForeColor = Color.Green;
                }
                if (q0_checkBoxBrakes.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxBrakes.ForeColor = Color.Green;
                }
                if (q0_checkBoxReflector.Checked == true)
                {
                    AnswerService.AnswerAfterConfirm--;
                    q0_checkBoxReflector.ForeColor = Color.Green;
                }
                if (q0_checkBoxGloves.Checked == true)
                {
                    q0_checkBoxGloves.ForeColor = Color.Red;
                }
                if (q0_checkBoxGlasses.Checked == true)
                {
                    q0_checkBoxGlasses.ForeColor = Color.Red;
                }
                if (q0_checkBoxWater.Checked == true)
                {
                    q0_checkBoxWater.ForeColor = Color.Red;
                }
                if (q0_checkBoxFood.Checked == true)
                {
                    q0_checkBoxFood.ForeColor = Color.Red;
                }

                q0_groupBoxQuestionnaire.Text = "Mauvaise réponse!";
                q0_labelPseudo.Text = OtherService.loose + OtherService.pseudo;
                q0_groupBoxQuestionnaire.ForeColor = Color.Red;
                q0_buttonConfirmAnswer.Enabled = false;


                await Task.Delay(600);

                q0_groupBoxQuestionnaire.Text = "";
                q0_labelPseudo.Text = "Essaie encore " + OtherService.pseudo + " !";
                q0_groupBoxQuestionnaire.ForeColor = Color.Black;
                q0_buttonConfirmAnswer.Enabled = true;


                if (ScoreService.q0_score == 0)
                { }
                else
                {
                    ScoreService.q0_score = -ScoreService.loose;
                    q0_labelScore.Text = "Score : " + ScoreService.q0_score;
                }
            }
        }

        private void q0_backButton_Click(object sender, EventArgs e)
        {
            StartForm StartForm = new StartForm();
            this.Hide();
            StartForm.StartPosition = FormStartPosition.Manual;
            StartForm.Location = new Point(10, 10);
            StartForm.Show();
        }

        private void q0_checkBoxHelmet_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxHelmet.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxHelmet.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxGloves_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxGloves.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxGloves.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxRing_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxRing.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxRing.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxFrontLight_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxFrontLight.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxFrontLight.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxBackLight_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxBackLight.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxBackLight.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxBrakes_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxBrakes.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxBrakes.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxGlasses_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxGlasses.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxGlasses.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxWater.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxWater.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxReflector_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxReflector.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxReflector.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }

        private void q0_checkBoxFood_CheckedChanged(object sender, EventArgs e)
        {
            if (q0_checkBoxFood.Checked == true)
            {
                AnswerService.AnswerRemaining--;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
            if (q0_checkBoxFood.Checked == false)
            {
                AnswerService.AnswerRemaining++;
                if (AnswerService.AnswerRemaining < 1)
                {
                    q0_labelAnswerRemaining.Text = "0 restantes";
                }
                if (AnswerService.AnswerRemaining > 0)
                {
                    q0_labelAnswerRemaining.Text = AnswerService.AnswerRemaining + " restantes";
                }
            }
        }
    }
}
