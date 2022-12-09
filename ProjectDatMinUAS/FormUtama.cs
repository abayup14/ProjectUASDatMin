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

        
        private DataTable ReadExcel(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            
            WorkSheet sheet = workbook.DefaultWorkSheet;
            
            return sheet.ToDataTable(true);
        }

        public void OpenFile(out DataTable data)
        {
            data = new DataTable();

            OpenFileDialog fileDialog = new OpenFileDialog(); //open dialog to choose file

            if (fileDialog.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExtension = Path.GetExtension(fileDialog.FileName); //get the file extension

                if (fileExtension.CompareTo(".xls") == 0 || fileExtension.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        data = ReadExcel(fileDialog.FileName); //read excel file
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }
    }
}
