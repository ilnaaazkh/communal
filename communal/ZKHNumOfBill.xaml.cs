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
    /// Логика взаимодействия для ZKHNumOfBill.xaml
    /// </summary>
    public partial class ZKHNumOfBill : Window
    {
        public ZKHNumOfBill()
        {
            InitializeComponent();
        }
        private void backToChoice_Click(object sender, RoutedEventArgs e)
        {
            ZkhKHPayment zkhKHPayment = new ZkhKHPayment();
            zkhKHPayment.Show();
            this.Close();
        }

        private void toStartPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            ZKHbill zKHbill = new ZKHbill();
            zKHbill.Show();
            this.Close();
        }
    }
}
