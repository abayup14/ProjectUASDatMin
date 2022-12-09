using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public partial class FormProximity : Form
    {
        FormUtama formUtama;

        ProximityMatrix proximityMatrix;

        public FormProximity()
        {
            InitializeComponent();
        }

        private void FormProximity_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            proximityMatrix = new ProximityMatrix();

            dataGridViewProx.AllowUserToAddRows = false;

            dataGridViewHasil.AllowUserToAddRows = false;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            formUtama.BacaDataExcel(dataGridViewProx);

            dataGridViewProx.Visible = true;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //formUtama.SimpanKeExcel(dataGridViewHasil, "Coba.csv");
        }

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistance.SelectedIndex > -1)
            {
                dataGridViewHasil.Rows.Clear();

                if (comboBoxDistance.SelectedIndex == 0 || comboBoxDistance.SelectedIndex == 2)
                {
                    int[,] proxMatrix = proximityMatrix.ManhattanDistance(dataGridViewProx);

                    FormatDataGridHasil(proxMatrix);
                }
                else if (comboBoxDistance.SelectedIndex == 1)
                {
                    double[,] proxMatrix = proximityMatrix.EucledianDistance(dataGridViewProx);

                    FormatDataGridHasil(proxMatrix);
                }
            }
        }

        private void FormatDataGridHasil(int[,] proxMatrix)
        {
            int newRowCount = proxMatrix.GetLength(0);

            int newColCount = proxMatrix.GetLength(1);

            dataGridViewHasil.ColumnCount = newColCount;

            for (int row = 0; row < newRowCount; row++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewHasil);

                for (int col = 0; col < newColCount; col++)
                {
                    newRow.Cells[col].Value = proxMatrix[row, col];
                }

                dataGridViewHasil.Rows.Add(newRow);
            }
        }

        private void FormatDataGridHasil(double[,] proxMatrix)
        {
            int newRowCount = proxMatrix.GetLength(0);

            int newColCount = proxMatrix.GetLength(1);

            dataGridViewHasil.ColumnCount = newColCount;

            for (int row = 0; row < newRowCount; row++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewHasil);

                for (int col = 0; col < newColCount; col++)
                {
                    newRow.Cells[col].Value = proxMatrix[row, col];
                }

                dataGridViewHasil.Rows.Add(newRow);
            }
        }
    }
}
