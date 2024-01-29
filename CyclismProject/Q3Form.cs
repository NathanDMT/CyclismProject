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
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void q3_backButton_Click(object sender, EventArgs e)
        {

        }

        private void q3_nextButton_Click(object sender, EventArgs e)
        {

        }

        private void q3_buttonConfirmAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
