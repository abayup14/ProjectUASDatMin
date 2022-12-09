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

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            DataTable data;

            formUtama.OpenFile(out data);

            dataGridViewProx.Visible = true;

            dataGridViewProx.DataSource = data;

            formUtama.SetNumberRow(dataGridViewProx);
        }

        private void FormProximity_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            dataGridViewProx.AllowUserToAddRows = false;

            dataGridViewHasil.AllowUserToAddRows = false;
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

                        int value = Math.Abs(nilai1 - nilai2);

                        distance += value;
                    }

                    proxMatrix[i, j] = distance;


                }
            }


        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            ManhattanDistance();
        }
    }
}
