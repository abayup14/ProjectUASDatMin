using IronXL;
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

        private void FormUtama_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            IsMdiContainer = true;
        }

        private void proximityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormProximityMatrix"];

            if (form == null)
            {
                FormProximityMatrix formProximityMatrix = new FormProximityMatrix();

                formProximityMatrix.MdiParent = this;

                formProximityMatrix.Show();
            }
            else
            {
                form.Show();

                form.BringToFront();
            }
        }

        private void bestSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBestSplit"];

            if (form == null)
            {
                FormBestSplit formBestSplit = new FormBestSplit();

                formBestSplit.MdiParent = this;

                formBestSplit.Show();
            }
            else
            {
                form.Show();

                form.BringToFront();
            }
        }

        public DataTable ReadExcel(string fileName)
        {
            WorkBook workBook = WorkBook.Load(fileName);

            WorkSheet sheet = workBook.DefaultWorkSheet;

            return sheet.ToDataTable(true);
        }

        public void OpenDialog(out DataTable dataExcel)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel File(*.xlsx)|*.xlsx|Excel File(*.xls)|*.xls";
            dataExcel = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = Path.GetExtension(openFileDialog.FileName);

                if (fileExtension.CompareTo(".xls") == 0 || fileExtension.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        dataExcel = ReadExcel(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terdapat kesalahan. Pesan kesalahan : " + ex.Message, "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Hanya dapat membuka file Excel (.xlsx atau .xls)", "Kesalahan");
                }
            }
        }
    }
}
