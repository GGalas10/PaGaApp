using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp
{
    static class Program
    {
        public static Pracownik pracownik;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PaGaApp.PaGaLogin());
            }
            catch(Exception ex)
            {
                using(PaGaContext context = new PaGaContext())
                {
                    Logi log = new Logi();
                    log.TextLog = ex.Message.ToString();
                    if(pracownik != null)
                    {
                        log.Pracownik = pracownik;
                    }
                    log.Data = DateTime.Now;
                    context.Logis.Add(log);
                    MessageBox.Show("Jest błąd");
                    context.SaveChanges();
                }
            }
        }
    }
}
