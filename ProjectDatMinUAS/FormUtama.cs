using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void proximityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormProximity"];

            if (form == null)
            {
                FormProximity formProximity = new FormProximity();

                formProximity.MdiParent = this;

                formProximity.Show();
            }
            else
            {
                form.Show();

                form.BringToFront();
            }
        }

        private void bestSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBest"];

            if (form == null)
            {
                FormBest formBest = new FormBest();

                formBest.MdiParent = this;

                formBest.Show();
            }
            else
            {
                form.Show();

                form.BringToFront();
            }
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            IsMdiContainer = true;
        }

        public void BacaDataExcel(DataGridView dataGridView)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files (*.xlsx; *.xls)|*.xlsx; *.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);

                    DataSet result = reader.AsDataSet();

                    DataTable dataTable = result.Tables[0];

                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void SimpanDataExcel(DataGridView dataGridView)
        {
            
        }

        
    }
}
