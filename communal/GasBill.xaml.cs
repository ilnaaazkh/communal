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

namespace communal
{
    /// <summary>
    /// Логика взаимодействия для GasBill.xaml
    /// </summary>
    public partial class GasBill : Window
    {
        public GasBill()
        {
            InitializeComponent();
        }
        private void toStartPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void toPay_Click(object sender, RoutedEventArgs e)
        {
            Paypal paypal = new Paypal();
            paypal.Show();
            this.Close();
        }
    }
}
