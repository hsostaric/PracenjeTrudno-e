namespace AplikacijaPracenjeTrudnoce.forme
{
    partial class NovaTrudnoca
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
            this.uiDodajTrudnocu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiDatumZaceca = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uiDodajTrudnocu
            // 
            this.uiDodajTrudnocu.Location = new System.Drawing.Point(12, 62);
            this.uiDodajTrudnocu.Name = "uiDodajTrudnocu";
            this.uiDodajTrudnocu.Size = new System.Drawing.Size(110, 38);
            this.uiDodajTrudnocu.TabIndex = 0;
            this.uiDodajTrudnocu.Text = "Dodaj trudnoću";
            this.uiDodajTrudnocu.UseVisualStyleBackColor = true;
            this.uiDodajTrudnocu.Click += new System.EventHandler(this.uiDodajTrudnocu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum začeća: ";
            // 
            // uiDatumZaceca
            // 
            this.uiDatumZaceca.Location = new System.Drawing.Point(123, 20);
            this.uiDatumZaceca.Name = "uiDatumZaceca";
            this.uiDatumZaceca.Size = new System.Drawing.Size(200, 20);
            this.uiDatumZaceca.TabIndex = 2;
            // 
            // NovaTrudnoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 171);
            this.Controls.Add(this.uiDatumZaceca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiDodajTrudnocu);
            this.Name = "NovaTrudnoca";
            this.Text = "Nova Trudnoca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiDodajTrudnocu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker uiDatumZaceca;
    }
}