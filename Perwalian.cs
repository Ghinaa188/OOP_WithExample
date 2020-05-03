using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class Perwalian
    {
        private FormulirDaftar formulirDaftar;
        private Dosen dosen;

        public FormulirDaftar formulirdaftar { get { return this.formulirDaftar; } set { this.formulirDaftar = value; } }
        public Dosen doseN { get { return this.dosen; } set { this.dosen = value; } }

        public Perwalian(FormulirDaftar form, Dosen _dosen)
        {
            this.formulirDaftar = form;
            this.dosen = _dosen;
        }
        #region Fungsi
        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("INFORMASI PERWALIAN");
            Console.WriteLine("Mahasiswa atas Nama: " + formulirDaftar.Pendaftar.nama);//ini adalah cara mengakses nama dari clas formulator.pendaftaran

            Console.WriteLine("Dosen Wali: " + dosen.nama);

        }
        #endregion
    }
}
