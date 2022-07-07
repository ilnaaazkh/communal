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
    /// Логика взаимодействия для ZkhKHPayment.xaml
    /// </summary>
    public partial class ZkhKHPayment : Window
    {
        public ZkhKHPayment()
        {
            InitializeComponent();
        }

        private void backToChoice_Click(object sender, RoutedEventArgs e)
        {
            ServChoice servChoice = new ServChoice();
            servChoice.Show();
            this.Close();
        }

        private void toStartPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ZKHnum_Click(object sender, RoutedEventArgs e)
        {
            ZKHNumOfBill zKHNumOfBill = new ZKHNumOfBill(); 
            zKHNumOfBill.Show();
            this.Close();
        }

        private void toBill_Click(object sender, RoutedEventArgs e)
        {
            ZKHbill zKHbill = new ZKHbill();    
            zKHbill.Show();
            this.Close();
        }
    }
}
