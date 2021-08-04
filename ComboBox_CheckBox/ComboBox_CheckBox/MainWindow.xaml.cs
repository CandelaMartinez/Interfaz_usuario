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

namespace ComboBox_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogota" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "DF" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitaless.ItemsSource = ListaCapitales;


        }

        public class Capitales
        {
            public string NombreCapital { get; set; }
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            //pulso TodasC y se activan todas las casillas
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;

        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            //pulso TodasC y se desactivan todas las casillas
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            DF.IsChecked = false;
            Santiago.IsChecked = false;

        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            //si estan todas activadas se activa el TodasC
            if (Madrid.IsChecked==true && Bogota.IsChecked==true && Lima.IsChecked==true && DF.IsChecked==true && Santiago.IsChecked==true)
            {
                TodasC.IsChecked = true;
            }
            else
            {
                //sino, es null, cuadrado pintado
                TodasC.IsChecked = null;
            }
        }

        private void IndividualNoChecked(object sender, RoutedEventArgs e)
        {
            //si estan todas activadas se activa el TodasC
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && DF.IsChecked == false && Santiago.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                //sino, es null, cuadrado pintado
                TodasC.IsChecked = null;
            }
        }
    }
}
