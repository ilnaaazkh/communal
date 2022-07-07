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
    /// Логика взаимодействия для Paypal.xaml
    /// </summary>
    public partial class Paypal : Window
    {
        public Paypal()
        {
            InitializeComponent();
        }

        private void toStartPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void toCode_Click(object sender, RoutedEventArgs e)
        {
            PaypalCode paypalCode = new PaypalCode();
            paypalCode.Show();
            this.Close();
        }
    }
}
