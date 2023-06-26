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
    public partial class DodawanieZlecenia : Form
    {
        public Klient wybklient;
        public List<Usluga> uslugi;
        public DodawanieZlecenia()
        {
            uslugi = new List<Usluga>();
            InitializeComponent();
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Wypelnianie()
        {
            KlientBox.Items.Clear();
            KlientBox.Items.Add("Dodaj klienta");
            using (PaGaContext context = new PaGaContext())
            {
                foreach (var item in context.Klients)
                {
                    KlientBox.Items.Add(item.IdKlienta + ". " + item.Imie + " " + item.Nazwisko);
                }
            }
        }
        private void DodawanieZlecenia_Load(object sender, EventArgs e)
        {

            Wypelnianie();
        }

        private void KlientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                if (KlientBox.SelectedItem.ToString() == "Dodaj klienta")
                {
                    DodawanieKlienta dodawanie = new DodawanieKlienta();
                    CarBox.Visible = false;
                    label2.Visible = false;
                    dodawanie.ShowDialog();
                    Wypelnianie();
                }
                else
                {
                    CarBox.Items.Clear();
                    string wybrany = KlientBox.SelectedItem.ToString();
                    int index = int.Parse(wybrany.Substring(0, wybrany.IndexOf(".")));
                    wybklient = context.Klients.FirstOrDefault(k => k.IdKlienta == index);
                    CarBox.Items.Add("Dodaj samochód");
                    foreach (var item in wybklient.Samochods)
                    {
                        CarBox.Items.Add(item.IdSamochodu + ". " + item.Marka + " " + item.NumerRejestracyjny);
                    }
                    CarBox.Visible = true;
                    label2.Visible = true;
                }
            }
        }

        private void CarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext()) {
                if (CarBox.SelectedItem.ToString() == "Dodaj samochód")
                {
                    string wybrany = KlientBox.SelectedItem.ToString();
                    int index = int.Parse(wybrany.Substring(0, wybrany.IndexOf(".")));
                    wybklient = context.Klients.FirstOrDefault(k => k.IdKlienta == index);
                    List<Samochod> carlista = new List<Samochod>();
                    carlista = wybklient.Samochods.ToList();
                    DodawanieSamochodu addcar = new DodawanieSamochodu(carlista);
                    addcar.ShowDialog();
                    foreach (var item in carlista)
                    {
                        wybklient.Samochods.Add(item);
                    }
                    context.SaveChanges();
                    CarBox.Items.Clear();
                    CarBox.Items.Add("Dodaj samochód");
                    foreach (var item in wybklient.Samochods)
                    {
                        CarBox.Items.Add(item.IdSamochodu + ". " + item.Marka + " " + item.NumerRejestracyjny);
                    }
                }
                else
                {
                    UslugaBtn.Visible = true;
                }
            }
            
        }

        private void KlientBox_TextChanged(object sender, EventArgs e)
        {
            CarBox.Visible = false;
            label2.Visible = false;
        }

        private void KlientBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CarBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void UslugaBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                double? cena = 0;
                string wybrany = KlientBox.SelectedItem.ToString();
                int index = int.Parse(wybrany.Substring(0, wybrany.IndexOf(".")));
                wybklient = context.Klients.FirstOrDefault(k => k.IdKlienta == index);
                DodawanieUslugi usluga = new DodawanieUslugi(uslugi);
                usluga.ShowDialog();
                dataGridView1.Rows.Clear();
                foreach(var item in uslugi)
                {
                    dataGridView1.Rows.Add(uslugi.IndexOf(item)+1, item.Nazwa, item.Cena);
                    cena += item.Cena;
                }
                label3.Text = "Suma za zlecenie\n" + Math.Round((double)cena,2).ToString();
            }
        }

        private void CarBox_TextChanged(object sender, EventArgs e)
        {
            UslugaBtn.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                Zlecenie zlec = new Zlecenie();
                if (KlientBox.SelectedItem != null)
                {
                    if (CarBox.SelectedItem != null)
                    {
                        double? cena = 0;
                        string wybrany = KlientBox.SelectedItem.ToString();
                        int index = int.Parse(wybrany.Substring(0, wybrany.IndexOf(".")));
                        string wybranycar = CarBox.SelectedItem.ToString();
                        int indexcar = int.Parse(wybranycar.Substring(0, wybrany.IndexOf(".")));
                        zlec.Klient = context.Klients.FirstOrDefault(k => k.IdKlienta == index);
                        zlec.Samochod = context.Samochods.FirstOrDefault(s => s.IdSamochodu == indexcar);
                        foreach(var item in uslugi)
                        {
                            zlec.Uslugas.Add(item);
                            cena += item.Cena;
                        }
                        zlec.Koszt_Zlecenia = Math.Round((double)cena,2);
                        zlec.Data_Przyjecia = DateTime.Now;
                        zlec.Pracownik = context.Pracowniks.FirstOrDefault(p => p.IdPracownika == Program.pracownik.IdPracownika);
                        context.Zlecenies.Add(zlec);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Zlecenie zostało dodane", "Dodano zlecenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Zlecenie nie zostało dodane", "Nie dodano zlecenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Nalezy wybrać samochód", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nalezy wybrać Klienta", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
