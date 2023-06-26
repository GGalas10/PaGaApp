﻿using System;
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
    public partial class ZleceniaZamknietePage : Form
    {
        System.Collections.Specialized.StringCollection colVis = new System.Collections.Specialized.StringCollection();
        public string wyszukiwanie;
        public string data;
        public string szukany;

        public ZleceniaZamknietePage()
        {
            InitializeComponent();
        }
        private void WypData()
        {
            if (Properties.Settings.Default.LastTimeDone == "Dowolna data")
            {
                DataBtn.Text = Properties.Settings.Default.LastDowolnaDone.ToString("d");
            }
            else
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.LastTimeDone))
                    DataBtn.Text = Properties.Settings.Default.LastTimeDone;
            }
            dataGridView1.Columns.Clear();
            colVis = Properties.Settings.Default.ColZlecenia;
            foreach (var item in colVis)
            {
                dataGridView1.Columns.Add(item, item);
            }
            if (Properties.Settings.Default.Col2Done != null)
            {
                foreach (string item in Properties.Settings.Default.Col2Done)
                {
                    dataGridView1.Columns[item.ToString()].Visible = false;
                }
            }
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = Wyszukiwanie();
                lista = SortowanieData(lista);
                lista = lista.Where(z => z.Czyzakończone == true).ToList();
                CountLbl.Text = "Ilość zleceń: " + context.Zlecenies.Where(zle => zle.Czyzakończone == true).Count();
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        Klient kli = context.Klients.FirstOrDefault(k => k.IdKlienta == item.IdKlienta);
                        Samochod sam = context.Samochods.FirstOrDefault(s => s.IdSamochodu == item.IdSamochodu);
                        dataGridView1.Rows.Add(item.IdZlecenia, kli.Imie, kli.Nazwisko, sam.Marka, sam.Model, item.Data_Przyjecia, sam.NumerRejestracyjny, sam.NumerVIN);
                    }
                }
                else
                {
                    MessageBox.Show("Nie ma jeszcze żadnego zakończonego zlecenia", "Brak zleceń", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public List<Zlecenie> Wyszukiwanie()
        {
            int szukana;
            using (PaGaContext context = new PaGaContext()) {
                if (!string.IsNullOrEmpty(wyszukiwanie) && !string.IsNullOrEmpty(szukany))
                {
                    switch (wyszukiwanie)
                    {
                        case "Id Zlecenia":
                            if (int.TryParse(szukany, out szukana))
                            {
                                return context.Zlecenies.Where(z => z.IdZlecenia == szukana).ToList();
                            }
                            else
                            {
                                return context.Zlecenies.ToList();
                            }
                        case "Dane klienta":
                            List<Zlecenie> lista = new List<Zlecenie>();
                            lista.AddRange(context.Zlecenies.Where(z => z.Klient.Imie.Contains(szukany)).ToList());
                            lista.AddRange(context.Zlecenies.Where(z => z.Klient.Nazwisko.Contains(szukany)).ToList());
                            return lista;
                        case "Marka samochodu":
                            return context.Zlecenies.Where(z => z.Samochod.Marka.Contains(szukany)).ToList();
                        case "Model Samochodu":
                            return context.Zlecenies.Where(z => z.Samochod.Model.Contains(szukany)).ToList();
                        case "Numer Rejestracyjny":
                            return context.Zlecenies.Where(z => z.Samochod.NumerRejestracyjny.Contains(szukany)).ToList();
                        case "Numer Vin":
                            return context.Zlecenies.Where(z => z.Samochod.NumerVIN.Contains(szukany)).ToList();
                    }
                }
                return context.Zlecenies.ToList();
            }
        }
        public List<Zlecenie> SortowanieData(List<Zlecenie> zbior)
        {
            List<Zlecenie> dosortowania = zbior;
            DateTime dzisiaj = DateTime.Today;
            DateTime kontrol;
            if (!string.IsNullOrEmpty(data)) {
                switch (data)
                {
                    case "Bierzący dzień":
                        return dosortowania/*.Where(d => d.Data_Zamkniecia >= dzisiaj)*/.ToList();
                    case "Bierzący tydzień":
                        kontrol = new DateTime(dzisiaj.Year, dzisiaj.Month, dzisiaj.Day - 7);
                        return dosortowania.Where(d => d.Data_Zamkniecia >= kontrol).ToList();
                    case "Bierzący miesiąc":
                        kontrol = new DateTime(dzisiaj.Year, dzisiaj.Month-1, dzisiaj.Day);
                        return dosortowania.Where(d => d.Data_Zamkniecia >= kontrol).ToList();
                    case "Bierzący rok":
                        kontrol = new DateTime(dzisiaj.Year-1, dzisiaj.Month, dzisiaj.Day);
                        return dosortowania.Where(d => d.Data_Zamkniecia >= kontrol).ToList();
                    case "Dowolna data":
                        return dosortowania.Where(d => d.Data_Zamkniecia >= Properties.Settings.Default.LastDowolnaDone).ToList();
                    case "Brak daty":
                        return dosortowania;
                }
                return dosortowania;
            }else
                return dosortowania;
        }      
        private void WyszukiwanieBtn_Click(object sender, EventArgs e)
        {
            string wyszukiwanyteskt = textBox1.Text;
            
        }

        private void DataBtn_Click(object sender, EventArgs e)
        {
            if (DataStrip.Visible == false)
            {
                DataStrip.Visible = true;
                DataStrip.Location = new Point(DataBtn.Location.X + DataBtn.Size.Width + 5, DataStrip.Location.Y);
            }
            else
                DataStrip.Visible = false;
        }

        private void WyszukiwanieBtn_Click_1(object sender, EventArgs e)
        {
            if (DaneStrip.Visible == false)
            {
                DaneStrip.Visible = true;
                DaneStrip.Location = new Point(WyszukiwanieBtn.Location.X + WyszukiwanieBtn.Size.Width + 5, DaneStrip.Location.Y);
            }
            else
                DaneStrip.Visible = false;
        }

        private void ZleceniaZamknietePage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.F8)
            {
                if (PanelWyszukiwania.Visible == false)
                {                   
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSearchDone))
                    {
                        WyszukiwanieBtn.Text = Properties.Settings.Default.LastSearchDone;
                        wyszukiwanie = Properties.Settings.Default.LastSearchDone;
                    }
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

        private void DataStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Dowolna data")
            {
                WybieranieDaty data = new WybieranieDaty(this);
                data.ShowDialog();
                DataBtn.Text = Properties.Settings.Default.LastDowolnaDone.ToString("d");
            }
            else
            {
                Properties.Settings.Default.LastTimeDone = e.ClickedItem.Text;
                data = e.ClickedItem.Text;
                DataBtn.Text = e.ClickedItem.Text;
                DataStrip.Location = new Point(DataBtn.Location.X + DataBtn.Size.Width + 5, DataStrip.Location.Y);
                Properties.Settings.Default.Save();
            }
            WypData();
        }

        private void DataStrip_MenuDeactivate(object sender, EventArgs e)
        {
            DataStrip.Visible = false;
        }

        private void DaneStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            szukany = e.ClickedItem.Text;
            Properties.Settings.Default.LastSearchDone = e.ClickedItem.Text;
            WyszukiwanieBtn.Text = e.ClickedItem.Text;
            DaneStrip.Location = new Point(WyszukiwanieBtn.Location.X + WyszukiwanieBtn.Size.Width + 5, DaneStrip.Location.Y);
            Properties.Settings.Default.Save();
        }

        private void DaneStrip_MenuDeactivate(object sender, EventArgs e)
        {
            DaneStrip.Visible = false;
        }

        private void ZleceniaZamknietePage_Load(object sender, EventArgs e)
        {
            if(PaGaMenu.zal.Uprawnienia == 0 || PaGaMenu.zal.Uprawnienia == 1)
            {
                DelBtn.Visible = true;
            }
            else
            {
                DelBtn.Visible = false;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSearchDone))
                wyszukiwanie = Properties.Settings.Default.LastSearchDone;
            else
                wyszukiwanie = null;
            WypData();
        }

        private void OpcjeBtn_Click(object sender, EventArgs e)
        {
            WybKolZamkniete kolumny = new WybKolZamkniete();
            kolumny.ShowDialog();
            WypData();
        }

        private void DaneStrip_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wyszukiwanie = textBox1.Text;
                WypData();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {

                int rowind = (e as DataGridViewCellEventArgs).RowIndex;
                int zlecind;
                if (int.TryParse(dataGridView1.Rows[rowind].Cells[0].Value.ToString(), out zlecind))
                {
                    ZlecenieDetails zlecpage = new ZlecenieDetails(context.Zlecenies.FirstOrDefault(z => z.IdZlecenia == zlecind));
                    zlecpage.ShowDialog();
                    WypData();
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                int rowindex = dataGridView1.SelectedRows[0].Index;
                int zlecindex;
                if (int.TryParse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString(), out zlecindex))
                {
                    using (PaGaContext context = new PaGaContext())
                    {
                        Zlecenie zlec = context.Zlecenies.FirstOrDefault(z => z.IdZlecenia == zlecindex);
                        Klient kli = context.Klients.FirstOrDefault(k => k.IdKlienta == zlec.IdKlienta);
                        Samochod sam = context.Samochods.FirstOrDefault(s => s.IdSamochodu == zlec.IdSamochodu);
                        var result = MessageBox.Show("Czy na pewno chcesz usunąć zlecenie ID:" + zlec.IdZlecenia +
                            "\nNa dane Imie:" + kli.Imie + " Marka:" + sam.Marka + " VIN:" + sam.NumerVIN, "Czy jesteś pewny?!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            foreach (var item in zlec.Uslugas)
                            {
                                zlec.Uslugas.Remove(item);
                            }
                            context.Zlecenies.Remove(zlec);
                        }
                    }
                }
            }
        }
    }
}
