using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp
{
    public partial class PaGaHomePage : Form
    {
        public PaGaHomePage()
        {
            InitializeComponent();
        }

        private void PaGaHomePage_Load(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                TitleLbl.Text = "Witaj "+context.Pracowniks.Where(p=>p.IdPracownika == PaGaMenu.zal.IdPracownika).FirstOrDefault().Imie+" w PaGa Serivce\n" +
                    "Dzisiaj zostało przyjętych " + context.Zlecenies.Where(z=>z.Data_Przyjecia >=DateTime.Today).Count()+" zleceń\n" +
                    "Do zrobienia zostało "+ context.Zlecenies.Where(z => z.Czyzakończone==false).Count()+" zleceń\n" +
                    "Po więcej statystyk przejdź do menu statystyk";
            }
        }
    }
}
