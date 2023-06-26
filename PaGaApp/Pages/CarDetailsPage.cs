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
    public partial class CarDetailsPage : Form
    {
        public Samochod result;
        public CarDetailsPage(Samochod car)
        {
            result = car;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MarkaBox.Text) || string.IsNullOrEmpty(ModelBox.Text) || string.IsNullOrEmpty(NrRejBox.Text) || string.IsNullOrEmpty(NrVINLbl.Text))
                {
                    MessageBox.Show("Należy podać wszystkie dane (* przy wymaganych)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (PaGaContext context = new PaGaContext())
                    {
                        var samochod = context.Samochods.FirstOrDefault(s => s.IdSamochodu == result.IdSamochodu);
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
                        if (context.SaveChanges() > 0)
                        {
                            this.Close();
                            MessageBox.Show("Samochód został zmieniony", "Dodano samochód", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nie wprowadzono żadnych zmian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Samochód nie został zmieniony ponieważ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SaveBtn.Visible == false)
            {
                MarkaBox.ReadOnly = false;
                ModelBox.ReadOnly = false;
                NrRejBox.ReadOnly = false;
                VinBox.ReadOnly = false;
                KmBox.ReadOnly = false;
                KwBox.ReadOnly = false;
                RocznikBox.ReadOnly = false;
                OpisBox.ReadOnly = false;
                SaveBtn.Visible = true;
            }
            else
            {
                MarkaBox.ReadOnly = true;
                ModelBox.ReadOnly = true;
                NrRejBox.ReadOnly = true;
                VinBox.ReadOnly = true;
                KmBox.ReadOnly = true;
                KwBox.ReadOnly = true;
                RocznikBox.ReadOnly = true;
                OpisBox.ReadOnly = true;
                SaveBtn.Visible = false;
            }
        }

        private void CarDetailsPage_Load(object sender, EventArgs e)
        {
            MarkaBox.Text = result.Marka;
            ModelBox.Text = result.Model;
            NrRejBox.Text = result.NumerRejestracyjny;
            VinBox.Text = result.NumerVIN;
            KmBox.Text = result.MocKM.ToString();
            KwBox.Text = result.MocKW.ToString();
            RocznikBox.Text = result.DataProdukcji.ToString();
            OpisBox.Text = result.Opis;
        }
    }
}
