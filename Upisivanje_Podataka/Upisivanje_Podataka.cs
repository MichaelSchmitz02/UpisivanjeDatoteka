using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upisivanje_Podataka
{
    public partial class Form1 : Form
    {

        public class Datoteka
        {
            public string Ime;
            public string Prezime;
            public string Godina_rodenja;
            public string Email;
        }

        public Datoteka (string Ime,  string Prezime, string Godina_rodenja, string Email)
        {
            this.txt_Ime = Ime;
            this.txt_Prezime = Prezime;
            this.txt_Godina_rodenja = Godina_rodenja;
            this.txt_Email = Email;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
