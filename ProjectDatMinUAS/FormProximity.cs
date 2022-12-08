using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            DataTable data;

            formUtama.OpenFile(out data);

            dataGridViewProx.Visible = true;

            dataGridViewProx.DataSource = data;

            formUtama.SetNumberRow(dataGridViewProx);

            dataGridViewProx.AllowUserToAddRows = false;
        }

        public void ManhattanDistance()
        {
            int[,] matrix = new int[dataGridViewProx.Rows.Count, dataGridViewProx.Rows.Count];

            for (int i = 0; i < dataGridViewProx.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewProx.Rows.Count; j++)
                {
                    int distance = 0;

                    for (int k = 0; k < dataGridViewProx.Columns.Count; k++)
                    {
                        int value1 = int.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        int value2 = int.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        distance += Math.Abs(value1 - value2);
                    }

                    matrix[i, j] = distance;
                }
            }

            int rowNewCount = matrix.GetLength(0);

            int colNewCount = matrix.GetLength(1);

            dataGridViewHasil.ColumnCount = colNewCount;

            for (int i = 0; i < rowNewCount; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewHasil);

                for (int j = 0; j < colNewCount; j++)
                {
                    newRow.Cells[j].Value = matrix[i, j];
                }

                dataGridViewHasil.Rows.Add(newRow);
            }
        }

        public void EuclideanDistance()
        {
            double [,] matrix = new double[dataGridViewProx.Rows.Count, dataGridViewProx.Rows.Count];

            for (int i = 0; i < dataGridViewProx.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewProx.Rows.Count; j++)
                {
                    double distance = 0;

                    double total = 0;

                    for (int k = 0; k < dataGridViewProx.Columns.Count; k++)
                    {
                        double value1 = int.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        double value2 = int.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        total += Math.Abs(Math.Pow(value1 - value2, 2));

                        distance = Math.Round(Math.Sqrt(total), 3);
                    }

                    matrix[i, j] = distance;
                }
            }

            int rowNewCount = matrix.GetLength(0);

            int colNewCount = matrix.GetLength(1);

            dataGridViewHasil.ColumnCount = colNewCount;

            for (int i = 0; i < rowNewCount; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewHasil);

                for (int j = 0; j < colNewCount; j++)
                {
                    newRow.Cells[j].Value = matrix[i, j];
                }

                dataGridViewHasil.Rows.Add(newRow);
            }
        }

        public void SupremumDistance()
        {
            int[,] matrix = new int[dataGridViewProx.Rows.Count, dataGridViewProx.Rows.Count];

            for (int i = 0; i < dataGridViewProx.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewProx.Rows.Count; j++)
                {
                    int distance = -1;

                    for (int k = 0; k < dataGridViewProx.Columns.Count; k++)
                    {
                        int value1 = int.Parse(dataGridViewProx.Rows[i].Cells[k].Value.ToString());

                        int value2 = int.Parse(dataGridViewProx.Rows[j].Cells[k].Value.ToString());

                        int temp = Math.Abs(value1 - value2);

                        if (temp > distance)
                        {
                            distance = temp;
                        }
                    }

                    matrix[i, j] = distance;
                }
            }

            int rowNewCount = matrix.GetLength(0);

            int colNewCount = matrix.GetLength(1);

            dataGridViewHasil.ColumnCount = colNewCount;

            for (int i = 0; i < rowNewCount; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridViewHasil);

                for (int j = 0; j < colNewCount; j++)
                {
                    newRow.Cells[j].Value = matrix[i, j];
                }

                dataGridViewHasil.Rows.Add(newRow);
            }
        }

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistance.SelectedIndex > -1)
            {
                dataGridViewHasil.AllowUserToAddRows = false;

                if (comboBoxDistance.Text == "Manhattan Distance (r = 1)")
                {
                    dataGridViewHasil.Rows.Clear();

                    ManhattanDistance();
                }
                else if (comboBoxDistance.Text == "Eucledian Distance (r = 2)")
                {
                    dataGridViewHasil.Rows.Clear();

                    EuclideanDistance();
                }
                else if (comboBoxDistance.Text == "Supremum Distance (r = unlimited)")
                {
                    dataGridViewHasil.Rows.Clear();

                    SupremumDistance();
                }
            } 
        }
    }
}
