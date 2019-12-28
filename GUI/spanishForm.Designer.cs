namespace Virus_Creator_GUI
{
    partial class spanishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_openWebsite = new System.Windows.Forms.Button();
            this.btn_otherAlert = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.btn_customScript = new System.Windows.Forms.Button();
            this.btn_spamMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creador de Virus:";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(99, 206);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(131, 52);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Construir";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // btn_openWebsite
            // 
            this.btn_openWebsite.Location = new System.Drawing.Point(55, 43);
            this.btn_openWebsite.Name = "btn_openWebsite";
            this.btn_openWebsite.Size = new System.Drawing.Size(220, 23);
            this.btn_openWebsite.TabIndex = 4;
            this.btn_openWebsite.Text = "Abrir Sitio Web";
            this.btn_openWebsite.UseVisualStyleBackColor = true;
            this.btn_openWebsite.Click += new System.EventHandler(this.Btn_openWebsite_Click);
            // 
            // btn_otherAlert
            // 
            this.btn_otherAlert.Location = new System.Drawing.Point(55, 72);
            this.btn_otherAlert.Name = "btn_otherAlert";
            this.btn_otherAlert.Size = new System.Drawing.Size(220, 23);
            this.btn_otherAlert.TabIndex = 5;
            this.btn_otherAlert.Text = "Abrir otra alerta";
            this.btn_otherAlert.UseVisualStyleBackColor = true;
            this.btn_otherAlert.Click += new System.EventHandler(this.Btn_otherAlert_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(55, 102);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(220, 23);
            this.btn_shutdown.TabIndex = 6;
            this.btn_shutdown.Text = "Apagar PC";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.Btn_shutdown_Click);
            // 
            // btn_customScript
            // 
            this.btn_customScript.Location = new System.Drawing.Point(55, 132);
            this.btn_customScript.Name = "btn_customScript";
            this.btn_customScript.Size = new System.Drawing.Size(220, 23);
            this.btn_customScript.TabIndex = 7;
            this.btn_customScript.Text = "Script Personalizado";
            this.btn_customScript.UseVisualStyleBackColor = true;
            this.btn_customScript.Click += new System.EventHandler(this.Btn_customScript_Click);
            // 
            // btn_spamMessage
            // 
            this.btn_spamMessage.Location = new System.Drawing.Point(55, 162);
            this.btn_spamMessage.Name = "btn_spamMessage";
            this.btn_spamMessage.Size = new System.Drawing.Size(220, 23);
            this.btn_spamMessage.TabIndex = 8;
            this.btn_spamMessage.Text = "Mensaje Spam";
            this.btn_spamMessage.UseVisualStyleBackColor = true;
            this.btn_spamMessage.Click += new System.EventHandler(this.Btn_spamMessage_Click);
            // 
            // spanishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 270);
            this.Controls.Add(this.btn_spamMessage);
            this.Controls.Add(this.btn_customScript);
            this.Controls.Add(this.btn_shutdown);
            this.Controls.Add(this.btn_otherAlert);
            this.Controls.Add(this.btn_openWebsite);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "spanishForm";
            this.Text = "Creador";
            this.Load += new System.EventHandler(this.SpanishForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_openWebsite;
        private System.Windows.Forms.Button btn_otherAlert;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.Button btn_customScript;
        private System.Windows.Forms.Button btn_spamMessage;
    }
}