using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public partial class FormProximity : Form
    {
        FormUtama formUtama;

        public FormProximity()
        {
            InitializeComponent();
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            DataTable data;

            formUtama.OpenFile(out data);

            dataGridViewProx.Visible = true;

            dataGridViewProx.DataSource = data;

            formUtama.SetNumberRow(dataGridViewProx);
        }

        private void FormProximity_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }
    }
}
