using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace PaGaApp.Pages
{
    public partial class DodawanieKlienta : Form
    {
        public List<Samochod> listaSamochodow = new List<Samochod>();
        Klient klient = new Klient();
        Samochod samochod = new Samochod();
        public DodawanieKlienta()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NrtelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ImieBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void NazwiskoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            DodawanieSamochodu newCar = new DodawanieSamochodu(listaSamochodow);
            newCar.ShowDialog();
            CarList.Items.Clear();
            foreach (var item in listaSamochodow)
            {
                CarList.Items.Add(item.Marka + " " + item.Model);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                foreach (var item in context.Klients)
                {
                    if (item.Imie == ImieBox.Text && item.Nazwisko == NazwiskoBox.Text)
                    {
                        MessageBox.Show("Istnieje już taki użytkownik i ma ID " + item.IdKlienta, "Klient już istnieje", MessageBoxButtons.OK);
                        return;
                    }
                }
                try
                {
                    if (listaSamochodow.Count <= 0)
                    {
                        MessageBox.Show("Należy wprowadzić chociaż 1 samochód", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(ImieBox.Text) || string.IsNullOrEmpty(NazwiskoBox.Text) || string.IsNullOrEmpty(NrtelBox.Text))
                        {
                            MessageBox.Show("Należy podać wszystkie dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            klient.Imie = ImieBox.Text.Trim();
                            klient.Nazwisko = NazwiskoBox.Text.Trim();
                            klient.NumerTelefonu = NrtelBox.Text.Trim();
                            foreach (var item in listaSamochodow)
                            {
                                klient.Samochods.Add(item);
                            }

                            context.Klients.Add(klient);
                            if (context.SaveChanges() > 0)
                            {

                                this.Close();
                                MessageBox.Show("Klient został dodany", "Dodano Klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się dodać klienta", "Niedodano Klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klient nie został dodany ponieważ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
