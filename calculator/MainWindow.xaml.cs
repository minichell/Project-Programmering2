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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double num1;
        string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButtom_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Click)
            {
                switch (Click.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":

                        InOutField.Text += Click.Content;
                        break;
                    default:
                        break;
                }
            }
        }
        private void AllClearButtom_Click(object sender, RoutedEventArgs e)
        {
            InOutField.Text = string.Empty;
        }
        private void ClearButtom_Click(object sender, RoutedEventArgs e)
        {

            if (InOutField.Text.Length > 0)
            {
                InOutField.Text = InOutField.Text.Substring(0, InOutField.Text.Length - 1);
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(InOutField.Text);
            InOutField.Text = "";
            operation = "+";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(InOutField.Text);
            InOutField.Text = "";
            operation = "-";
        }
        private void Multy_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(InOutField.Text);
            InOutField.Text = "";
            operation = "x";
        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(InOutField.Text);
            InOutField.Text = "";
            operation = "/";
        }
        private void dot_Click(object sender, RoutedEventArgs e)
        {
            InOutField.Text = InOutField.Text + ",";
        }
        private void procent_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(InOutField.Text);
            operation = "%";
            double procent;

            if (operation == "%")
            {
                procent = (num1 / 100);
                InOutField.Text = Convert.ToString(procent);
                num1 = procent;
            }
        }

    }
}
