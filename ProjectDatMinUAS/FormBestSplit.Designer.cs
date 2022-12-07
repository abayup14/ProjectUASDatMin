namespace ProjectDatMinUAS
{
    partial class FormBestSplit
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
            this.buttonBukaFile = new System.Windows.Forms.Button();
            this.dataGridViewBest = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBukaFile
            // 
            this.buttonBukaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBukaFile.Location = new System.Drawing.Point(12, 487);
            this.buttonBukaFile.Name = "buttonBukaFile";
            this.buttonBukaFile.Size = new System.Drawing.Size(160, 56);
            this.buttonBukaFile.TabIndex = 5;
            this.buttonBukaFile.Text = "&BUKA FILE";
            this.buttonBukaFile.UseVisualStyleBackColor = true;
            this.buttonBukaFile.Click += new System.EventHandler(this.buttonBukaFile_Click);
            // 
            // dataGridViewBest
            // 
            this.dataGridViewBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBest.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBest.Name = "dataGridViewBest";
            this.dataGridViewBest.RowHeadersWidth = 51;
            this.dataGridViewBest.RowTemplate.Height = 24;
            this.dataGridViewBest.Size = new System.Drawing.Size(776, 459);
            this.dataGridViewBest.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormBestSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 549);
            this.Controls.Add(this.buttonBukaFile);
            this.Controls.Add(this.dataGridViewBest);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormBestSplit";
            this.Text = "FormBestSplit";
            this.Load += new System.EventHandler(this.FormBestSplit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBukaFile;
        private System.Windows.Forms.DataGridView dataGridViewBest;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}