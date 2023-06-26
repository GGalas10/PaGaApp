using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp.Pages
{
    public partial class StatystykaPage : Form
    {
        public static DateTime poczatek;
        public static DateTime koniec;
        public StatystykaPage()
        {
            InitializeComponent();
        }

        private void ZlecBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Zamkniecia >= DateTime.Today && z.Czyzakończone == true).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    foreach (var item in lista)
                    {
                        suma = 0;
                        foreach (var us in item.Uslugas)
                        {
                            suma += us.Cena;
                        }
                    }
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Suma za zlecenia=\n" + suma + " zł";
                    serier.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Ilość zleceń =\n" + lista.Count;
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                    Diagram.Series[0].Points.AddXY("Suma wszystkich zleceń", suma);
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void ZlecMSBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month,1);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Zamkniecia >= ms && z.Czyzakończone == true).ToList();
                if (lista.Count > 0)
                {
                    for (int i = 0; i < Math.Round((DateTime.Now - ms).TotalDays); i++)
                    {
                        double? suma = 0;
                        int count = 0;
                        foreach (var item in lista.Where(z => z.Data_Przyjecia == ms.AddDays(i)))
                        {
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia" + i;
                        serier.LegendText = ms.AddDays(i).ToString("d");
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i + 1, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń" + i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.Points.AddXY(i + 1, count);
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void Zlec3mBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month, DateTime.Now.Day);
            ms = sprawdzanieDaty(ms,2);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Zamkniecia >= ms && z.Czyzakończone == true).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    int count = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        suma = 0;
                        count = 0;
                        foreach (var item in lista.Where(z => z.Data_Zamkniecia >= ms.AddMonths(i) && z.Data_Zamkniecia< ms.AddMonths(i+1)))
                        {

                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia" + i;
                        serier.LegendText = ms.AddMonths(i).ToString("MMMM")+"| "+suma+" zł";
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i+1, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń" + i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.Points.AddXY(i+1, count);
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void ZlecRBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month, DateTime.Now.Day);
            ms =sprawdzanieDaty(ms, 11);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Zamkniecia >= ms && z.Czyzakończone == true).ToList();               
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    int count = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        suma = 0;
                        count = 0;
                        foreach (var item in lista.Where(z => z.Data_Przyjecia >= ms.AddMonths(i) && z.Data_Przyjecia < ms.AddMonths(i + 1)))
                        {
                            
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia" + i;
                        serier.LegendText = ms.AddMonths(i).ToString("MMMM")+"| "+suma+" zł";
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń" + i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Czyzakończone == true).ToList();
                if (lista.Count > 0)
                {
                    if (lista.Count > 0)
                    {
                        double? suma = 0;
                        foreach (var item in lista)
                        {
                            suma = 0;
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                            }
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia";
                        serier.LegendText = "Suma za zlecenia=\n" + suma + " zł";
                        serier.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń";
                        serc.LegendText = "Ilość zleceń = \n"+lista.Count;
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                        Diagram.Series[0].Points.AddXY("Suma wszystkich zleceń", suma);
                    }
                    else
                    {
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Brak";
                        serier.LegendText = "Brak";
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(1, 0);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                    }
                }
            }
        }

        private void KatBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                List<double> lista = new List<double>();

                for (int i = 1; i <= context.Kategorias.Count(); i++)
                {
                    double index = 0;
                    foreach (var item in context.Uslugas.Where(u => u.IdKategorii == i))
                    {
                        index++;
                    }
                    lista.Add(index);
                }
                System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                serier.Name = "Kategorie";
                serier.IsValueShownAsLabel = true;
                double allsuma = 0;
                foreach (int item in lista)
                {
                    allsuma += item;
                }
                for (int i = 0; i <= lista.Count() - 1; i++)
                {
                    if (lista[i] > 0)
                    {
                        serier.Points.AddXY(context.Kategorias.FirstOrDefault(k => k.IdKat == i + 1).Nazwa,Math.Round(((lista[i]/allsuma)*100),2));
                        serier.Points[serier.Points.Count()-1].Color = Color.FromArgb(rnd.Next(25,225), rnd.Next(25, 225), rnd.Next(25, 225));
                        
                    }
                }
                Diagram.Series.Add(serier);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                
                for (int i = 1; i <= context.Kategorias.Count(); i++)
                {
                    double index = 0;
                    foreach (var item in context.Uslugas.Where(u => u.IdKategorii == i))
                    {
                        index++;
                    }
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = context.Kategorias.FirstOrDefault(k => k.IdKat == i).Nazwa;
                    serier.IsValueShownAsLabel = true;
                    serier.LegendText = context.Kategorias.FirstOrDefault(k => k.IdKat == i).Nazwa;
                    serier.Points.AddXY(i, index);
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void ZlecWybBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            StatystykaWybranaData data = new StatystykaWybranaData();
            data.ShowDialog();
            using (PaGaContext context = new PaGaContext())
            {
                double suma = 0;
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Czyzakończone == true && z.Data_Zamkniecia>=poczatek && z.Data_Zamkniecia<=koniec).ToList();
                foreach (var item in lista)
                {
                    suma += (double)item.Koszt_Zlecenia;
                }
                if (lista.Count <= 0)
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY("Suma wszystkich zleceń", 0);
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Brak";
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Suma za zlecenia=\n" + suma + " zł";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY("Suma wszystkich zleceń", suma);
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Ilość zleceń =\n" + lista.Count;
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                }
            }

        }

        private void WszOtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Czyzakończone == false).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    foreach (var item in lista)
                    {
                        foreach (var us in item.Uslugas)
                        {
                            suma += us.Cena;
                        }

                    }
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Suma za zlecenia =\n"+suma+" zł";
                    serier.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Ilość zleceń =\n"+lista.Count;
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                    Diagram.Series[0].Points.AddXY("Suma wszystkich zleceń", suma);

                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void ToOtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Przyjecia >= DateTime.Today && z.Czyzakończone == false).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    foreach (var item in lista)
                    {
                        suma = 0;
                        foreach (var us in item.Uslugas)
                        {
                            suma += us.Cena;
                        }
                    }
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Suma za zlecenia = \n"+suma+" zł";
                    serier.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Ilość zleceń = \n"+ lista.Count;
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                    Diagram.Series[0].Points.AddXY("Suma wszystkich zleceń", suma);
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void MsOtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month,1);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Przyjecia >= ms && z.Czyzakończone == false).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    int count = 0;

                    for (int i = 0; i < Math.Round((DateTime.Now-ms).TotalDays); i++)
                    {
                        suma = 0;
                        count = 0;
                        foreach (var item in lista.Where(z => z.Data_Przyjecia == ms.AddDays(i)))
                        {
                            
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia"+i;
                        serier.LegendText = ms.AddDays(i).ToString("d");
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i+1, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń "+i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void Ms3OtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month, DateTime.Now.Day);
            ms = sprawdzanieDaty(ms,2);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Przyjecia >= ms && z.Czyzakończone == false).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    int count = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        suma = 0;
                        count = 0;
                        foreach (var item in lista.Where(z => z.Data_Przyjecia >= ms.AddMonths(i) && z.Data_Przyjecia < ms.AddMonths(i + 1)))
                        {
                            
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia" + i;
                        serier.LegendText = ms.AddMonths(i).ToString("MMMM")+"| " +suma +" zł";
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i + 1, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń " + i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void ROtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            DateTime ms = new DateTime(DateTime.Today.Year, DateTime.Now.Month, DateTime.Now.Day);
            ms = sprawdzanieDaty(ms, 11);
            using (PaGaContext context = new PaGaContext())
            {
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Data_Przyjecia >= ms && z.Czyzakończone == false).ToList();
                if (lista.Count > 0)
                {
                    double? suma = 0;
                    int count = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        suma = 0;
                        count = 0;
                        foreach (var item in lista.Where(z => z.Data_Przyjecia >= ms.AddMonths(i) && z.Data_Przyjecia < ms.AddMonths(i + 1)))
                        {
                            
                            foreach (var us in item.Uslugas)
                            {
                                suma += us.Cena;
                                
                            }
                            count++;
                        }
                        System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serier.Name = "Suma za zlecenia" + i;
                        serier.LegendText = ms.AddMonths(i).ToString("MMMM")+"| "+suma+" zł";
                        serier.IsValueShownAsLabel = true;
                        serier.Points.AddXY(i, suma);
                        serier.ChartArea = "ChartArea1";
                        Diagram.Series.Add(serier);
                        System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                        serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        serc.Name = "Ilość zleceń" + i;
                        serc.LegendText = "Ilość zleceń " + count;
                        serc.IsValueShownAsLabel = true;
                        Diagram.Series.Add(serc);
                    }
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Brak";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY(1, 0);
                    serier.ChartArea = "ChartArea1";
                    Diagram.Series.Add(serier);
                }
            }
        }

        private void StatystykaPage_Load(object sender, EventArgs e)
        {
            poczatek =DateTime.Now;
            koniec = DateTime.Now;
        }

        private void WybOtwBtn_Click(object sender, EventArgs e)
        {
            Diagram.Series.Clear();
            StatystykaWybranaData data = new StatystykaWybranaData();
            data.ShowDialog();
            using (PaGaContext context = new PaGaContext())
            {
                double suma = 0;
                List<Zlecenie> lista = context.Zlecenies.Where(z => z.Czyzakończone == false && z.Data_Przyjecia >= poczatek && z.Data_Przyjecia <= koniec).ToList();
                foreach (var item in lista)
                {
                    suma += (double)item.Koszt_Zlecenia;
                }
                if (lista.Count <= 0)
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Brak";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY("Suma wszystkich zleceń", 0);
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Brak";
                    serc.IsValueShownAsLabel = true;
                }
                else
                {
                    System.Windows.Forms.DataVisualization.Charting.Series serier = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serier.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serier.Name = "Suma za zlecenia";
                    serier.LegendText = "Suma za zlecenia=\n" + suma + " zł";
                    serier.IsValueShownAsLabel = true;
                    serier.Points.AddXY("Suma wszystkich zleceń", suma);
                    Diagram.Series.Add(serier);
                    System.Windows.Forms.DataVisualization.Charting.Series serc = new System.Windows.Forms.DataVisualization.Charting.Series();
                    serc.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serc.Name = "Ilość zleceń";
                    serc.LegendText = "Ilość zleceń = \n" + lista.Count;
                    serc.IsValueShownAsLabel = true;
                    Diagram.Series.Add(serc);
                }
            }
        }
        private DateTime sprawdzanieDaty(DateTime data,int ile)
        {
            DateTime prawidłowa;
            int miesiace = data.Month;
            if(miesiace - ile < 1)
            {
                miesiace = miesiace + 12;
                prawidłowa = new DateTime(data.Year - 1, miesiace-ile, 1);
                return prawidłowa;
            }
            return new DateTime(data.Year,data.Month-2,1);
        }
    }
}
