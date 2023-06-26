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
    public partial class DodawanieKategorii : Form
    {
        public DodawanieKategorii()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(PaGaContext context = new PaGaContext())
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    Kategoria kat = new Kategoria();
                    kat.Nazwa = textBox1.Text;
                    context.Kategorias.Add(kat);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Kategoria została dodana", "Dodano nową kategorię", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kategoria nie została dodana. Błąd bazy danych", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Brak wprowadzonej nazwy", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
