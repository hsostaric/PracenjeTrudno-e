namespace AplikacijaPracenjeTrudnoce.forme
{
    partial class GlavniIzbornik
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
            this.uiLoginUser = new System.Windows.Forms.Label();
            this.uiLogOut = new System.Windows.Forms.Button();
            this.uiDodajTrudnocu = new System.Windows.Forms.Button();
            this.uiMojeTrudnoce = new System.Windows.Forms.Button();
            this.uiZakaziPregled = new System.Windows.Forms.Button();
            this.uiVidiPreglede = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiLoginUser
            // 
            this.uiLoginUser.AutoSize = true;
            this.uiLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLoginUser.Location = new System.Drawing.Point(13, 13);
            this.uiLoginUser.Name = "uiLoginUser";
            this.uiLoginUser.Size = new System.Drawing.Size(121, 16);
            this.uiLoginUser.TabIndex = 0;
            this.uiLoginUser.Text = "Prijavljeni korisnik: ";
            // 
            // uiLogOut
            // 
            this.uiLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLogOut.Location = new System.Drawing.Point(517, 13);
            this.uiLogOut.Name = "uiLogOut";
            this.uiLogOut.Size = new System.Drawing.Size(171, 36);
            this.uiLogOut.TabIndex = 1;
            this.uiLogOut.Text = "Odjava";
            this.uiLogOut.UseVisualStyleBackColor = true;
            this.uiLogOut.Click += new System.EventHandler(this.uiLogOut_Click);
            // 
            // uiDodajTrudnocu
            // 
            this.uiDodajTrudnocu.Location = new System.Drawing.Point(16, 53);
            this.uiDodajTrudnocu.Name = "uiDodajTrudnocu";
            this.uiDodajTrudnocu.Size = new System.Drawing.Size(118, 40);
            this.uiDodajTrudnocu.TabIndex = 2;
            this.uiDodajTrudnocu.Text = "Nova trudnoća";
            this.uiDodajTrudnocu.UseVisualStyleBackColor = true;
            this.uiDodajTrudnocu.Click += new System.EventHandler(this.uiDodajTrudnocu_Click);
            // 
            // uiMojeTrudnoce
            // 
            this.uiMojeTrudnoce.Location = new System.Drawing.Point(177, 53);
            this.uiMojeTrudnoce.Name = "uiMojeTrudnoce";
            this.uiMojeTrudnoce.Size = new System.Drawing.Size(118, 40);
            this.uiMojeTrudnoce.TabIndex = 3;
            this.uiMojeTrudnoce.Text = "Moje trudnoće";
            this.uiMojeTrudnoce.UseVisualStyleBackColor = true;
            this.uiMojeTrudnoce.Click += new System.EventHandler(this.uiMojeTrudnoce_Click);
            // 
            // uiZakaziPregled
            // 
            this.uiZakaziPregled.Location = new System.Drawing.Point(16, 121);
            this.uiZakaziPregled.Name = "uiZakaziPregled";
            this.uiZakaziPregled.Size = new System.Drawing.Size(118, 40);
            this.uiZakaziPregled.TabIndex = 4;
            this.uiZakaziPregled.Text = "Zakaži pregled";
            this.uiZakaziPregled.UseVisualStyleBackColor = true;
            this.uiZakaziPregled.Click += new System.EventHandler(this.uiZakaziPregled_Click);
            // 
            // uiVidiPreglede
            // 
            this.uiVidiPreglede.Location = new System.Drawing.Point(177, 121);
            this.uiVidiPreglede.Name = "uiVidiPreglede";
            this.uiVidiPreglede.Size = new System.Drawing.Size(118, 40);
            this.uiVidiPreglede.TabIndex = 5;
            this.uiVidiPreglede.Text = "Moji pregledi";
            this.uiVidiPreglede.UseVisualStyleBackColor = true;
            this.uiVidiPreglede.Click += new System.EventHandler(this.uiVidiPreglede_Click);
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiVidiPreglede);
            this.Controls.Add(this.uiZakaziPregled);
            this.Controls.Add(this.uiMojeTrudnoce);
            this.Controls.Add(this.uiDodajTrudnocu);
            this.Controls.Add(this.uiLogOut);
            this.Controls.Add(this.uiLoginUser);
            this.Name = "GlavniIzbornik";
            this.Text = "GlavniIzbornik";
            this.Load += new System.EventHandler(this.GlavniIzbornik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLoginUser;
        private System.Windows.Forms.Button uiLogOut;
        private System.Windows.Forms.Button uiDodajTrudnocu;
        private System.Windows.Forms.Button uiMojeTrudnoce;
        private System.Windows.Forms.Button uiZakaziPregled;
        private System.Windows.Forms.Button uiVidiPreglede;
    }
}