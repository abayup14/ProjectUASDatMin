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

            dataGridViewBest.AllowUserToAddRows = false;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            formUtama.BacaDataExcel(dataGridViewBest);

            dataGridViewBest.Visible = true;
        }

        public void GINICount()
        {
            // hitung jumlah baris dan kolom datagrid
            int rowCount = dataGridViewBest.RowCount;

            int colCount = dataGridViewBest.ColumnCount;

            //buat array2d untuk menyimpan attribut yg bukan jenis klasifikasinya
            string[,] featureList = new string[rowCount, colCount];

            //buat list untuk simpan klasifikasi dataset
            List<string> classification = new List<string>();

            //buat list untuk simpan jenis dari klasifikasi dataset
            List<string> classType = new List<string>();

            // loop untuk menyimpan datagrid feature ke array , kliasifikasi dan tipenya ke list
            for (int i = 0; i < rowCount; i++) // loop untuk setiap baris data
            {
                for (int j = 0; j < colCount; j++) // loop untuk setiap kolom feature
                {
                    // simpan nilai di baris i kolom j ke variable
                    string nilai = dataGridViewBest.Rows[i].Cells[j].Value.ToString(); 

                    if (j != colCount - 1) // cek apakah kolom bukan kolom yang terakhir
                    {
                        featureList[i, j] = nilai; // jika bukan, maka simpan nilai ke array baris i kolom j
                    }
                    else
                    {
                        classification.Add(nilai); // jika iya, maka simpan ke list classification

                        if (!(classType.Contains(nilai))) // cek apakah klasifikasi sudah ada di dalam list tipe klasifikasi
                        {
                            classType.Add(nilai); // jika belum, maka simpan nilai ke list tipe klasifikasi
                        }
                    }
                }
            }

            // buat list untuk simpan hasil perhitungan setiap klasifikasi
            List<int> countEveryClassType = new List<int>();

            // loop untuk inisialisasi nilai setiap tipe klasifikasi 
            for (int i = 0; i < classType.Count; i++)
            {
                countEveryClassType.Add(0); // inisialisi 0 untuk setiap tipe klasifikasi
            }

            // loop untuk membandingkan antara klasifikasi denga tipe klasifikasinya
            for (int i = 0; i < classification.Count; i++) // loop setiap klasifikasi
            {
                for (int j = 0; j < classType.Count; j++) // loop setiap tipe klasifikasi
                {
                    if (classification[i] == classType[j]) // cek apakah klasifikasi sesuai dengan tipe klasifikasinya
                    {
                        countEveryClassType[j]++; // jika iya, maka tambah 1 ke setiap tipe klasifikasi yang sesuai

                        break; // apabila sudah ada 1 yg sesuai, keluar dari loop j untuk langsung memulai loop i kembali
                    }
                }
            }

            // hitung gini parent, inisialisasi variable untuk menampung hasil gini parent
            double countGINIParent = 0;

            // loop untuk menghitung gini setiap tipe klasifikasi
            for (int i = 0; i < countEveryClassType.Count; i++)
            {
                // hitung dengan cara jumlah tiap tipe klasifikasi dibagi jumlah klasifikasi
                double GINIEveryClassType = countEveryClassType[i] / (double)classification.Count; // jangan lupa convert ke double

                // kuadratkan hasil gini setiap klasifikasi kemudian tambahkan ke hasil gini parent
                countGINIParent += Math.Pow(GINIEveryClassType, 2); 
            }

            countGINIParent = 1 - countGINIParent; // rumus hitung gini parent = 1 - total semua gini setiap tipe kelas

            listBoxBest.Items.Add("Hasil GINI parent : " + countGINIParent);


        }

        public double EntropyCount()
        {
            return 0;
        }

        private void comboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistance.SelectedIndex > -1)
            {
                if (comboBoxDistance.SelectedIndex == 0)
                {
                    GINICount();
                }
            }
        }
    }
}
