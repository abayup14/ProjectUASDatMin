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
    public partial class FormBestSplit : Form
    {
        FormUtama formUtama;

        public FormBestSplit()
        {
            InitializeComponent();
        }

        private void FormBestSplit_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void buttonBukaFile_Click(object sender, EventArgs e)
        {
            DataTable dataBest;

            formUtama.OpenDialog(out dataBest);

            dataGridViewBest.Visible = true;

            dataGridViewBest.DataSource = dataBest;
        }
    }
}
