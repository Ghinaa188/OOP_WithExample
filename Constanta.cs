using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    //<summary>
    //class ini berfungsi sebagai penaruh nilai-nilai konstanta. Tidak perlu adanya maintain data/informasi disini. Oleh karena itu tipe
    //dari variabel-nya adalah public static. Public agar bisa diakses keluar class-nya, dan static agar tidak perlu dibuat objek lagi 
    //si-class Constanta  ini.
    //</summary>
    class Constanta
    {
        #region Variabael yang berfungsi hanya sebagai pelengkap data saja
        public static string _NAMAKAMPUS = "POLITEKNIK PRAKTISI BANDUNG";
        public static string _ALAMATKAMPUS = "Jalan Merdeka No.46";
        public static int _BIAYAPERKULIAHAN = 6000000;
        #endregion

        //<summary>
        //Variabel pilihan prodi untuk menampung daftar prodi yang dapat dipilih
        //<summary>
        public static List<ProgramStudi> pilihanProdi = new List<ProgramStudi>();
        //<summary>
        //Variabel Pilihan Dosen untuk menampung daftar Dosen - Dosen
        public static List<Dosen> pilihanDosen = new List<Dosen>();
        //<summary>
        //Variabel pilihan prodi untuk menampung daftar Karyawan
        public static List<Karyawan> pilihanKaryawan = new List<Karyawan>();


    }
}
