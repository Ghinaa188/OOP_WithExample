using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WithExample
{
    class Person
    {
        private string NoKTP;
        private string Nama;
        private string Alamat;
        private string NoHP;
        private string Email;

        public string noktp { get { return this.NoKTP; } set { this.NoKTP = value; } }
        public string nama { get { return this.Nama; } set { this.Nama = value; } }
        public string alamat { get { return this.Alamat; } set { this.Alamat = value; } }
        public string noHp { get { return this.NoHP; } set { this.NoHP = value; } }
        public string email { get { return this.Email; } set { this.Email = value; } }

    }
}
