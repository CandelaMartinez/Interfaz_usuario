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

namespace ListBoxPractica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones()
            {
                Poblacion1 = "Madrid",
                Poblacion2 = "Barcelona",
                Temperatura1 = 15,
                Temperatura2 = 17,
                DiferenciaT = 2
            }); ;

            listaPob.Add(new Poblaciones()
            {
                Poblacion1 = "Valencia",
                Poblacion2 = "Alicante",
                Temperatura1 = 19,
                Temperatura2 = 23,
                DiferenciaT = 4
            });
            listaPob.Add(new Poblaciones()
            {
                Poblacion1 = "Malaga",
                Poblacion2 = "Bilbao",
                Temperatura1 = 18,
                Temperatura2 = 25,
                DiferenciaT = 7
            });
            listaPob.Add(new Poblaciones()
            {
                Poblacion1 = "Sevilla",
                Poblacion2 = "Coruña",
                Temperatura1 = 10,
                Temperatura2 = 19,
                DiferenciaT = 9
            });

            //el contenido de listaPoblaciones es listaPob
            listaPoblaciones.ItemsSource = listaPob;
        }
        //se crea cuando en xaml creo Click, dentro lo que quiero que haga al click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null) { 
            MessageBox.Show
                    
                ((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " grados " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " grados"


                );
           }else
            {
                MessageBox.Show("selecciona primero un elemento");
            }
        }

        //se crea cuando en xaml creo un evento, dentro programo lo que quiero que haga al pasar el mouse
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show

                    ((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " grados " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " grados"


                    );
            }
            else
            {
                MessageBox.Show("selecciona primero un elemento");
            }
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaT { get; set; }
    }
}
