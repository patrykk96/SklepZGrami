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
            }
            else MessageBox.Show("Haslo jest nie poprawne, spróbuj ponownie.", "Niepoprawne hasło");
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
                
            
                
            }
             catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Błąd");
            }
        }

        
    }
}
