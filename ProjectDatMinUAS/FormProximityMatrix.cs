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
    public partial class FormProximityMatrix : Form
    {
        FormUtama formUtama;

        public FormProximityMatrix()
        {
            InitializeComponent();
        }

        private void bukaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void simpanFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormProximityMatrix_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void buttonBukaFile_Click(object sender, EventArgs e)
        {
            DataTable dataProx;
            formUtama.OpenDialog(out dataProx);

            dataGridViewProx.Visible = true;
            dataGridViewProx.DataSource = dataProx;
        }

        
    }
}
