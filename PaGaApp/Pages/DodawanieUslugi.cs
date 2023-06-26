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
    public partial class DodawanieUslugi : Form
    {
        List<Usluga> lista;
        public DodawanieUslugi(List<Usluga> uslugas)
        {
            lista = uslugas;
            InitializeComponent();
        }

        private void CenaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tekst = CenaBox.Text;
            if (tekst.Contains(','))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.Handled = true;
                }
                int dlugos = tekst.Count() - tekst.IndexOf(',');
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
             && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void CntBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrEmpty(CenaBox.Text))
            {
                if (comboBox1.SelectedItem != null)
                {
                    Usluga usl = new Usluga();
                    usl.Nazwa = NameBox.Text.Trim();
                    usl.Cena = Math.Round(double.Parse(CenaBox.Text.Trim()), 2);
                    string indexstr = comboBox1.SelectedItem.ToString();
                    int index = int.Parse(indexstr.Substring(0, indexstr.IndexOf(".")));
                    usl.IdKategorii = index;
                    lista.Add(usl);
                    NameBox.Text = string.Empty;
                    CenaBox.Text = string.Empty;
                    comboBox1.SelectedItem = string.Empty;
                }
                else
                {
                    MessageBox.Show("Należy wybrać kategorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Należy wypełnić wszystkie dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrEmpty(CenaBox.Text))
            {
                if (comboBox1.SelectedItem != null)
                {
                    Usluga usl = new Usluga();
                    usl.Nazwa = NameBox.Text.Trim();
                    usl.Cena = Math.Round(double.Parse(CenaBox.Text.Trim()), 2);
                    string indexstr = comboBox1.SelectedItem.ToString();
                    int index = int.Parse(indexstr.Substring(0, indexstr.IndexOf(".")));
                    usl.IdKategorii = index;
                    lista.Add(usl);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Należy wybrać kategorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Należy wypełnić wszystkie dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DodawanieUslugi_Load(object sender, EventArgs e)
        {
            using (PaGaContext context = new PaGaContext())
            {
                foreach (var item in context.Kategorias)
                {
                    comboBox1.Items.Add(item.IdKat + ". " + item.Nazwa);
                }
            }
        }
    }
}
