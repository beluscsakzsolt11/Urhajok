using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Urhajok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public class Urhajoset
        {
            public string Nev { get; set; }
            public int Legenyseg { get; set; }
            public int MaxHatotav { get; set; }
            public int UzemanyagSzint { get; set; }
            public string Gyarto { get; set; }
            public string KuldetesStatusz { get; set; }
            public int InditasEve { get; set; }
            
            public Urhajoset(string Nev, int Legenyseg, int MaxHatotav, int UzemanyagSzint, string Gyarto, string KuldetesStatusz, int InditasEve)
            {
                this.Nev = Nev;
                this.Legenyseg = Legenyseg;
                this.MaxHatotav = MaxHatotav;
                this.UzemanyagSzint = UzemanyagSzint;
                this.Gyarto = Gyarto;
                this.KuldetesStatusz = KuldetesStatusz;
                this.InditasEve = InditasEve;
            }

        }
        List<Urhajoset> urhajok = new List<Urhajoset>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void adatbetolt_Click(object sender, RoutedEventArgs e)
        {
            urhajok.Clear();
            urhajok.Add(new Urhajoset("Falcon-9", 7, 550000, 87, "SpaceX", "Sikeres", 2020));
            urhajok.Add(new Urhajoset("Orion-X1", 4, 820000, 73, "NASA", "Folyamatban", 2023));
            urhajok.Add(new Urhajoset("StarRider", 12, 910000, 66, "Boeing", "Sikeres", 2019));
            urhajok.Add(new Urhajoset("SolarWind", 3, 300000, 92, "ESA", "Sikertelen", 2018));
            urhajok.Add(new Urhajoset("Galaxy-Cruiser", 18, 1200000, 54, "Blue Origin", "Sikeres", 2022));
            urhajok.Add(new Urhajoset("Nova-Prime", 10, 760000, 80, "Roscosmos", "Sikeres", 2017));
            urhajok.Add(new Urhajoset("Pioneer-VII", 6, 640000, 70, "NASA", "Folyamatban", 2024));
            urhajok.Add(new Urhajoset("Titan-Hawk", 14, 1050000, 48, "SpaceX", "Sikeres", 2021));
            urhajok.Add(new Urhajoset("CosmoJet", 5, 430000, 93, "JAXA", "Sikertelen", 2016));
            urhajok.Add(new Urhajoset("Nebula-FX", 11, 870000, 60, "ESA", "Sikeres", 2020));
            datagrid.ItemsSource = urhajok;
            datagrid.Items.Refresh();
        }

        private void hanyurhajo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ennyi űrhajó van: "+urhajok.Count());
        }
    }
}