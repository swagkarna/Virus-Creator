using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool exist = File.Exists("virus.vbs");

            if(exist == true)
            {
                MessageBox.Show("You can't create a virus if this already exist!");
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
