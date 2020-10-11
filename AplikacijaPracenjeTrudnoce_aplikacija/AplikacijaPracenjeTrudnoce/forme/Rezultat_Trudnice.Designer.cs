namespace AplikacijaPracenjeTrudnoce.forme
{
    partial class Rezultat_Trudnice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiSpremi_btn = new System.Windows.Forms.Button();
            this.uiNazad_btn = new System.Windows.Forms.Button();
            this.uiTjelesnaTezina = new System.Windows.Forms.NumericUpDown();
            this.uiKrvnaGrupa = new System.Windows.Forms.ComboBox();
            this.uiRhFaktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiPrviDioTlaka = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.uiDrugiDio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uiTjelesnaTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrviDioTlaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDrugiDio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tjelesna težina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Krvna grupa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RH faktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Krvni tlak";
            // 
            // uiSpremi_btn
            // 
            this.uiSpremi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiSpremi_btn.Location = new System.Drawing.Point(29, 237);
            this.uiSpremi_btn.Name = "uiSpremi_btn";
            this.uiSpremi_btn.Size = new System.Drawing.Size(118, 51);
            this.uiSpremi_btn.TabIndex = 4;
            this.uiSpremi_btn.Text = "Spremi";
            this.uiSpremi_btn.UseVisualStyleBackColor = true;
            this.uiSpremi_btn.Click += new System.EventHandler(this.uiSpremi_btn_Click);
            // 
            // uiNazad_btn
            // 
            this.uiNazad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiNazad_btn.Location = new System.Drawing.Point(208, 237);
            this.uiNazad_btn.Name = "uiNazad_btn";
            this.uiNazad_btn.Size = new System.Drawing.Size(118, 51);
            this.uiNazad_btn.TabIndex = 5;
            this.uiNazad_btn.Text = "Nazad";
            this.uiNazad_btn.UseVisualStyleBackColor = true;
            this.uiNazad_btn.Click += new System.EventHandler(this.uiNazad_btn_Click);
            // 
            // uiTjelesnaTezina
            // 
            this.uiTjelesnaTezina.DecimalPlaces = 2;
            this.uiTjelesnaTezina.Location = new System.Drawing.Point(120, 23);
            this.uiTjelesnaTezina.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uiTjelesnaTezina.Name = "uiTjelesnaTezina";
            this.uiTjelesnaTezina.Size = new System.Drawing.Size(74, 20);
            this.uiTjelesnaTezina.TabIndex = 6;
            // 
            // uiKrvnaGrupa
            // 
            this.uiKrvnaGrupa.FormattingEnabled = true;
            this.uiKrvnaGrupa.Location = new System.Drawing.Point(120, 69);
            this.uiKrvnaGrupa.Name = "uiKrvnaGrupa";
            this.uiKrvnaGrupa.Size = new System.Drawing.Size(74, 21);
            this.uiKrvnaGrupa.TabIndex = 7;
            // 
            // uiRhFaktor
            // 
            this.uiRhFaktor.FormattingEnabled = true;
            this.uiRhFaktor.Location = new System.Drawing.Point(120, 108);
            this.uiRhFaktor.Name = "uiRhFaktor";
            this.uiRhFaktor.Size = new System.Drawing.Size(74, 21);
            this.uiRhFaktor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(205, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "kg";
            // 
            // uiPrviDioTlaka
            // 
            this.uiPrviDioTlaka.Location = new System.Drawing.Point(120, 144);
            this.uiPrviDioTlaka.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.uiPrviDioTlaka.Name = "uiPrviDioTlaka";
            this.uiPrviDioTlaka.Size = new System.Drawing.Size(74, 20);
            this.uiPrviDioTlaka.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(200, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // uiDrugiDio
            // 
            this.uiDrugiDio.Location = new System.Drawing.Point(219, 144);
            this.uiDrugiDio.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.uiDrugiDio.Name = "uiDrugiDio";
            this.uiDrugiDio.Size = new System.Drawing.Size(74, 20);
            this.uiDrugiDio.TabIndex = 12;
            // 
            // Rezultat_Trudnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 311);
            this.Controls.Add(this.uiDrugiDio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiPrviDioTlaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiRhFaktor);
            this.Controls.Add(this.uiKrvnaGrupa);
            this.Controls.Add(this.uiTjelesnaTezina);
            this.Controls.Add(this.uiNazad_btn);
            this.Controls.Add(this.uiSpremi_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rezultat_Trudnice";
            this.Text = "Rezultat Trudnice";
            this.Load += new System.EventHandler(this.Rezultat_Trudnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiTjelesnaTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrviDioTlaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDrugiDio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uiSpremi_btn;
        private System.Windows.Forms.Button uiNazad_btn;
        private System.Windows.Forms.NumericUpDown uiTjelesnaTezina;
        private System.Windows.Forms.ComboBox uiKrvnaGrupa;
        private System.Windows.Forms.ComboBox uiRhFaktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uiPrviDioTlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uiDrugiDio;
    }
}