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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDistance = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProx
            // 
            this.dataGridViewProx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProx.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewProx.Name = "dataGridViewProx";
            this.dataGridViewProx.RowHeadersWidth = 51;
            this.dataGridViewProx.RowTemplate.Height = 24;
            this.dataGridViewProx.Size = new System.Drawing.Size(573, 507);
            this.dataGridViewProx.TabIndex = 0;
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(12, 577);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(184, 63);
            this.buttonBuka.TabIndex = 1;
            this.buttonBuka.Text = "&BUKA FILE";
            this.buttonBuka.UseVisualStyleBackColor = true;
            this.buttonBuka.Click += new System.EventHandler(this.buttonBuka_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(982, 577);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(184, 63);
            this.buttonSimpan.TabIndex = 6;
            this.buttonSimpan.Text = "&SIMPAN FILE";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(591, 55);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(573, 507);
            this.dataGridViewHasil.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasil :";
            // 
            // comboBoxDistance
            // 
            this.comboBoxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDistance.FormattingEnabled = true;
            this.comboBoxDistance.Items.AddRange(new object[] {
            "Manhattan Distance (r = 1)",
            "Eucledian Distance (r = 2)",
            "Supremum Distance (r = unlimited)"});
            this.comboBoxDistance.Location = new System.Drawing.Point(678, 13);
            this.comboBoxDistance.Name = "comboBoxDistance";
            this.comboBoxDistance.Size = new System.Drawing.Size(390, 30);
            this.comboBoxDistance.TabIndex = 10;
            this.comboBoxDistance.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistance_SelectedIndexChanged);
            // 
            // FormProximity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 643);
            this.Controls.Add(this.comboBoxDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonBuka);
            this.Controls.Add(this.dataGridViewProx);
            this.Name = "FormProximity";
            this.Text = "Proximity Matrix";
            this.Load += new System.EventHandler(this.FormProximity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProx;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDistance;
    }
}