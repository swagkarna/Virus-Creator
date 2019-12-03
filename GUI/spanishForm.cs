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

        private void Btn_otherAlert_Click(object sender, EventArgs e)
        {
            //Inicializar los componentes
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            string virusAlerta;

            //Escribe los textos del InputBox
            form.Text = "Otra Alerta";
            label.Text = "Escribe aqui el otro mensaje que quieres que el virus de: ";

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
            virusAlerta = textBox.Text;

            //Agrega el contenido al archivo
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El virus ha sido creado correctamente!");
            Application.Exit();
        }

        private void Btn_vName_Click(object sender, EventArgs e)
        {
            //Inicializar los componentes
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            string virusName;

            //Escribe los textos del InputBox
            form.Text = "Nombre del virus";
            label.Text = "Escribe aqui el nombre de tu virus: ";

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
            virusName = textBox.Text;

            //Agrega el contenido al archivo
        }

        private void Btn_shutdown_Click(object sender, EventArgs e)
        {
            //Aqui va el Script de apagado ;D
        }

        private void Btn_customScript_Click(object sender, EventArgs e)
        {
            //Inicializar los componentes
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            string customScript;

            //Escribe los textos del InputBox
            form.Text = "Script Personalizado";
            label.Text = "Escribe aqui el script personalizado: ";

            //textBox.Text = virusURL;

            //La configuracion de los botones
            buttonOk.Text = "Listo";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            //La posicion de los botones
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 372);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            //Tamaño de los elementos mostrados en pantalla
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //Parametros del InputBox
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
            customScript = textBox.Text;

            //Agrega el contenido al archivo
        }

        private void Btn_spamMessage_Click(object sender, EventArgs e)
        {
            //Inicializar los componentes
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            string spamMessage;

            //Escribe los textos del InputBox
            form.Text = "Script Personalizado";
            label.Text = "Escribe aqui el script personalizado: ";

            //textBox.Text = virusURL;

            //La configuracion de los botones
            buttonOk.Text = "Listo";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            //La posicion de los botones
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 372);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            //Tamaño de los elementos mostrados en pantalla
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //Parametros del InputBox
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
            spamMessage = textBox.Text;

            //Agrega el contenido al archivo
        }
    }
}
