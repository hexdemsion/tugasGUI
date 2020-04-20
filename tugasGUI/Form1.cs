using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lingkaran objek_satu = new Lingkaran();
            objek_satu.Konstruksi(6, 3.14);

            MessageBox.Show(
                "Jari-jari: "+objek_satu.jari+"\n"+
                "Keliling: "+objek_satu.Keliling()+"\n"+
                "Luas: " + objek_satu.Luas(),
                "Informasi Objek Pertama");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lingkaran objek_dua = new Lingkaran();
            objek_dua.Konstruksi(8, 3.14);

            MessageBox.Show(
                "Jari-jari: " + objek_dua.jari + "\n" +
                "Keliling: " + objek_dua.Keliling() + "\n" +
                "Luas: " + objek_dua.Luas(),
                "Informasi Objek Kedua");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lingkaran objek_tiga = new Lingkaran();
            objek_tiga.Konstruksi(17, 3.14);

            MessageBox.Show(
                "Jari-jari: " + objek_tiga.jari + "\n" +
                "Keliling: " + objek_tiga.Keliling() + "\n" +
                "Luas: " + objek_tiga.Luas(),
                "Informasi Objek Ketiga");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lingkaran objek_empat = new Lingkaran();
            objek_empat.Konstruksi(19, 3.14);

            MessageBox.Show(
                "Jari-jari: " + objek_empat.jari + "\n" +
                "Keliling: " + objek_empat.Keliling() + "\n" +
                "Luas: " + objek_empat.Luas(),
                "Informasi Objek Keempat");
        }
    }
}
