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
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void presentationButton_Click(object sender, EventArgs e)
        {
            Q0Form Q0Form = new Q0Form();
            Q0Form.Show();
            this.Hide();
            Q0Form.StartPosition = FormStartPosition.Manual;
            Q0Form.Location = new Point(10, 10);
            Q0Form.Show();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
