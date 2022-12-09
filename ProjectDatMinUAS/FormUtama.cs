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
using IronXL;

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

        
        private DataTable BacaDataExcel(string namaFile)
        {
            WorkBook workBook = WorkBook.Load(namaFile);
            
            WorkSheet workSheet = workBook.DefaultWorkSheet;
            
            return workSheet.ToDataTable(true);
        }

        public void BukaDataExcel(out DataTable dataExcel)
        {
            dataExcel = new DataTable();

            OpenFileDialog fileDialog = new OpenFileDialog(); //open dialog to choose file

            fileDialog.Filter = "Excel File (*.xlsx; *.xls)|*.xlsx; *.xls";

            if (fileDialog.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExtension = Path.GetExtension(fileDialog.FileName); //get the file extension

                if (fileExtension.CompareTo(".xls") == 0 || fileExtension.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        dataExcel = BacaDataExcel(fileDialog.FileName); //read excel file
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan. Pesan kesalahan : " + ex.Message, "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Hanya dapat memilih .xlsx atau .xls saja", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }
    }
}
