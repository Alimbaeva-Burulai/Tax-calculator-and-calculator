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

namespace Tax_calculation
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

        private void Button_Calculate(object sender, RoutedEventArgs e)
        {
            string s = string.Empty;
            try
            {
                double income = double.Parse(txtIncome.Text);
                double tax = double.Parse(txttaxPercent.Text);
                double prepaid = double.Parse(txtPrepaid.Text);
                double result = income * tax / 100 - prepaid;
                if (result > 0)
                {
                    s = "Must pay more!" + result;
                }
                else if (result < 0)
                {
                    s = "Overpaid!" + (-result);
                }
                else
                    s = "All is okay!";

                MessageBox.Show(s);
                lblResult.Content = s;
            }catch(FormatException)
            {
                MessageBox.Show("Not a number!");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Too big number");
            }
        }
    }
}
