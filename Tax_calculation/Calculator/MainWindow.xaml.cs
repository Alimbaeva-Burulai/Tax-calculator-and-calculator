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

namespace Calculator
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

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            txtCurrnet.Text += (sender as Button).Content.ToString();
        }

        private void DecSepClick(object sender, RoutedEventArgs e)
        {
            string decSep = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (!txtCurrnet.Text.Contains(decSep))
            {
                txtCurrnet.Text += decSep;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            lblOper.Content = (sender as Button).Content.ToString();
            lblOp1.Content = txtCurrnet.Text;
            txtCurrnet.Text = "0";
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            lblOp2.Content = txtCurrnet.Text;

            try
            {
                double op1 = double.Parse(lblOp1.Content.ToString());
                double op2 = double.Parse(lblOp2.Content.ToString());
                switch (lblOper.Content)
                {
                    case "+": lblResult.Content = op1 + op2; break;
                    case "-": lblResult.Content = op1 - op2; break;
                    case "*": lblResult.Content = op1 * op2; break;
                    case "/": lblResult.Content = op1 / op2; break;
                    
                }
                txtCurrnet.Text = lblResult.Content.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Convert error");
            }
            catch(OverflowException)
            {
                MessageBox.Show("too big number");
            }
        }

        private void txtCurrnet_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // e.Handled = !char.IsDigit(e.Text[0]);
        }

        private void txtCurrnet_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.NumPad0 || e.Key > Key.NumPad9);
        }
    }
}
