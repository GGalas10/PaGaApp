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
    public partial class DodawanieUzytkownika : Form
    {
        public DodawanieUzytkownika()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                Pracownik pracownik = new Pracownik();
                foreach (var item in context.Pracowniks)
                {
                    if (item.Imie == ImieBox.Text && item.Nazwisko == NazwiskoBox.Text && item.Login == LoginBox.Text)
                    {
                        MessageBox.Show("Użytkownik już istnieje i ma numer ID: " + item.IdPracownika, "Pracownik istnieje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (comboBox1.SelectedItem != null)
                {
                    if (!string.IsNullOrWhiteSpace(ImieBox.Text) || !string.IsNullOrWhiteSpace(NazwiskoBox.Text) || !string.IsNullOrEmpty(ImieBox.Text) || !string.IsNullOrEmpty(NazwiskoBox.Text)
                        || !string.IsNullOrEmpty(LoginBox.Text) || !string.IsNullOrEmpty(HasloBox.Text) || !string.IsNullOrWhiteSpace(LoginBox.Text) || !string.IsNullOrWhiteSpace(HasloBox.Text))
                    {
                        try
                        {
                            KodowanieHasla kodowanie = new KodowanieHasla();
                            pracownik.Imie = ImieBox.Text.Trim();
                            pracownik.Nazwisko = NazwiskoBox.Text.Trim();
                            pracownik.Login = LoginBox.Text.Trim();
                            pracownik.Haslo = kodowanie.Encrypt(HasloBox.Text.Trim());
                            switch (comboBox1.SelectedItem.ToString())
                            {
                                case "Administrator":
                                    pracownik.Uprawnienia = 0;
                                    break;
                                case "Szef":
                                    pracownik.Uprawnienia = 1;
                                    break;
                                case "Pracownik":
                                    pracownik.Uprawnienia = 2;
                                    break;
                            }
                            context.Pracowniks.Add(pracownik);
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Dodano użytkownika", "Dodano użykownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Nie Dodano użytkownika", "Niedodano użykownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nie dodano użytkownika ponieważ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie podano wszystkich danych", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano uprawnień", "Brak uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
