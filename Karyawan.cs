using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class Karyawan : Person
    {
        private string nik;
        public string NIK { get { return this.nik; } set { this.nik = value; } }

        #region Constructor
        public Karyawan(string _ktp, string _nama, string _alamat, string _NoHP, string _email,string _nik)
        {
            this.noktp = _ktp;
            this.nama = _nama;
            this.alamat = _alamat;
            this.noHp = _NoHP;
            this.email = _email;
            this.NIK = _nik;
        }
        #endregion
    }
}
