﻿namespace ProjectDatMinUAS
{
    partial class FormUtama
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
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximityMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximityMatrixToolStripMenuItem,
            this.bestSplitToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // proximityMatrixToolStripMenuItem
            // 
            this.proximityMatrixToolStripMenuItem.Name = "proximityMatrixToolStripMenuItem";
            this.proximityMatrixToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.proximityMatrixToolStripMenuItem.Text = "Proximity Matrix";
            this.proximityMatrixToolStripMenuItem.Click += new System.EventHandler(this.proximityMatrixToolStripMenuItem_Click);
            // 
            // bestSplitToolStripMenuItem
            // 
            this.bestSplitToolStripMenuItem.Name = "bestSplitToolStripMenuItem";
            this.bestSplitToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.bestSplitToolStripMenuItem.Text = "Best Split";
            this.bestSplitToolStripMenuItem.Click += new System.EventHandler(this.bestSplitToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormUtama";
            this.Text = "Project Data Mining";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximityMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSplitToolStripMenuItem;
    }
}

