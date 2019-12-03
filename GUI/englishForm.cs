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
    public partial class englishForm : Form
    {
        /* Works?
        //Crea el archivo
        FileStream virusFile = File.Create("virus.vbs");
        */

        public englishForm()
        {
            InitializeComponent();
        }

        private void EnglishForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_openWebsite_Click(object sender, EventArgs e)
        {

        }

        private void Btn_otherAlert_Click(object sender, EventArgs e)
        {

        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El virus ha sido creado correctamente!");
            Application.Exit();
        }

        private void Btn_vName_Click(object sender, EventArgs e)
        {

        }
        private void Btn_shutdown_Click(object sender, EventArgs e)
        {

        }

        private void Btn_customScript_Click(object sender, EventArgs e)
        {

        }

        private void Btn_spamMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
