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
    /// Логика взаимодействия для GasNumOfBill.xaml
    /// </summary>
    public partial class GasNumOfBill : Window
    {
        public GasNumOfBill()
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
            GasBill gasBill = new GasBill();
            gasBill.Show();
            this.Close();
        }
    }
}
