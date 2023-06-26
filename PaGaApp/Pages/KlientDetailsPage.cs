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

namespace PaGaApp.Pages
{
    public partial class KlientDetailsPage : Form
    {
        public Klient klient;
        public KlientDetailsPage(Klient wybranyKlient)
        {
            klient = wybranyKlient;
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ImieBox.ReadOnly == true)
            {
                ImieBox.ReadOnly = false;
                NazwiskoBox.ReadOnly = false;
                TelBox.ReadOnly = false;
                SaveBtn.Visible = true;
            }
            else
            {
                ImieBox.ReadOnly = true;
                NazwiskoBox.ReadOnly = true;
                TelBox.ReadOnly = true;
                SaveBtn.Visible = false;
            }
        }

        private void KlientDetailsPage_Load(object sender, EventArgs e)
        {
            ImieBox.Text = klient.Imie;
            NazwiskoBox.Text = klient.Nazwisko;
            TelBox.Text = klient.NumerTelefonu;
            CarList.Items.Add("Dodaj samochód");
            foreach (var item in klient.Samochods)
            {
                CarList.Items.Add(item.IdSamochodu + ". " + item.Marka + " " + item.Model);
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            using (PaGaContext context = new PaGaContext())
            {
                var result = context.Klients.FirstOrDefault(k => k.IdKlienta == klient.IdKlienta);
                foreach (var item in context.Klients)
                {
                    if (item.Imie == ImieBox.Text && item.Nazwisko == NazwiskoBox.Text && item.IdKlienta != klient.IdKlienta)
                    {
                        MessageBox.Show("Istnieje już taki użytkownik i ma ID " + item.IdKlienta, "Klient już istnieje", MessageBoxButtons.OK);
                        return;
                    }
                }
                result.Imie = ImieBox.Text.Trim();
                result.Nazwisko = NazwiskoBox.Text.Trim();
                result.NumerTelefonu = TelBox.Text.Trim();
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Zmiana się udała");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić danych");
                }

            }
        }

        private void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (PaGaContext context = new PaGaContext())
            {
                Klient wybranyklient = context.Klients.FirstOrDefault(k => k.IdKlienta == klient.IdKlienta);
                if (CarList.SelectedItem.ToString() == "Dodaj samochód")
                {
                    string wybrany = CarList.SelectedItem.ToString();
                    List<Samochod> carlista = new List<Samochod>();
                    carlista = wybranyklient.Samochods.ToList();
                    DodawanieSamochodu addcar = new DodawanieSamochodu(carlista);
                    addcar.ShowDialog();
                    foreach (var item in carlista)
                    {
                        wybranyklient.Samochods.Add(item);
                    }
                    if (context.SaveChanges() > 0)
                    {
                        CarList.Items.Clear();
                        CarList.Items.Add("Dodaj samochód");
                        foreach (var item in wybranyklient.Samochods)
                        {
                            CarList.Items.Add(item.IdSamochodu + ". " + item.Marka + " " + item.NumerRejestracyjny);
                        }
                    }                                       
                }
                else
                {
                    int carindex;
                    string index = CarList.SelectedItem.ToString().Substring(0, CarList.SelectedItem.ToString().IndexOf("."));
                    if (int.TryParse(index, out carindex))
                    {

                        Samochod car = context.Samochods.FirstOrDefault(s=>s.IdSamochodu==carindex);
                        CarDetailsPage carpage = new CarDetailsPage(car);
                        carpage.ShowDialog();
                        CarList.Items.Clear();
                        foreach (var item in klient.Samochods)
                        {
                            CarList.Items.Add(item.IdSamochodu + ". " + item.Marka + " " + item.Model);
                        }
                    }
                }
            }           
        }

        private void TelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
