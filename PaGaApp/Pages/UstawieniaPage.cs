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
    public partial class UstawieniaPage : Form
    {
        public UstawieniaPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                if (context.Logis.Where(p => p.IdPracownika == PaGaMenu.zal.IdPracownika).Count() >0){
                    foreach (var item in context.Logis.Where(p => p.IdPracownika == PaGaMenu.zal.IdPracownika))
                    {
                        dataGridView1.Rows.Add(item.IdLog, item.Data, item.TextLog);
                    }
                }
                else
                {
                    MessageBox.Show("Brak logów użytkownika", "Brak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void dodawanie()
        {
            using (PaGaContext context = new PaGaContext())
            {
                dataGridView1.Columns.Add("Id logu", "Id logu");
                dataGridView1.Columns.Add("Data logu", "Data logu");
                dataGridView1.Columns.Add("Komunikat", "Komunikat");
            }
        }

        private void UstawieniaPage_Load(object sender, EventArgs e)
        {
            dodawanie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZmianaHasla zmiana = new Pages.ZmianaHasla(Program.pracownik);
            zmiana.ShowDialog();

        }
    }
}
