using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Creator_GUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Text1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_spanish_Click(object sender, EventArgs e)
        {
            spanishForm spanish = new spanishForm();
            spanish.Show();
        }

        private void Btn_english_Click(object sender, EventArgs e)
        {
            englishForm english = new englishForm();
            english.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
