using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SklepZGrami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pracownik asortyment = new Pracownik();
        
        private Klient klient = new Klient();
        private List<Gra> pomoc = new List<Gra>();
        
        public MainWindow()
        {
            InitializeComponent();
            labelHaslo.Visibility = Visibility.Hidden;
            passwordBoxPracownik.Visibility = Visibility.Hidden;
            buttonZaloguj.Visibility = Visibility.Hidden;
            panelStronaPowitalna.Visibility = Visibility.Visible;
            panelPracownika.Visibility = Visibility.Hidden;
            panelDodajGreWideo.Visibility = Visibility.Hidden;
            panelDodajGrePlanszowa.Visibility = Visibility.Hidden;
            panelKlienta.Visibility = Visibility.Hidden;

            asortyment.DomyslneProdukty();
            
        }

        private void buttonPracownik_Click(object sender, RoutedEventArgs e)
        {
            labelHaslo.Visibility = Visibility.Visible;
            passwordBoxPracownik.Visibility = Visibility.Visible;
            buttonZaloguj.Visibility = Visibility.Visible;

        }

        private void buttonZaloguj_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBoxPracownik.Password.ToString() == "tajnehaslo")
            {
                panelStronaPowitalna.Visibility = Visibility.Hidden;
                panelPracownika.Visibility = Visibility.Visible;
                panelKlienta.Visibility = Visibility.Hidden;
                panelDodajGreWideo.Visibility = Visibility.Hidden;
                panelDodajGrePlanszowa.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Haslo jest nie poprawne, spróbuj ponownie.", "Niepoprawne hasło");
                passwordBoxPracownik.Clear();
            }
        }

        private void buttonGraWideo_Click(object sender, RoutedEventArgs e)
        {
            panelDodajGreWideo.Visibility = Visibility.Visible;
            panelDodajGrePlanszowa.Visibility = Visibility.Hidden;
        }

        private void buttonDodajGreWideo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cena = Convert.ToDouble(textBoxCenaGraWideo.Text);
                if (cena <= 0) throw new ArgumentOutOfRangeException();
                int ograniczenie = Convert.ToInt32(textBoxOgraniczenieGraWideo.Text);
                if (ograniczenie <= 0) throw new ArgumentOutOfRangeException();
                asortyment.DodajGreWideo(textBoxNazwaGraWideo.Text, cena, textBoxGatunekGraWideo.Text, ograniczenie, textBoxPlatforma.Text);
                listBoxProdukty.Items.Clear();
                foreach (string nazwaGry in asortyment.PobierzNazwy())
                    listBoxProdukty.Items.Add(nazwaGry);
            }
            
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Błąd");
            }
        }

        private void buttonGraPlanszowa_Click(object sender, RoutedEventArgs e)
        {
            panelDodajGreWideo.Visibility = Visibility.Hidden;
            panelDodajGrePlanszowa.Visibility = Visibility.Visible;
        }

        private void buttonDodajGrePlanszowa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cena = Convert.ToDouble(textBoxCenaGraPlansz.Text);
                if (cena <= 0) throw new ArgumentOutOfRangeException();
                int ograniczenie = Convert.ToInt32(textBoxOgraniczenieGraPlansz.Text);
                if (ograniczenie <= 0) throw new ArgumentOutOfRangeException();
                int minOsob = Convert.ToInt32(textBoxMinOsob.Text);
                if (minOsob <= 0) throw new ArgumentOutOfRangeException();
                int maxOsob = Convert.ToInt32(textBoxMaxOsob.Text);
                if (maxOsob <= 0) throw new ArgumentOutOfRangeException();
                asortyment.DodajGrePlanszowa(textBoxNazwaGraPlansz.Text, cena, textBoxGatunekGraPlansz.Text, ograniczenie, minOsob, maxOsob);
                listBoxProdukty.Items.Clear();
                foreach (string nazwaGry in asortyment.PobierzNazwy())
                    listBoxProdukty.Items.Add(nazwaGry);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Błąd");
            }
        }

        private void buttonKlient_Click(object sender, RoutedEventArgs e)
        {
            panelKlienta.Visibility = Visibility.Visible;
            panelStronaPowitalna.Visibility = Visibility.Hidden;
            panelPracownika.Visibility = Visibility.Hidden;
            pomoc = asortyment.ZwrocListe();
            klient.KopiowanieListyGier(pomoc);

            foreach (string nazwaGry in klient.PobierzNazwy())
                listBoxListaProduktowKlient.Items.Add(nazwaGry);
        }

        private void buttonWrocDoMenuPracownik_Click(object sender, RoutedEventArgs e)
        {
            panelStronaPowitalna.Visibility = Visibility.Visible;
            panelPracownika.Visibility = Visibility.Hidden;
            panelPracownika.Visibility = Visibility.Hidden;
            labelHaslo.Visibility = Visibility.Hidden;
            passwordBoxPracownik.Visibility = Visibility.Hidden;
            buttonZaloguj.Visibility = Visibility.Hidden;
            passwordBoxPracownik.Clear();

        }

        private void buttonPowrotDoMenuKlient_Click(object sender, RoutedEventArgs e)
        {
            panelStronaPowitalna.Visibility = Visibility.Visible;
            panelPracownika.Visibility = Visibility.Hidden;
            panelKlienta.Visibility = Visibility.Hidden;
            labelHaslo.Visibility = Visibility.Hidden;
            passwordBoxPracownik.Visibility = Visibility.Hidden;
            buttonZaloguj.Visibility = Visibility.Hidden;
            passwordBoxPracownik.Clear();
        }

        private void buttonPrzeniesDoKoszyka_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxListaProduktowKlient.SelectedIndex == -1) MessageBox.Show("Nie wybrano produktu", "Błąd");
            else if (listBoxListaProduktowKlient.SelectedIndex >= 0)
            {
                if (klient.PoliczProdukty() > 0)
                {
                    klient.DodajDoKoszyka(klient.GraDoPrzeniesienia(listBoxListaProduktowKlient.SelectedIndex));
                }
            }
            AktualizujKoszyk();
            
        }

        public void AktualizujKoszyk()
        {
            listBoxKoszyk.Items.Clear();
            double koszt = 0;

            foreach (string nazwaGry in klient.PobierzNazwyDoKoszyka())
            {
                listBoxKoszyk.Items.Add(nazwaGry);
            }
            
            foreach (double cenaGry in klient.PobierzCenyDoKoszyka())
            {
                koszt += cenaGry;
            }

            labelKosztTekst.Content = koszt + "zł";
        }

        private void buttonUsunZKoszyka_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxKoszyk.SelectedIndex == -1) MessageBox.Show("Nie wybrano produktu do usunięcia z koszyka", "Błąd");
            else if (listBoxKoszyk.SelectedIndex >= 0)
            {
                if (klient.PoliczIloscWKoszyku() > 0)
                {
                    klient.UsunZKoszyka(klient.GraDoUsuniecia(listBoxKoszyk.SelectedIndex));
                }
            }
            AktualizujKoszyk();

        }

        private void buttonInfo_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxListaProduktowKlient.SelectedIndex == -1)
                MessageBox.Show("Nie wybrano produktu z listy, spróbuj ponownie", "Błąd");
            else if (listBoxListaProduktowKlient.SelectedIndex >= 0)
            {
                MessageBox.Show(klient.Informacje(listBoxListaProduktowKlient.SelectedIndex), "Informacje o produkcie");
            }
        }

        private void buttonWyczyscKoszyk_Click(object sender, RoutedEventArgs e)
        {
            if (klient.PoliczIloscWKoszyku() == 0) MessageBox.Show("Koszyk jest już pusty", "Błąd");
            else if (klient.PoliczIloscWKoszyku() > 0)
                {
                    klient.WyczyscListeKoszyk();
                }
            
            AktualizujKoszyk();
        }
    }
}
