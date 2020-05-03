using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class FormulirDaftar
    {
        #region Atribut
        private Mahasiswa _mhsPendaftar;
        private string noPendaftar;
        private string asalSekolah;
        private List<ProgramStudi> pilihanProdi;
        #endregion

        #region Properties
        public Mahasiswa Pendaftar
        { get { return this._mhsPendaftar; }set{this._mhsPendaftar =value; }}
        public string NoPendaftaran
        { get { return this.noPendaftar}set{this.noPendaftar = value;} }
        public string AsalSekolah
        { get { return this.asalSekolah}set{this.asalSekolah = value;} }
        public List<ProgramStudi> _ProgramStudi
        { get { return this.pilihanProdi}set{this.pilihanProdi = value;} }
        #endregion

        #region Constructor
        public FormulirDaftar(Mahasiswa mahasiswa, string asalSekolah, List<ProgramStudi> _Pilihan)
        {
            this._mhsPendaftar = mahasiswa;
            this.asalSekolah = asalSekolah;
            this.pilihanProdi = _Pilihan;
        }
        #endregion

        #region Fungsi
        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("No KTP\t\t: " + this._mhsPendaftar.noktp);
            Console.WriteLine("Nama\t\t: " + this._mhsPendaftar.nama);
            Console.WriteLine("Alamat\t\t: " + this._mhsPendaftar.alamat);
            Console.WriteLine("No Hp\t\t: " + this._mhsPendaftar.noHp);
            Console.WriteLine("Email\t\t: " + this._mhsPendaftar.email);
            Console.WriteLine("NPM\t\t: " + this._mhsPendaftar.npm);
            Console.WriteLine("Asal Sekolah\t\t: " + this.asalSekolah);
            Console.WriteLine("Prodi yang Didaftarkan: ");
            for(int i=0;i<this.pilihanProdi[i].nama);
            {
                Console.WriteLine((int+1)+ ". "+this.pilihanProdi[i].nama);
            }

        }
        #endregion
    }
}
