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

namespace Primera_Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //.....................................
            Grid g = new Grid();
            this.Content = g;
            //.....................................
            Button b = new Button();

            b.Width = 150;
            b.Height = 75;
            b.Background = Brushes.Blue;

            //.....................................
            WrapPanel wp = new WrapPanel();

            //.....................................
            TextBlock txt1 = new TextBlock();
            txt1.Background = Brushes.Red;
            txt1.Foreground = Brushes.Violet;
            txt1.Text = "Click";
            wp.Children.Add(txt1);


            TextBlock txt2 = new TextBlock();
            txt2.Text = "Enviar";
            wp.Children.Add(txt2);

            //....................................
            b.Content = wp;


            g.Children.Add(b);
        }
    }
}
