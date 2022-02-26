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

namespace WpfContenedores
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnScroll_Click(object sender, RoutedEventArgs e)
        {
            new WdnEjemploScrollViewer().Show();
        }

        private void bntBordes_Click(object sender, RoutedEventArgs e)
        {
            new WndBordes().Show();
        }

        private void btnExpander_Click(object sender, RoutedEventArgs e)
        {
            new WndExpander().Show();
        }
    }
}
