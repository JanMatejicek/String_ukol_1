using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_ukol_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                button_odsifrovat.Enabled = true;
                button_sifrovat.Enabled = false;
                string vstup = textBox1.Text;
                int posun = int.Parse(textBox2.Text);
                string šifra = "";
                bool chyba = true;
                vstup.ToLower();
                foreach (char c in vstup) {
                    if (c >= 'a' && c <= 'z') {
                        int i = (int)c;
                        i += posun;
                        if (i > (int)'z') { i -= 26; }
                        char znak = (char)i;
                        šifra += znak;
                        chyba = false;
                    }
                    else { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                if (chyba == false) { label_sifra.Text = šifra; }
            } catch { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_odsifrovat_Click(object sender, EventArgs e)
        {
            try {
                button_odsifrovat.Enabled = false;
                button_sifrovat.Enabled = true;
                string vstup = label_sifra.Text;
                int posun = int.Parse(textBox2.Text);
                string šifra = "";
                bool chyba = true;
                vstup.ToLower();
                foreach (char c in vstup) {
                    if (c >= 'a' && c <= 'z') {
                        int i = (int)c;
                        i -= posun;
                        if (i < (int)'a') { i += 26; }
                        char znak = (char)i;
                        šifra += znak;
                        chyba = false;
                    }
                    else { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                if (chyba == false) { label_sifra.Text = šifra; }
            } catch { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
