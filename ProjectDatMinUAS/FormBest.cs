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

        public FormBest()
        {
            InitializeComponent();
        }

        private void FormBest_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            DataTable data;

            formUtama.OpenFile(out data);

            dataGridViewBest.Visible = true;

            dataGridViewBest.DataSource = data;

            formUtama.SetNumberRow(dataGridViewBest);
        }

        public double GINICount()
        {

        }

        public double EntropyCount()
        {

        }
    }
}
