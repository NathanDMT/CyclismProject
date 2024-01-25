using CyclismProject.Entity;
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
        public static int _q0Score = 0;
        public static int _q1Score = _q0Score;
        public static int _q2Score = _q1Score;
        public static int _q3Score = _q2Score;
        public static int _q4Score = _q3Score;
        public static int _q5Score = _q4Score;


        public static string GlobalVar
        {
            get { return _q0Score.ToString(); }
            set { _q0Score = int.Parse(value); }
        }

        public Q0Form()
        {
            InitializeComponent();
            q0_labelScore.Text = "Score : " + _q0Score;
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void nextButton_Click(object sender, EventArgs e)
        {
            if (q0_grpBoxQuestion.Visible == false)
            {
                q0_nextButton.Visible = false;
                q0_grpBoxQuestion.Visible = true;
                return;

            }

            if ((q0_question.Visible == true) && (q0_answerLabel.Visible == true))
            {
                Q1Form Q1Form = new Q1Form();
                this.Hide();
                Q1Form.StartPosition = FormStartPosition.Manual;
                Q1Form.Location = new Point(10,10);
                Q1Form.Show();
            }
        }

        private async void q0_confirmAnswer_Click(object sender, EventArgs e)
        {
            if ((q0_checkBoxHelmet.Checked == true) && (q0_checkBoxRing.Checked == true) && (q0_checkBoxFrontLight.Checked == true) && (q0_checkBoxBackLight.Checked == true) && (q0_checkBoxBrakes.Checked == true) && (q0_checkBoxReflector.Checked == true))
            {
                // Affichage de la réponse, du label post-réponse en couleur verte, ajout de 5 points au score, modification du label score, masque du bouton de validation et du bouton recommencer
                q0_answerLabel.Visible = true;

                q0_answerResponse.Text = "Bonne réponse!";
                q0_answerResponse.ForeColor = Color.Green;
                _q0Score = _q0Score + 5;
                q0_labelScore.Text = "Score : " + _q0Score;

                q0_nextButton.Visible = true;
                q0_nextButton.Enabled = false;
                q0_backButton.Enabled = false;
                q0_confirmAnswerButton.Visible = false;

                await Task.Delay(10000);

                q0_confirmAnswerButton.Visible = false;
                q0_nextButton.Enabled = true;
                return;
            }
            else
            {
                q0_answerResponse.Text = "Mauvaise réponse!";
                q0_answerResponse.ForeColor = Color.Red;
                
                if (_q0Score == 0)
                {}
                else
                {
                    _q0Score = _q0Score - 1;
                    q0_labelScore.Text = "Score : " + _q0Score;
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
    }
}
