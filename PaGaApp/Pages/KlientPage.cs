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
    public partial class KlientPage : Form
    {
        System.Collections.Specialized.StringCollection colvis = new System.Collections.Specialized.StringCollection();
        public string wyszukiwanie;
        public string szukany;
        public KlientPage()
        {
            InitializeComponent();
        }
        private void DaneStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WyszukiwanieBtn.Text = e.ClickedItem.Text;
            Properties.Settings.Default.LastSerachKlient = e.ClickedItem.Text;
            wyszukiwanie = e.ClickedItem.Text;
            DaneStrip.Location = new Point(WyszukiwanieBtn.Location.X + WyszukiwanieBtn.Size.Width + 5, DaneStrip.Location.Y);
        }

        private void DaneStrip_MenuDeactivate(object sender, EventArgs e)
        {
            DaneStrip.Visible = false;
        }

        private void KlientPage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.F8)
            {
                if (PanelWyszukiwania.Visible == false)
                {
                    PanelWyszukiwania.Visible = true;
                    dataGridView1.Location = new Point(12, 95);
                    dataGridView1.Size = new Size(new Point(dataGridView1.Size.Width, dataGridView1.Size.Height - 55));
                }

                else
                {
                    PanelWyszukiwania.Visible = false;
                    dataGridView1.Location = new Point(12, 40);
                    dataGridView1.Size = new Size(new Point(dataGridView1.Size.Width, dataGridView1.Size.Height + 55));
                }
            }
        }

        private void WyszukiwanieBtn_Click(object sender, EventArgs e)
        {
            if (DaneStrip.Visible == false)
            {
                DaneStrip.Visible = true;
                DaneStrip.Location = new Point(WyszukiwanieBtn.Location.X + WyszukiwanieBtn.Size.Width + 5, DaneStrip.Location.Y);
            }
            else
            {
                DaneStrip.Visible = false;
            }
        }

        private void AddKlient_Click(object sender, EventArgs e)
        {
            DodawanieKlienta addClient = new DodawanieKlienta();
            addClient.ShowDialog();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            KlientPage_Load(sender, e);
        }
        public void load()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSerachKlient))
            {
                wyszukiwanie = Properties.Settings.Default.LastSerachKlient;
                WyszukiwanieBtn.Text = Properties.Settings.Default.LastSerachKlient;
            }
            colvis = Properties.Settings.Default.ColKlienci;
            foreach (var item in colvis)
            {
                dataGridView1.Columns.Add(item, item);
            }
            if (Properties.Settings.Default.Col2Klient != null)
            {
                foreach (var item in Properties.Settings.Default.Col2Klient)
                {
                    dataGridView1.Columns[item.ToString()].Visible = false;
                }
            }
            using (PaGaContext context = new PaGaContext())
            {
                List<Klient> lista = context.Klients.ToList();
                if (!string.IsNullOrEmpty(szukany))
                {
                    lista = Wyszukiwanie();
                }

                CountLbl.Text = "Ilość klientów: " + context.Klients.Count(); 
                if (lista.Count() > 0)
                {
                    foreach (var item in lista)
                    {
                        dataGridView1.Rows.Add(item.IdKlienta, item.Imie, item.Nazwisko, item.NumerTelefonu);
                    }
                }
                if(context.Klients.Count()<0)
                {
                    MessageBox.Show("Brak klientów w bazie", "Brak klientów", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }       

        private void KlientPage_Load(object sender, EventArgs e)
        {
            if (PaGaMenu.zal.Uprawnienia == 0 || PaGaMenu.zal.Uprawnienia == 1)
            {
                DelBtn.Visible = true;
            }
            else
            {
                DelBtn.Visible = false;
            }
            load();
        }
        public List<Klient> Wyszukiwanie()
        {
            int szukana;
            using (PaGaContext context = new PaGaContext())
            {
                if (!string.IsNullOrEmpty(wyszukiwanie))
                {
                    switch (wyszukiwanie)
                    {
                        case "Id Klienta":
                            if (int.TryParse(szukany, out szukana)) {
                                return context.Klients.Where(k => k.IdKlienta == szukana).ToList();
                            }
                            else
                            {
                                return context.Klients.ToList();
                            }
                        case "Imie":
                            return context.Klients.Where(k => k.Imie.Contains(szukany)).ToList();
                        case "Nazwisko":
                            return context.Klients.Where(k => k.Imie.Contains(szukany)).ToList();
                        case "Numer Telefonu":
                                return context.Klients.Where(k => k.NumerTelefonu.Contains(szukany)).ToList();
                    }
                    
                }
                return context.Klients.ToList();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OpcjeBtn_Click(object sender, EventArgs e)
        {
            WybKolKlient kolumny = new WybKolKlient();
            kolumny.ShowDialog();
            load();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                szukany = textBox1.Text;
                load();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                int rowindex = dataGridView1.SelectedRows[0].Index;
                int kliindex;
                if (int.TryParse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString(), out kliindex))
                {
                    using (PaGaContext context = new PaGaContext())
                    {
                        Klient kli = context.Klients.FirstOrDefault(k => k.IdKlienta == kliindex);
                        var result = MessageBox.Show("Czy na pewno chcesz usunąć klienta ID:" + kli.IdKlienta +
                            "\nNa dane Imie:" + kli.Imie + " Nazwisko:" + kli.Nazwisko + " Numer Telefonu:" + kli.NumerTelefonu,"Czy jesteś pewny?!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            kli.Samochods.Clear();
                            context.Klients.Remove(kli);
                            context.SaveChanges();
                        }
                    }
                }
            }
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                int rowIndex = e.RowIndex;
                int colidIndex = dataGridView1.Columns["Id Klienta"].Index;
                int klientIndex = int.Parse(dataGridView1.Rows[rowIndex].Cells[colidIndex].Value.ToString());
                KlientDetailsPage detform = new KlientDetailsPage(context.Klients.FirstOrDefault(k => k.IdKlienta == klientIndex));
                detform.ShowDialog();
                dataGridView1.Rows.Clear();
                load();
            }
        }
    }
}
