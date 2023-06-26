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
    public partial class WybieranieDaty : Form
    {
        public ZleceniaOtwartePage otwarte;
        public ZleceniaZamknietePage zamkniete;
        public WybieranieDaty(ZleceniaZamknietePage form)
        {
            zamkniete = form;
            otwarte = null;
            InitializeComponent();
        }
        public WybieranieDaty(ZleceniaOtwartePage form)
        {
            otwarte = form;
            zamkniete = null;
            InitializeComponent();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (otwarte != null)
            {
                Properties.Settings.Default.LastDowolnaToDo = monthCalendar1.SelectionStart;
                Properties.Settings.Default.LastTimeToDo = "Dowolna data";
            }
            if (zamkniete != null)
            {
                Properties.Settings.Default.LastDowolnaDone = monthCalendar1.SelectionStart;
                Properties.Settings.Default.LastTimeDone = "Dowolna data";
            }

            DialogResult result =MessageBox.Show("Czy chcesz wybrać date " + monthCalendar1.SelectionStart.ToString("d"), "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
