using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalApp
{
    public partial class FormMeniu : Form
    {
        public FormMeniu()
        {
            InitializeComponent();
        }

        private void buttonClienti_Click(object sender, EventArgs e)
        {
            new FormClient().ShowDialog();
        }

        private void buttonFilme_Click(object sender, EventArgs e)
        {
            new FormFilm().ShowDialog();
        }

        private void buttonInchirieri_Click(object sender, EventArgs e)
        {
            new FormInchirieri().ShowDialog();
        }
    }
}
