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
    /// Логика взаимодействия для ServChoice.xaml
    /// </summary>
    public partial class ServChoice : Window
    {
        public ServChoice()
        {
            InitializeComponent();
        }

        private void Gas_Click(object sender, RoutedEventArgs e)
        {
            GasPayment gasPayment = new GasPayment();
            gasPayment.Show();
            this.Close();
        }

        private void ZhKH_Click(object sender, RoutedEventArgs e)
        {
            ZkhKHPayment zhKH_ = new ZkhKHPayment();
            zhKH_.Show();
            this.Close();
        }

        private void Phone_Click(object sender, RoutedEventArgs e)
        {
            PhonePayment phonePayment = new PhonePayment(); 
            phonePayment.Show();
            this.Close();
        }
    }
}
