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
    public partial class EndForm : Form
    {

        public EndForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;

            end_labelScore.Text = "Score : " + ScoreService.q6_score;
            end_labelPseudo.Text = OtherService.pseudo;

            if (ScoreService.q6_score < 7)
            {
                end_labelScoreMessage.Text = "Dommage, essaie à nouveau pour améliorer ton score!";
            }
            if (ScoreService.q6_score < 12)
            {
                end_labelScoreMessage.Text = "Essaie encore, tu peux améliorer ton score!";
            }
            if (ScoreService.q6_score < 17)
            {
                end_labelScoreMessage.Text = "Pas mal! tu peux améliorer ton score!";
            }
            if (ScoreService.q6_score < 23)
            {
                end_labelScoreMessage.Text = "Fortiche! Tu as presque fait un score parfait!";
            }
            if (ScoreService.q6_score == 23)
            {
                end_labelScoreMessage.Text = "Excellent! Tu as obtenu un sans faute!";
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void end_buttonRestart_Click(object sender, EventArgs e)
        {
            StartForm StartForm = new StartForm();
            StartForm.Show();
            this.Hide();
            StartForm.StartPosition = FormStartPosition.Manual;
            StartForm.Location = new Point(10, 10);
            StartForm.Show();
        }
    }
}
