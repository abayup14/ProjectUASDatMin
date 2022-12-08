namespace ProjectDatMinUAS
{
    partial class FormBest
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
            this.buttonBuka = new System.Windows.Forms.Button();
            this.dataGridViewBest = new System.Windows.Forms.DataGridView();
            this.listBoxBest = new System.Windows.Forms.ListBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(12, 545);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(184, 63);
            this.buttonBuka.TabIndex = 3;
            this.buttonBuka.Text = "&BUKA FILE";
            this.buttonBuka.UseVisualStyleBackColor = true;
            this.buttonBuka.Click += new System.EventHandler(this.buttonBuka_Click);
            // 
            // dataGridViewBest
            // 
            this.dataGridViewBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBest.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBest.Name = "dataGridViewBest";
            this.dataGridViewBest.RowHeadersWidth = 51;
            this.dataGridViewBest.RowTemplate.Height = 24;
            this.dataGridViewBest.Size = new System.Drawing.Size(573, 507);
            this.dataGridViewBest.TabIndex = 2;
            // 
            // listBoxBest
            // 
            this.listBoxBest.FormattingEnabled = true;
            this.listBoxBest.ItemHeight = 16;
            this.listBoxBest.Location = new System.Drawing.Point(603, 12);
            this.listBoxBest.Name = "listBoxBest";
            this.listBoxBest.Size = new System.Drawing.Size(486, 596);
            this.listBoxBest.TabIndex = 4;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(401, 545);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(184, 63);
            this.buttonSimpan.TabIndex = 7;
            this.buttonSimpan.Text = "&SIMPAN FILE";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // FormBest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.listBoxBest);
            this.Controls.Add(this.buttonBuka);
            this.Controls.Add(this.dataGridViewBest);
            this.Name = "FormBest";
            this.Text = "Best";
            this.Load += new System.EventHandler(this.FormBest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.DataGridView dataGridViewBest;
        private System.Windows.Forms.ListBox listBoxBest;
        private System.Windows.Forms.Button buttonSimpan;
    }
}