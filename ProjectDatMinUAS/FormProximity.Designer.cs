namespace ProjectDatMinUAS
{
    partial class FormProximity
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
            this.dataGridViewProx = new System.Windows.Forms.DataGridView();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.listBoxProx = new System.Windows.Forms.ListBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHitung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProx
            // 
            this.dataGridViewProx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProx.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProx.Name = "dataGridViewProx";
            this.dataGridViewProx.RowHeadersWidth = 51;
            this.dataGridViewProx.RowTemplate.Height = 24;
            this.dataGridViewProx.Size = new System.Drawing.Size(573, 507);
            this.dataGridViewProx.TabIndex = 0;
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(12, 545);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(184, 63);
            this.buttonBuka.TabIndex = 1;
            this.buttonBuka.Text = "&BUKA FILE";
            this.buttonBuka.UseVisualStyleBackColor = true;
            this.buttonBuka.Click += new System.EventHandler(this.buttonBuka_Click);
            // 
            // listBoxProx
            // 
            this.listBoxProx.FormattingEnabled = true;
            this.listBoxProx.ItemHeight = 16;
            this.listBoxProx.Location = new System.Drawing.Point(603, 12);
            this.listBoxProx.Name = "listBoxProx";
            this.listBoxProx.Size = new System.Drawing.Size(486, 596);
            this.listBoxProx.TabIndex = 5;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(202, 545);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(184, 63);
            this.buttonSimpan.TabIndex = 6;
            this.buttonSimpan.Text = "&SIMPAN FILE";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonHitung
            // 
            this.buttonHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHitung.Location = new System.Drawing.Point(401, 545);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(184, 63);
            this.buttonHitung.TabIndex = 7;
            this.buttonHitung.Text = "&HITUNG";
            this.buttonHitung.UseVisualStyleBackColor = true;
            // 
            // FormProximity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.listBoxProx);
            this.Controls.Add(this.buttonBuka);
            this.Controls.Add(this.dataGridViewProx);
            this.Name = "FormProximity";
            this.Text = "Proximity";
            this.Load += new System.EventHandler(this.FormProximity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProx;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.ListBox listBoxProx;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHitung;
    }
}