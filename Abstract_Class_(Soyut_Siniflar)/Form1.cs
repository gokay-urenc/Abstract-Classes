using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Class__Soyut_Siniflar_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Insan i = new Insan(); // Abstract olduğu için instance alınamaz. Hata verir.
            i.adi = "Negan";
            i.soyadi = "Lucille";
            i.cinsiyet = 'E';
            i.yas = 52; */

            Egitmen egt = new Egitmen();
            egt.adi = "Onur";
            egt.soyadi = "Şişoğlu";
            egt.cinsiyet = 'E';
            egt.yas = 27;
            egt.dogum_tarihi = DateTime.Now.AddYears(-27);
        }
    }
}