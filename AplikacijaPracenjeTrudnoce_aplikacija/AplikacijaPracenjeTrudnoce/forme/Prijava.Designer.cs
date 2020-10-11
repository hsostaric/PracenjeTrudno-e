namespace AplikacijaPracenjeTrudnoce
{
    partial class Prijava
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
            this.btnPrijaviMe = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.lbNeuspjesnaPrijava = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrijaviMe
            // 
            this.btnPrijaviMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviMe.Location = new System.Drawing.Point(140, 224);
            this.btnPrijaviMe.Name = "btnPrijaviMe";
            this.btnPrijaviMe.Size = new System.Drawing.Size(298, 48);
            this.btnPrijaviMe.TabIndex = 0;
            this.btnPrijaviMe.Text = "Prijavi me";
            this.btnPrijaviMe.UseVisualStyleBackColor = true;
            this.btnPrijaviMe.Click += new System.EventHandler(this.btnPrijaviMe_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.Location = new System.Drawing.Point(140, 86);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(298, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(140, 137);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(298, 29);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUsername.Location = new System.Drawing.Point(39, 86);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(95, 16);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Korisničko ime";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozinka.Location = new System.Drawing.Point(39, 141);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(54, 16);
            this.lbLozinka.TabIndex = 4;
            this.lbLozinka.Text = "Lozinka";
            // 
            // lbNeuspjesnaPrijava
            // 
            this.lbNeuspjesnaPrijava.AutoSize = true;
            this.lbNeuspjesnaPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNeuspjesnaPrijava.ForeColor = System.Drawing.Color.Red;
            this.lbNeuspjesnaPrijava.Location = new System.Drawing.Point(136, 186);
            this.lbNeuspjesnaPrijava.Name = "lbNeuspjesnaPrijava";
            this.lbNeuspjesnaPrijava.Size = new System.Drawing.Size(0, 20);
            this.lbNeuspjesnaPrijava.TabIndex = 5;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 325);
            this.Controls.Add(this.lbNeuspjesnaPrijava);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnPrijaviMe);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijaviMe;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.Label lbNeuspjesnaPrijava;
    }
}

