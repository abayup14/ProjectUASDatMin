using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatMinUAS
{
    public class BestSplit
    {
        public void GINICount(DataGridView dataGridView, ListBox listBox)
        {
            // hitung jumlah baris dan kolom datagrid
            int rowCount = dataGridView.RowCount;
            int colCount = dataGridView.ColumnCount;

            // inisialisasi list dalam list untuk menyimpan feature setiap kolom
            List<List<object>> featureList = new List<List<object>>();

            //buat list untuk simpan klasifikasi dataset
            List<object> classification = new List<object>();

            //buat list untuk simpan jenis dari klasifikasi dataset
            List<object> classType = new List<object>();

            // loop untuk menyimpan datagrid feature ke array , kliasifikasi dan tipenya ke list
            for (int i = 0; i < rowCount; i++) // loop untuk setiap baris data
            {
                List<object> featureEveryRow = new List<object>();

                for (int j = 0; j < colCount; j++) // loop untuk setiap kolom feature
                {
                    // simpan nilai di baris i kolom j ke variable
                    object nilai = dataGridView.Rows[i].Cells[j].Value;

                    if (j != colCount - 1) // cek apakah kolom bukan kolom yang terakhir
                    {
                        //featureList[i, j] = nilai; // jika bukan, maka simpan nilai ke array baris i kolom j
                        featureEveryRow.Add(nilai);
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

                featureList.Add(featureEveryRow); // tambahkan hasil 1 baris feature tersebut ke list feature
            }

            // buat list untuk simpan hasil perhitungan setiap klasifikasi
            List<int> countEveryClassType = new List<int>();

            // loop untuk inisialisasi nilai setiap tipe klasifikasi 
            for (int i = 0; i < classType.Count; i++)
            {
                countEveryClassType.Add(0); // inisialisi 0 untuk setiap tipe klasifikasi
            }

            // loop untuk membandingkan antara klasifikasi dengan tipe klasifikasinya
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
            double GINIParent = 0;

            // loop untuk menghitung gini setiap tipe klasifikasi
            for (int i = 0; i < countEveryClassType.Count; i++)
            {
                // hitung dengan cara jumlah tiap tipe klasifikasi dibagi jumlah klasifikasi
                double GINIEveryClassType = countEveryClassType[i] / (double)classification.Count; // jangan lupa convert ke double

                // kuadratkan hasil gini setiap klasifikasi kemudian tambahkan ke hasil gini parent
                GINIParent += Math.Pow(GINIEveryClassType, 2);
            }

            GINIParent = 1 - Math.Round(GINIParent, 4); // rumus hitung gini parent = 1 - total semua gini setiap tipe kelas

            listBox.Items.Add("=====USING GINI=====");
            listBox.Items.Add("Hasil GINI parent : " + GINIParent);
            listBox.Items.Add("");



            List<double> gainFeatEveryFeature = new List<double>(); // list untuk menyimpan gain setiap feature

            List<string> listFeatureName = new List<string>(); // list untuk menyimpan nama feature

            List<object> featureType = new List<object>(); // buat list untuk tampung tipe-tipe untuk setiap feature

            for (int i = 0; i < featureList[0].Count; i++) // loop untuk setiap feature yang ada di list
            {
                for (int j = 0; j < featureList.Count; j++) // loop untuk setiap baris di list
                {
                    //string feature = featureList[j, i]; // tampung isi dari list di baris j kolom i
                    object feature = featureList[j][i];

                    if (!featureType.Contains(feature)) // cek apakah list tipe feature sudah berisi feature yang ada di kolom tersebut 
                    {
                        featureType.Add(feature); // jika tidak ada, masukkan feature tersebut ke list tersebut
                    }
                }

                // inisialisasi list dalam list untuk simpan jumlah data tipe feature setiap tipe klasifikasi
                List<List<int>> countFeatureEveryClassType = new List<List<int>>();

                for (int j = 0; j < classType.Count; j++) // loop setiap tipe class di dataset
                {
                    List<int> typeFeature = new List<int>(); // inisialisasi list untuk tampung jumlah data tiap feature

                    for (int k = 0; k < featureType.Count; k++) // loop setiap tipe feature untuk setiap tipe klasifikasi
                    {
                        typeFeature.Add(0); // inisialisasi setiap baris dan kolom di array = 0
                    }

                    countFeatureEveryClassType.Add(typeFeature); // tambahkan hasil setiap row ke list utama
                }

                for (int j = 0; j < colCount - 1; j++) // loop setiap feature yang ada di setiap baris j kolom k
                {
                    for (int k = 0; k < rowCount; k++)
                    {
                        for (int l = 0; l < featureType.Count; l++) // loop setiap tipe feature yang ada di setiap kolom
                        {
                            // cek apakah feature yang ada di baris j kolom k sama dengan tipe feature di index l
                            if (featureList[k][j] == featureType[l])
                            {
                                for (int m = 0; m < classType.Count; m++) // loop untuk setiap tipe klasifikasi di dataset
                                {
                                    // cek apakah klasifikasi di index k sama dengan tipe klasifikasi di index m
                                    if (classification[k] == classType[m])
                                    {
                                        // apabila sama, tambahkan 1 ke dalam tipe feature untuk setiap klasifikasi yg sesuai
                                        countFeatureEveryClassType[m][l]++;

                                        break; // apabila sudah ada 1 yg sesuai loop kembali ke loop diluar ini
                                    }
                                }

                                // apabila feature di dataset sama dengan yang ada di tipe feature, maka loop berhenti dan keluar
                                break;
                            }
                        }
                    }
                }

                List<int> sumFeatureEveryClassType = new List<int>(); //inisialisasi untuk hitung jumlah tipe feature di setiap kolom

                for (int j = 0; j < countFeatureEveryClassType[0].Count; j++) // loop untuk setiap kolom di setiap tipe feature
                {
                    int sum = 0; // inisialisasi jumlah = 0

                    for (int k = 0; k < countFeatureEveryClassType.Count; k++) // loop untuk setiap baris di setiap tipe feature
                    {
                        sum += countFeatureEveryClassType[k][j]; // jumlahkan nilai array baris j kolom i ke dalam sum
                    }

                    sumFeatureEveryClassType.Add(sum); // setelah selesai, maka tambahkan hasil tersebut ke dalam list
                }

                List<double> giniEveryFeature = new List<double>(); // inisialisasi list untuk menyimpan gini setiap feature

                // loop untuk setiap kolom fitur di setiap klasifikasi
                for (int j = 0; j < countFeatureEveryClassType[0].Count; j++)
                {
                    double giniFeature = 0; // inisialisasi nilai gini feature = 0

                    // loop untuk setiap baris fitur di setiap klasifikasi
                    for (int k = 0; k < countFeatureEveryClassType.Count; k++)
                    {
                        // hitung nilai gini setiap feature dengan cara total setiap fitur di setiap klaifikasi dibagi total fitur di kolom kemudian dikuadratkan
                        giniFeature += Math.Pow((double)countFeatureEveryClassType[k][j] / sumFeatureEveryClassType[j], 2);
                    }

                    // hitung gini dengan cara 1 - nilai gini setiap feature
                    giniFeature = Math.Round((1 - giniFeature), 4);

                    giniEveryFeature.Add(giniFeature); // masukkan nilai gini feature ke dalam list
                }

                int sumEveryTypeFeature = 0; // inisialisasi hitung jumlah semua fitur setiap kolom

                //loop untuk menghitung jumlah semua fitur setiap kolom dari jumlah tipe fitur di setiap kolom
                for (int j = 0; j < sumFeatureEveryClassType.Count; j++)
                {
                    // jumlah tipe fitur di setiap kolom ditambahkan dengan jumlah semua fitur setiap kolom
                    sumEveryTypeFeature += sumFeatureEveryClassType[j];
                }

                double weightedGINI = 0; // inisialisasi untuk menghitung weighted gini setiap kolom

                // loop untuk menghitung weighted gini setiap tipe fitur di setiap kolom
                for (int j = 0; j < sumFeatureEveryClassType.Count; j++)
                {
                    // hitung weighted gini dengan cara total tipe feature dibagi dengan total fitur di setiap kolom dikali dengan gini setiap tipe fitur
                    double weightedGainEveryTypeFeature = (double)sumFeatureEveryClassType[j] / sumEveryTypeFeature * giniEveryFeature[j];

                    // hasil perhitungan di atas ditambahkan ke weighted gini
                    weightedGINI += weightedGainEveryTypeFeature;
                }

                //hitung gain feature setiap kolom dengan cara gini parent dikurangi weighted gini
                double gainFeature = Math.Round(GINIParent - weightedGINI, 4);

                gainFeatEveryFeature.Add(gainFeature); // tambahkan hasil gain feature setiap kolom ke list

                listFeatureName.Add(dataGridView.Columns[i].HeaderText); // tambahkan nama feature ke dalam list

                listBox.Items.Add("Hasil Gain Feature " + dataGridView.Columns[i].HeaderText + " adalah " + gainFeature);

                featureType.Clear(); // kosongkan list untuk menampung tipe feature di kolom berikutnya
            }

            string bestSplit = ""; // simpan feature best split

            double valueBestSplit = -1; // simpan gain feature best split, inisialisasi = -1

            for (int i = 0; i < gainFeatEveryFeature.Count; i++) // loop hasil gain feature setiap kolom
            {
                if (gainFeatEveryFeature[i] > valueBestSplit) // cek apakah gain feature lebih besar dari gain featue sebelumnya
                {
                    // jika iya, best split diisi dengan nama feature dan valuenya
                    valueBestSplit = gainFeatEveryFeature[i];

                    bestSplit = listFeatureName[i];
                }
            }

            listBox.Items.Add("");
            listBox.Items.Add("Best Split untuk dataset tersebut adalah " + bestSplit);
            listBox.Items.Add("Nilai gain feature tersebut adalah " + valueBestSplit);
            listBox.Items.Add("====================");
        }
    }
}
