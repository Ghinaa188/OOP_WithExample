using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class Dosen : Person
    {
        private string KodeDosen;
        public string kodeDosen { get { return this.KodeDosen; } set { this.KodeDosen = value; } }

        public Dosen(string _ktp,string _Nama, string _alamat, string _Hp, string _email, string _kode)
        {
            this.noktp = _ktp;
            this.nama = _Nama;
            this.alamat = _alamat;
            this.noHp = _Hp;
            this.email = _email;
            this.kodeDosen = _kode;
        }


        
    }
}
