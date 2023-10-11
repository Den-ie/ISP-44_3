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

namespace ISP_44_3
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

        private void Valer(object sender, RoutedEventArgs e)
        {
            text.Text = Convert.ToString(Antona.CalculateExpression());
        }

        private void Danill(object sender, RoutedEventArgs e)
        {
            text.Text = Convert.ToString(ClassKosov.Method());
        }

        public void Alnxx(object sender, RoutedEventArgs e)
        {
            text.Text = Convert.ToString(Sum.FindSum());
        }
    }
}
