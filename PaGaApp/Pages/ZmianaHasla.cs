using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp.Pages
{
    public partial class ZmianaHasla : Form
    {
        public Pracownik zmiana;
        public ZmianaHasla(Pracownik prac)
        {
            Pracownik zmiana = prac;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (PaGaContext context = new PaGaContext()) {
                KodowanieHasla kod = new KodowanieHasla();
                Pracownik sprawdzany = context.Pracowniks.FirstOrDefault(p => p.IdPracownika == PaGaMenu.zal.IdPracownika);
                if (OldBox.Text == kod.Decrypt(sprawdzany.Haslo))
                {
                    if(New1Box.Text == NewBox.Text)
                    {
                        sprawdzany.Haslo = kod.Encrypt(NewBox.Text.Trim());
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Hasło zostało zmienione", "Zmieniono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hasło nie zostało zmienione ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hasła nie są takie same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hasło jest błędne", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
