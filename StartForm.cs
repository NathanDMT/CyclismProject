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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            start_labelError.Text = "";
            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        // Bouton permetant de lancer le jeu
        private void gameButton_Click(object sender, EventArgs e)
        {
            // Récupération du pseudo du joueur avant de lancer le jeu
            OtherService.pseudo = start_textBoxPseudo.Text;

            // Vérifie si le pseudo est non vide et suppérieur à 3 caractéres
            if (OtherService.pseudo.Length > 3 && OtherService.pseudo != "")
            {
                Q0Form Q0Form = new Q0Form();
                Q0Form.Show();
                this.Hide();
                Q0Form.StartPosition = FormStartPosition.Manual;
                Q0Form.Location = new Point(10, 10);
                Q0Form.Show();
            }
            
            // Check si le pseudo est vide et/ou inférieur à 3 caractéres, dans le cas contraire un message d'erreur est retourné
            if (OtherService.pseudo.Length < 3 && OtherService.pseudo == "" && OtherService.pseudo == string.Empty)
            {
                start_labelError.Text = "Vous devez entrez un pseudo plus long afin de pouvoir lancer le jeu!";
                start_labelError.ForeColor = Color.Red;
            }

            // Check si le pseudo est supérieur à 10 caractéres, dans ce cas, un message d'erreur est retourné
            if (OtherService.pseudo.Length > 10)
            {
                start_labelError.Text = "Vous devez entrez un pseudo plus court pour lancer le jeu!";
                start_labelError.ForeColor = Color.Red;
            }
        }
    }
}
