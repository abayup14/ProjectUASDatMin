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
            this.comboBoxDistance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(12, 577);
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
            this.dataGridViewBest.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewBest.Name = "dataGridViewBest";
            this.dataGridViewBest.RowHeadersWidth = 51;
            this.dataGridViewBest.RowTemplate.Height = 24;
            this.dataGridViewBest.Size = new System.Drawing.Size(610, 516);
            this.dataGridViewBest.TabIndex = 2;
            // 
            // listBoxBest
            // 
            this.listBoxBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBest.FormattingEnabled = true;
            this.listBoxBest.ItemHeight = 18;
            this.listBoxBest.Location = new System.Drawing.Point(628, 55);
            this.listBoxBest.Name = "listBoxBest";
            this.listBoxBest.Size = new System.Drawing.Size(671, 508);
            this.listBoxBest.TabIndex = 4;
            // 
            // comboBoxDistance
            // 
            this.comboBoxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDistance.FormattingEnabled = true;
            this.comboBoxDistance.Items.AddRange(new object[] {
            "Best Split dengan GINI",
            "Best Split dengan Entropy"});
            this.comboBoxDistance.Location = new System.Drawing.Point(677, 9);
            this.comboBoxDistance.Name = "comboBoxDistance";
            this.comboBoxDistance.Size = new System.Drawing.Size(390, 30);
            this.comboBoxDistance.TabIndex = 13;
            this.comboBoxDistance.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistance_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasil :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data";
            // 
            // FormBest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 643);
            this.Controls.Add(this.comboBoxDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBest);
            this.Controls.Add(this.buttonBuka);
            this.Controls.Add(this.dataGridViewBest);
            this.Name = "FormBest";
            this.Text = "Best Split";
            this.Load += new System.EventHandler(this.FormBest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.DataGridView dataGridViewBest;
        private System.Windows.Forms.ListBox listBoxBest;
        private System.Windows.Forms.ComboBox comboBoxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}