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
    /// Lógica de interacción para WndBordes.xaml
    /// </summary>
    public partial class WndBordes : Window
    {
        public WndBordes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            colorBorde.Items.Add(Brushes.Black);
            colorBorde.Items.Add(Brushes.Red);
            colorBorde.Items.Add(Brushes.Lavender);
            colorBorde.Items.Add(Brushes.Maroon);
        }
    }
}
