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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        

        
        public void katclear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nazwa", "Nazwa");
            using (PaGaContext context = new PaGaContext())
            {
                foreach (var item in context.Kategorias)
                {
                    dataGridView1.Rows.Add(item.IdKat, item.Nazwa);
                }
            }
        }
        public void Uzclear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Imie", "Imie");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Login", "Login");
            using (PaGaContext context = new PaGaContext())
            {
                foreach(var item in context.Pracowniks)
                {
                    dataGridView1.Rows.Add(item.IdPracownika, item.Imie,item.Nazwisko,item.Login);
                }
            }

        }
        public void LogClear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Pracownik", "Pracownik");
            dataGridView1.Columns.Add("Data", "Data");
            dataGridView1.Columns.Add("Text", "Text");
            using (PaGaContext context = new PaGaContext())
            {
                foreach (var item in context.Logis)
                {
                    Pracownik prac = context.Pracowniks.FirstOrDefault(p => p.IdPracownika == item.IdPracownika);
                    dataGridView1.Rows.Add(item.IdLog, prac.Login, item.Data, item.TextLog);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DodawanieUzytkownika addacc = new DodawanieUzytkownika();
            addacc.ShowDialog();
            Uzclear();
            DelBtn.Visible = true;
            TitleLbl.Text = "Pracownicy";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Kategorie";
            DelBtn.Visible = true;
            katclear();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Pracownicy";
            DelBtn.Visible = true;
            Uzclear();
        }

        private void LogiBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Logi";
            DelBtn.Visible = false;
            LogClear();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            TitleLbl.Text = "Wybierz dane";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DodawanieKategorii addkat = new DodawanieKategorii();
            addkat.ShowDialog();
            katclear();
            DelBtn.Visible = true;
            TitleLbl.Text = "Kategorie";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            if (dataGridView1.SelectedRows[0] != null)
            {
                using (PaGaContext context = new PaGaContext())
                {
                    DataGridViewRow selrow = dataGridView1.SelectedRows[0];
                    int index = int.Parse(selrow.Cells[0].Value.ToString());
                    switch (TitleLbl.Text)
                    {
                        case "Pracownicy":
                            Pracownik prac = context.Pracowniks.FirstOrDefault(p => p.IdPracownika == index);
                            result = MessageBox.Show("Czy jesteś pewny, że chcesz usunąć użytkownika " + prac.Imie + " " + prac.Nazwisko + " ?\nZmiany są nieodwracalne", "Jesteś pewny?!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            if(result == DialogResult.Yes)
                            {
                                context.Pracowniks.Remove(prac);
                                context.SaveChanges();
                            }

                            Uzclear();
                            break;
                        case "Kategorie":
                            Kategoria kat = context.Kategorias.FirstOrDefault(k => k.IdKat == index);
                            result = MessageBox.Show("Czy jesteś pewny, że chcesz usunąć Kategorię " + kat.Nazwa+" ?\nZmiany są nieodwracalne", "Jesteś pewny?!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            if (result == DialogResult.Yes)
                            {
                                context.Kategorias.Remove(kat);
                                context.SaveChanges();
                            }
                            katclear();
                            break;
                    }
                }
            }
        }
    }
}
