namespace AplikacijaPracenjeTrudnoce.forme
{
    partial class MojeTrudnoce
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
            this.dgvMojeTrudnoce = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTrudnoce)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojeTrudnoce
            // 
            this.dgvMojeTrudnoce.AllowUserToAddRows = false;
            this.dgvMojeTrudnoce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMojeTrudnoce.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMojeTrudnoce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeTrudnoce.Location = new System.Drawing.Point(12, 12);
            this.dgvMojeTrudnoce.MultiSelect = false;
            this.dgvMojeTrudnoce.Name = "dgvMojeTrudnoce";
            this.dgvMojeTrudnoce.ReadOnly = true;
            this.dgvMojeTrudnoce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMojeTrudnoce.Size = new System.Drawing.Size(409, 178);
            this.dgvMojeTrudnoce.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Nazad";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Ukloni";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MojeTrudnoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 305);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMojeTrudnoce);
            this.Name = "MojeTrudnoce";
            this.Text = "Moje Trudnoce";
            this.Load += new System.EventHandler(this.MojeTrudnoce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTrudnoce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeTrudnoce;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}