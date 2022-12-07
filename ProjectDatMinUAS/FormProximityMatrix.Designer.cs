namespace ProjectDatMinUAS
{
    partial class FormProximityMatrix
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridViewProx = new System.Windows.Forms.DataGridView();
            this.buttonBukaFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridViewProx
            // 
            this.dataGridViewProx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProx.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProx.Name = "dataGridViewProx";
            this.dataGridViewProx.RowHeadersWidth = 51;
            this.dataGridViewProx.RowTemplate.Height = 24;
            this.dataGridViewProx.Size = new System.Drawing.Size(776, 459);
            this.dataGridViewProx.TabIndex = 1;
            // 
            // buttonBukaFile
            // 
            this.buttonBukaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBukaFile.Location = new System.Drawing.Point(12, 481);
            this.buttonBukaFile.Name = "buttonBukaFile";
            this.buttonBukaFile.Size = new System.Drawing.Size(160, 56);
            this.buttonBukaFile.TabIndex = 2;
            this.buttonBukaFile.Text = "&BUKA FILE";
            this.buttonBukaFile.UseVisualStyleBackColor = true;
            this.buttonBukaFile.Click += new System.EventHandler(this.buttonBukaFile_Click);
            // 
            // FormProximityMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 549);
            this.Controls.Add(this.buttonBukaFile);
            this.Controls.Add(this.dataGridViewProx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProximityMatrix";
            this.Text = "FormProximityMatrix";
            this.Load += new System.EventHandler(this.FormProximityMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewProx;
        private System.Windows.Forms.Button buttonBukaFile;
    }
}