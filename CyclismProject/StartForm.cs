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
        }

        private void presentationButton_Click(object sender, EventArgs e)
        {
            Q0Form Menu = new Q0Form();
            Menu.Show();
            this.Hide();
        }
    }
}
