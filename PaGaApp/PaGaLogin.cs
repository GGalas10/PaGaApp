using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp
{
    public partial class PaGaLogin : Form
    {
        public PaGaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logowanie();
        }

        private void PaGaLogin_Load(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                try
                {
                    var ote = context.Database.Connection;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bład bazy danych " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (context.Pracowniks.Count() <= 0)
                {
                    var result = MessageBox.Show("Brak użytkowników w aplikacji\n Czy chcesz dodać?", "Brak użytkowników", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Pages.DodawanieUzytkownika dod = new Pages.DodawanieUzytkownika();
                        dod.ShowDialog();
                    }
                }
            }
        }

        private void HasloBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Logowanie();
            }
        }

        private void Logowanie()
        {
            using (PaGaContext context = new PaGaContext())
            {
                KodowanieHasla crypt = new KodowanieHasla();

                foreach (var item in context.Pracowniks)
                {
                    if (item.Login == LoginBox.Text && crypt.Decrypt(item.Haslo) == HasloBox.Text)
                    {

                        Program.pracownik = context.Pracowniks.FirstOrDefault(p => p.IdPracownika == item.IdPracownika);
                        PaGaMenu EkranGlowny = new PaGaMenu(context.Pracowniks.FirstOrDefault(p => p.IdPracownika == item.IdPracownika));
                        this.Visible = false;
                        EkranGlowny.ShowDialog();
                        this.Visible = true;
                        return;
                    }


                }
                MessageBox.Show("Podano błędne dane logowania", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
