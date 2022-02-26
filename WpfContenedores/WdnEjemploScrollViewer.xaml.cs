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
using System.Windows.Shapes;

namespace WpfContenedores
{
    /// <summary>
    /// Lógica de interacción para WdnEjemploScrollViewer.xaml
    /// </summary>
    public partial class WdnEjemploScrollViewer : Window
    {
        public WdnEjemploScrollViewer()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse()
            {
                Width =100,
                Height=100,
                Fill=Brushes.Red
            };
            staquito.Children.Add(ellipse);
        }
    }
}
