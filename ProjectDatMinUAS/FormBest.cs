using System;
using System.IO;
using ExcelDataReader;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

            dataGridViewBest.AllowUserToAddRows = false;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            formUtama.BacaDataExcel(dataGridViewBest);

            dataGridViewBest.Visible = true;
        }

        public double GINICount()
        {
            return 0;
        }

        public double EntropyCount()
        {
            return 0;
        }

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
