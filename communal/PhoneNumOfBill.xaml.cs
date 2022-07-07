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
    /// Логика взаимодействия для PhoneNumOfBill.xaml
    /// </summary>
    public partial class PhoneNumOfBill : Window
    {
        public PhoneNumOfBill()
        {
            InitializeComponent();
        }
        private void backToChoice_Click(object sender, RoutedEventArgs e)
        {
            GasPayment gasPayment = new GasPayment();
            gasPayment.Show();
            this.Close();
        }

        private void toStartPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            PhoneBill phoneBill = new PhoneBill();  
            phoneBill.Show();
            this.Close();
        }
    }
}
