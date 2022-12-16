using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public partial class FormBest : Form
    {
        FormUtama formUtama;

        BestSplit bestSplit;

        public FormBest()
        {
            InitializeComponent();
        }

        private void FormBest_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            bestSplit = new BestSplit();

            dataGridViewBest.AllowUserToAddRows = false;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            formUtama.BacaDataExcel(dataGridViewBest);

            dataGridViewBest.Visible = true;
        }        

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistance.SelectedIndex > -1)
            {
                listBoxBest.Items.Clear();

                if (dataGridViewBest.DataSource != null)
                {
                    if (comboBoxDistance.SelectedIndex == 0)
                    {
                        bestSplit.GINICount(dataGridViewBest, listBoxBest);
                    }
                    else if (comboBoxDistance.SelectedIndex == 1)
                    {
                        bestSplit.EntropyCount(dataGridViewBest, listBoxBest);
                    }
                }
                else
                {
                    comboBoxDistance.SelectedIndex = -1;

                    MessageBox.Show("Data belum dimasukkan");
                }
            }
        }
    }
}
