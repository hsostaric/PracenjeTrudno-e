namespace AplikacijaPracenjeTrudnoce.forme
{
    partial class NoviPregled
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
            this.dtOdabirDatumaPregleda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVrstaPregleda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLijecnici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum pregleda";
            // 
            // dtOdabirDatumaPregleda
            // 
            this.dtOdabirDatumaPregleda.Location = new System.Drawing.Point(134, 34);
            this.dtOdabirDatumaPregleda.Name = "dtOdabirDatumaPregleda";
            this.dtOdabirDatumaPregleda.Size = new System.Drawing.Size(259, 20);
            this.dtOdabirDatumaPregleda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta pregleda";
            // 
            // cbVrstaPregleda
            // 
            this.cbVrstaPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVrstaPregleda.FormattingEnabled = true;
            this.cbVrstaPregleda.Location = new System.Drawing.Point(134, 73);
            this.cbVrstaPregleda.Name = "cbVrstaPregleda";
            this.cbVrstaPregleda.Size = new System.Drawing.Size(259, 24);
            this.cbVrstaPregleda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liječnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(134, 171);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(259, 96);
            this.txtOpis.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(432, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(432, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 65);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLijecnici
            // 
            this.lbLijecnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLijecnici.FormattingEnabled = true;
            this.lbLijecnici.ItemHeight = 16;
            this.lbLijecnici.Location = new System.Drawing.Point(134, 109);
            this.lbLijecnici.Name = "lbLijecnici";
            this.lbLijecnici.Size = new System.Drawing.Size(259, 52);
            this.lbLijecnici.TabIndex = 10;
            // 
            // NoviPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 309);
            this.Controls.Add(this.lbLijecnici);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVrstaPregleda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtOdabirDatumaPregleda);
            this.Controls.Add(this.label1);
            this.Name = "NoviPregled";
            this.Text = "Novi pregled";
            this.Load += new System.EventHandler(this.NoviPregled_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtOdabirDatumaPregleda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVrstaPregleda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbLijecnici;
    }
}