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
using Excel = Microsoft.Office.Interop.Excel;

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
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel Files (*.xlsx; *.xls)|*.xlsx; *.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    Excel._Application excelApp = new Excel.Application();

                    Excel._Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

                    Excel._Worksheet excelWorksheet = null;

                    excelApp.Visible = true;

                    excelWorksheet = excelWorkbook.Sheets["Sheet1"];

                    excelWorksheet = excelWorkbook.ActiveSheet;

                    try
                    {
                        for (int i = 0; i < dataGridView.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView.ColumnCount; j++)
                            {
                                if (dataGridView.Rows[i].Cells[j].Value != null)
                                {
                                    excelWorksheet.Cells[i + 1, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    excelWorksheet.Cells[i + 1, j + 1] = "";
                                }
                            }
                        }

                        excelWorksheet.SaveAs(fileName);

                        excelWorkbook.Close(true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                        ReleaseObject(excelWorksheet);

                        ReleaseObject(excelWorkbook);

                        ReleaseObject(excelApp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);

                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;

                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
