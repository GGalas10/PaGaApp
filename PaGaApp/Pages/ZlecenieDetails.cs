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
    public partial class ZlecenieDetails : Form
    {
        public Zlecenie zlec;
        public List<Usluga> listauslug;
        public ZlecenieDetails(Zlecenie wybrane)
        {
            listauslug = new List<Usluga>();
            zlec = wybrane;
            InitializeComponent();
        }

        private void ZlecenieDetails_Load(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext()) {
                Zlecenie wyb = context.Zlecenies.FirstOrDefault(z => z.IdZlecenia == zlec.IdZlecenia);
                Samochod car = context.Samochods.FirstOrDefault(c => c.IdSamochodu == wyb.IdSamochodu);
                Klient klient = context.Klients.FirstOrDefault(k => k.IdKlienta == wyb.IdKlienta);
                this.Text = "Zlecenie "+car.Marka+" "+car.Model+" "+car.NumerRejestracyjny;
                ImieBox.Text = klient.Imie;
                NazwiskoBox.Text = klient.Nazwisko;
                NrTelBox.Text = klient.NumerTelefonu;
                MarkaBox.Text = car.Marka;
                ModelBox.Text = car.Model;
                RocznikBox.Text = car.DataProdukcji.ToString();
                NrRejBox.Text = car.NumerRejestracyjny;
                NrVINBox.Text = car.NumerVIN;
                if(wyb.Czyzakończone == true)
                {
                    StanBox.Text = StanBox.Items[1].ToString();
                    DataLbl.Text = "Data przyjęcia\n" + wyb.Data_Przyjecia+"\nData zakończenia\n" + wyb.Data_Zamkniecia;
                    EditBtn.Visible = false;
                }
                else
                {
                    DataLbl.Text = "Data przyjęcia\n" + wyb.Data_Przyjecia;
                    StanBox.Text = StanBox.Items[0].ToString();                  
                }
                uslugi();
                
            }
        }
        public void uslugi()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Idusługi", "Id usługi");
            dataGridView1.Columns.Add("Nazwa", "Nazwa");
            dataGridView1.Columns.Add("Cena", "Cena");
            double? suma = 0;
            using(PaGaContext context = new PaGaContext())
            {
                if (listauslug.Count == 0)
                {
                    foreach (var item in context.Uslugas.Where(z => z.IdZlecenia == zlec.IdZlecenia))
                    {
                        dataGridView1.Rows.Add(item.IdUslugi, item.Nazwa, item.Cena);
                        listauslug.Add(item);
                        suma += item.Cena;
                    }
                }
                else
                {
                    foreach (var item in listauslug)
                    {
                        dataGridView1.Rows.Add(item.IdUslugi, item.Nazwa, item.Cena);
                        suma += item.Cena;
                    }
                }
            }
            NetLbl.Text = "Suma netto: " + Math.Round((double)suma / 1.23);
            BrtLbl.Text = "Suma brutto: " + Math.Round((double)suma);
        }
        private void CanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (zlec.Czyzakończone == false)
            {
                if (StanBox.Enabled == false)
                {
                    StanBox.Enabled = true;
                    UslugaBtn.Visible = true;
                    SaveBtn.Visible = true;
                }
                else
                {
                    StanBox.Enabled = false;
                    UslugaBtn.Visible = false;
                    SaveBtn.Visible = false;
                }
            }
        }

        private void UslugaBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                Zlecenie wyb = context.Zlecenies.FirstOrDefault(z => z.IdZlecenia == zlec.IdZlecenia);
                listauslug = wyb.Uslugas.ToList();
                DodawanieUslugi dod = new DodawanieUslugi(listauslug);
                dod.ShowDialog();             
                foreach (var item in listauslug)
                {
                            wyb.Uslugas.Add(item);
                }
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Udalo się");
                }
            }
            uslugi();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                using(PaGaContext context = new PaGaContext())
                {

                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                Zlecenie wyb = context.Zlecenies.FirstOrDefault(z => z.IdZlecenia == zlec.IdZlecenia);
                if (StanBox.Text=="W realizacji")
                {
                    wyb.Data_Zamkniecia = null;
                    wyb.Czyzakończone = false;
                }
                else
                {
                    wyb.Data_Zamkniecia = DateTime.Now;
                    wyb.Czyzakończone = true;
                }
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Zapis udany", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
