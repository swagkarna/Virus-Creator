namespace Virus_Creator_GUI
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1 = new System.Windows.Forms.Label();
            this.btn_english = new System.Windows.Forms.Button();
            this.btn_spanish = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(120, 37);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(575, 63);
            this.text1.TabIndex = 0;
            this.text1.Text = "Select Your Language:";
            this.text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // btn_english
            // 
            this.btn_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_english.Location = new System.Drawing.Point(225, 151);
            this.btn_english.Name = "btn_english";
            this.btn_english.Size = new System.Drawing.Size(145, 74);
            this.btn_english.TabIndex = 1;
            this.btn_english.Text = "English";
            this.btn_english.UseVisualStyleBackColor = true;
            this.btn_english.Click += new System.EventHandler(this.Btn_english_Click);
            // 
            // btn_spanish
            // 
            this.btn_spanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spanish.Location = new System.Drawing.Point(445, 151);
            this.btn_spanish.Name = "btn_spanish";
            this.btn_spanish.Size = new System.Drawing.Size(145, 74);
            this.btn_spanish.TabIndex = 2;
            this.btn_spanish.Text = "Spanish";
            this.btn_spanish.UseVisualStyleBackColor = true;
            this.btn_spanish.Click += new System.EventHandler(this.Btn_spanish_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(721, 270);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 305);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_spanish);
            this.Controls.Add(this.btn_english);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button btn_english;
        private System.Windows.Forms.Button btn_spanish;
        private System.Windows.Forms.Button btn_exit;
    }
}

