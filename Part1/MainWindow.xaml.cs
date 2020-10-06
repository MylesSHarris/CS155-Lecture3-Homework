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

namespace Part1
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

        double annualInterest = 0.0639;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double monthlyPayment = Double.Parse(monthlyPaymentText.Text);
            double outstandingBalance = Double.Parse(outstandingBalanceText.Text);

            double monthlyInterest = annualInterest / 12;
            double interestPayment = monthlyInterest * outstandingBalance;

            double principalPayment = monthlyPayment - interestPayment;

            MessageBox.Show("You must pay $" + Math.Round(interestPayment, 2) + " to interest and $" + Math.Round(principalPayment, 2) + " to principal.");
        }
    }
}
