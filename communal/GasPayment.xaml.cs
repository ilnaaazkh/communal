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
    /// Логика взаимодействия для GasPayment.xaml
    /// </summary>
    public partial class GasPayment : Window
    {
        public GasPayment()
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

        private void ToGasNumOfBill_Click(object sender, RoutedEventArgs e)
        {
            GasNumOfBill gasNumOfBill = new GasNumOfBill();
            gasNumOfBill.Show();
            this.Close();
        }

        private void QRc_Click(object sender, RoutedEventArgs e)
        {
            GasBill gasBill = new GasBill();
            gasBill.Show();
            this.Close();
        }
    }
}
