using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Virus_Creator_GUI
{
    public partial class spanishForm : Form
    {
        public spanishForm()
        {
            InitializeComponent();
        }

        private void SpanishForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_openWebsite_Click(object sender, EventArgs e)
        {
            //Inicializar los componentes
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            string virusURL;

            //Escribe los textos del InputBox
            form.Text = "URL";
            label.Text = "Escribe aqui la URL que quieres que el virus redirija: ";
            //textBox.Text = virusURL;

            //La configuracion de los botones
            buttonOk.Text = "Listo";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            //La posicion de los botones
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            //Tamaño de los elementos mostrados en pantalla
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //Parametros del InputBox
            form.ClientSize = new Size(396, 107);
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            virusURL = textBox.Text;

            //Agrega el contenido al archivo
        }
    }
}
