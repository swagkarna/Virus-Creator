namespace Virus_Creator_GUI
{
    partial class englishForm
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
            this.btn_vName = new System.Windows.Forms.Button();
            this.btn_spamMessage = new System.Windows.Forms.Button();
            this.btn_customScript = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.btn_otherAlert = new System.Windows.Forms.Button();
            this.btn_openWebsite = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_vName
            // 
            this.btn_vName.Location = new System.Drawing.Point(58, 57);
            this.btn_vName.Name = "btn_vName";
            this.btn_vName.Size = new System.Drawing.Size(220, 23);
            this.btn_vName.TabIndex = 17;
            this.btn_vName.Text = "Virus Name";
            this.btn_vName.UseVisualStyleBackColor = true;
            this.btn_vName.Click += new System.EventHandler(this.Btn_vName_Click_1);
            // 
            // btn_spamMessage
            // 
            this.btn_spamMessage.Location = new System.Drawing.Point(58, 205);
            this.btn_spamMessage.Name = "btn_spamMessage";
            this.btn_spamMessage.Size = new System.Drawing.Size(220, 23);
            this.btn_spamMessage.TabIndex = 16;
            this.btn_spamMessage.Text = "Spam Message";
            this.btn_spamMessage.UseVisualStyleBackColor = true;
            this.btn_spamMessage.Click += new System.EventHandler(this.Btn_spamMessage_Click);
            // 
            // btn_customScript
            // 
            this.btn_customScript.Location = new System.Drawing.Point(58, 175);
            this.btn_customScript.Name = "btn_customScript";
            this.btn_customScript.Size = new System.Drawing.Size(220, 23);
            this.btn_customScript.TabIndex = 15;
            this.btn_customScript.Text = "Custom Script";
            this.btn_customScript.UseVisualStyleBackColor = true;
            this.btn_customScript.Click += new System.EventHandler(this.Btn_customScript_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(58, 145);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(220, 23);
            this.btn_shutdown.TabIndex = 14;
            this.btn_shutdown.Text = "Shutdown PC";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.Btn_shutdown_Click);
            // 
            // btn_otherAlert
            // 
            this.btn_otherAlert.Location = new System.Drawing.Point(58, 115);
            this.btn_otherAlert.Name = "btn_otherAlert";
            this.btn_otherAlert.Size = new System.Drawing.Size(220, 23);
            this.btn_otherAlert.TabIndex = 13;
            this.btn_otherAlert.Text = "Open other alert";
            this.btn_otherAlert.UseVisualStyleBackColor = true;
            this.btn_otherAlert.Click += new System.EventHandler(this.Btn_otherAlert_Click_1);
            // 
            // btn_openWebsite
            // 
            this.btn_openWebsite.Location = new System.Drawing.Point(58, 86);
            this.btn_openWebsite.Name = "btn_openWebsite";
            this.btn_openWebsite.Size = new System.Drawing.Size(220, 23);
            this.btn_openWebsite.TabIndex = 12;
            this.btn_openWebsite.Text = "Open Website";
            this.btn_openWebsite.UseVisualStyleBackColor = true;
            this.btn_openWebsite.Click += new System.EventHandler(this.Btn_openWebsite_Click_1);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(104, 260);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(131, 52);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Build";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Virus Creator:";
            // 
            // englishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 322);
            this.Controls.Add(this.btn_vName);
            this.Controls.Add(this.btn_spamMessage);
            this.Controls.Add(this.btn_customScript);
            this.Controls.Add(this.btn_shutdown);
            this.Controls.Add(this.btn_otherAlert);
            this.Controls.Add(this.btn_openWebsite);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "englishForm";
            this.Text = "Virus Creator";
            this.Load += new System.EventHandler(this.EnglishForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vName;
        private System.Windows.Forms.Button btn_spamMessage;
        private System.Windows.Forms.Button btn_customScript;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.Button btn_otherAlert;
        private System.Windows.Forms.Button btn_openWebsite;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label1;
    }
}