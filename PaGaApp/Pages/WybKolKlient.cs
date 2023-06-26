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
    public partial class WybKolKlient : Form
    {
        public List<string> listadoWyswietlenia;
        public List<string> listadoWyswietlenia2;
        public WybKolKlient()
        {
            listadoWyswietlenia = new List<string>();
            listadoWyswietlenia2 = new List<string>();
            InitializeComponent();
        }
        public void wyplenienie()
        {
            if (VisCol.Items.Count > 0)
            {
                VisCol.Items.Clear();
            }
            if (InVisCol.Items.Count > 0)
            {
                InVisCol.Items.Clear();
            }
            if (listadoWyswietlenia.Count == 0 && listadoWyswietlenia2.Count == 0)
            {
                if (Properties.Settings.Default.Col1Klient.Count > 0)
                {
                    foreach (var item in Properties.Settings.Default.Col1Klient)
                    {
                        listadoWyswietlenia.Add(item);
                        VisCol.Items.Add(listadoWyswietlenia[listadoWyswietlenia.IndexOf(item)]);
                    }
                }
                else
                {
                    if (Properties.Settings.Default.Col2Klient.Count == 0)
                    {
                        foreach (var item in Properties.Settings.Default.ColKlienci)
                        {
                            listadoWyswietlenia.Add(item);
                            VisCol.Items.Add(listadoWyswietlenia[listadoWyswietlenia.IndexOf(item)]);
                        }
                    }
                }
                if (Properties.Settings.Default.Col2Klient.Count > 0)
                {
                    foreach (var item in Properties.Settings.Default.Col2Klient)
                    {
                        listadoWyswietlenia2.Add(item);
                        InVisCol.Items.Add(listadoWyswietlenia2[listadoWyswietlenia2.IndexOf(item)]);
                    }
                }
            }
            else
            {
                foreach (var item in Properties.Settings.Default.ColKlienci)
                {
                    if (listadoWyswietlenia.Contains(item))
                    {
                        VisCol.Items.Add(item);
                    }
                }
                foreach (var item in Properties.Settings.Default.ColKlienci)
                {
                    if (listadoWyswietlenia2.Contains(item))
                    {
                        InVisCol.Items.Add(item);
                    }
                }
            }
        }
        private void WybKolOtwarte_Load(object sender, EventArgs e)
        {
            wyplenienie();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if(VisCol.SelectedItem != null)
            {
                listadoWyswietlenia2.Add(listadoWyswietlenia[listadoWyswietlenia.IndexOf(VisCol.SelectedItem.ToString())]);
                listadoWyswietlenia.Remove(VisCol.SelectedItem.ToString());
                
            }
            wyplenienie();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (InVisCol.SelectedItem != null)
            {
                listadoWyswietlenia.Add(listadoWyswietlenia2[listadoWyswietlenia2.IndexOf(InVisCol.SelectedItem.ToString())]);
                listadoWyswietlenia2.Remove(InVisCol.SelectedItem.ToString());
                
            }
            wyplenienie();
        }

        private void WybKolOtwarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Collections.Specialized.StringCollection col1 = new System.Collections.Specialized.StringCollection();
            System.Collections.Specialized.StringCollection col2 = new System.Collections.Specialized.StringCollection();
            foreach (var item in Properties.Settings.Default.ColKlienci)
            {
                if (listadoWyswietlenia.Contains(item))
                {
                    col1.Add(item);
                }
            }
            foreach (var item in Properties.Settings.Default.ColKlienci)
            {
                if (listadoWyswietlenia2.Contains(item))
                {
                    col2.Add(item);
                }
            }
            if (Properties.Settings.Default.Col1Klient.Count>0)
                Properties.Settings.Default.Col1Klient.Clear();
            if (Properties.Settings.Default.Col2Klient.Count>0)
                Properties.Settings.Default.Col2Klient.Clear();
            Properties.Settings.Default.Col1Klient = col1;
            Properties.Settings.Default.Col2Klient = col2;
            Properties.Settings.Default.Save();
        }
    }
}
