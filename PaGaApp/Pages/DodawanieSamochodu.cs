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
    public partial class DodawanieSamochodu : Form
    {
        public List<Samochod> listCar;
        public DodawanieSamochodu(List<Samochod> lista)
        {
            listCar = lista;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MarkaBox.Text) || string.IsNullOrEmpty(ModelBox.Text) || string.IsNullOrEmpty(NrRejBox.Text) || string.IsNullOrEmpty(NrVINLbl.Text))
                {
                    MessageBox.Show("Należy podać wszystkie dane (* przy wymaganych)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Samochod samochod = new Samochod();
                    samochod.Marka = MarkaBox.Text.Trim();
                    samochod.Model = ModelBox.Text.Trim();
                    samochod.NumerRejestracyjny = NrRejBox.Text.Trim();
                    samochod.NumerVIN = VinBox.Text.Trim();
                    if (!string.IsNullOrEmpty(KmBox.Text.Trim()))
                        samochod.MocKM = int.Parse(KmBox.Text.Trim());
                    if (!string.IsNullOrEmpty(KwBox.Text.Trim()))
                        samochod.MocKW = int.Parse(KwBox.Text.Trim());
                    if (!string.IsNullOrEmpty(RocznikBox.Text.Trim()))
                        samochod.DataProdukcji = int.Parse(RocznikBox.Text.Trim());
                    samochod.Opis = OpisBox.Text;
                    listCar.Add(samochod);
                    this.Close();
                    MessageBox.Show("Samochód został dodany", "Dodano samochód", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Samochód nie został dodany ponieważ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
