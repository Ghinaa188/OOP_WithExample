using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class Mahasiswa : Person
    {
        private string npm;
        public string NPM { get { return this.npm} set {this.npm = value;}}

        public Mahasiswa(string _noKTP, string _nama, string _alamat, string _noHP, string _email, string _npm)
        {
            this.noktp = _noKTP;
            this.nama = _nama;
            this.alamat = _alamat;
            this.noHp = _noHP;
            this.email = _email;
            this.NPM = _npm;
        }
        #region Fungsi
        
        #endregion
    }
}
