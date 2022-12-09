using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public class ProximityMatrix
    {
        public int[,] ManhattanDistance(DataGridView dataGridView)
        {
            int[,] proxMatrix = new int[dataGridView.RowCount, dataGridView.RowCount];

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
               for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    int distance = 0;

                    for (int k = 0; k < dataGridView.ColumnCount; k++)
                    {
                        int nilai1 = int.Parse(dataGridView.Rows[i].Cells[k].Value.ToString());

                        int nilai2 = int.Parse(dataGridView.Rows[j].Cells[k].Value.ToString());

                        int sum = Math.Abs(nilai1 - nilai2);

                        distance += sum;
                    }

                    proxMatrix[i, j] = distance;
                }
            }

            return proxMatrix;
        }

        public double[,] EucledianDistance(DataGridView dataGridView)
        {
            double[,] proxMatrix = new double[dataGridView.RowCount, dataGridView.RowCount];

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    double total = 0;

                    double distance;

                    for (int k = 0; k < dataGridView.ColumnCount; k++)
                    {
                        double nilai1 = double.Parse(dataGridView.Rows[i].Cells[k].Value.ToString());

                        double nilai2 = double.Parse(dataGridView.Rows[j].Cells[k].Value.ToString());

                        double sum = Math.Pow(Math.Abs(nilai1 - nilai2), 2);

                        total += sum;
                    }

                    distance = Math.Round(Math.Sqrt(total), 4);

                    proxMatrix[i, j] = distance;
                }
            }

            return proxMatrix;
        }

        public int[,] SupremumDistance(DataGridView dataGridView)
        {
            int[,] proxMatrix = new int[dataGridView.RowCount, dataGridView.RowCount];

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    int distance = -1;

                    for (int k = 0; k < dataGridView.ColumnCount; k++)
                    {
                        int nilai1 = int.Parse(dataGridView.Rows[i].Cells[k].Value.ToString());
                         
                        int nilai2 = int.Parse(dataGridView.Rows[j].Cells[k].Value.ToString());

                        int sum = Math.Abs(nilai1 - nilai2);

                        if (sum > distance)
                        {
                            distance = sum;
                        }
                    }

                    proxMatrix[i, j] = distance;
                }
            }

            return proxMatrix;
        }
    }
}
