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

        public FormProximity()
        {
            InitializeComponent();
        }

        private void FormProximity_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            dataGridViewProx.AllowUserToAddRows = false;

            dataGridViewHasil.AllowUserToAddRows = false;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            DataTable data;

            formUtama.OpenFile(out data);

            dataGridViewProx.Visible = true;

            dataGridViewProx.DataSource = data;
        }

        private void ManhattanDistance()
        {
            int[,] proxMatrix = new int[dataGridViewProx.RowCount, dataGridViewProx.RowCount];

            for (int i = 0; i < dataGridViewProx.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewProx.RowCount; j++)
                {
                    int distance = 0;

                    for (int k = 0; k < dataGridViewProx.ColumnCount; k++)
                    {
                        int nilai1 = int.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        int nilai2 = int.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        int sum = Math.Abs(nilai1 - nilai2);

                        distance += sum;
                    }

                    proxMatrix[i, j] = distance;
                }
            }

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

        private void EucledianDistance()
        {
            double[,] proxMatrix = new double[dataGridViewProx.RowCount, dataGridViewProx.RowCount];

            for (int i = 0; i < dataGridViewProx.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewProx.RowCount; j++)
                {
                    double total = 0;

                    double distance;

                    for (int k = 0; k < dataGridViewProx.ColumnCount; k++)
                    {
                        double nilai1 = double.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        double nilai2 = double.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        double sum = Math.Pow(Math.Abs(nilai1 - nilai2), 2);

                        total += sum;
                    }

                    distance = Math.Round(Math.Sqrt(total), 4);

                    proxMatrix[i, j] = distance;
                }
            }

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

        private void SupremumDistance()
        {
            int[,] proxMatrix = new int[dataGridViewProx.RowCount, dataGridViewProx.RowCount];

            for (int i = 0; i < dataGridViewProx.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewProx.RowCount; j++)
                {
                    int distance = -1;

                    for (int k = 0; k < dataGridViewProx.ColumnCount; k++)
                    {
                        int nilai1 = int.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        int nilai2 = int.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        int sum = Math.Abs(nilai1 - nilai2);

                        if (sum > distance)
                        {
                            distance = sum;
                        }
                    }

                    proxMatrix[i, j] = distance;
                }
            }

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

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistance.SelectedIndex > -1)
            {
                dataGridViewHasil.Rows.Clear();

                if (comboBoxDistance.SelectedIndex == 0)
                {
                    ManhattanDistance();
                }
                else if (comboBoxDistance.SelectedIndex == 1)
                {
                    EucledianDistance();
                }
                else if (comboBoxDistance.SelectedIndex == 2)
                {
                    SupremumDistance();
                }
            }
        }
    }
}
