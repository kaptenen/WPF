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

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedoperator;
        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += AcButton_Click;
            negativeBotton.Click += NegativeBotton_Click;
            percentButton.Click += PercentButton_Click;
            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;

            if (double.TryParse(displayLabel.Content.ToString(), out newNumber))
            {
                switch (selectedoperator)
                {
                    case SelectedOperator.Multiplication:
                        result = PerformMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Addition:
                        result = PerformMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = PerformMath.Sub(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                            result = PerformMath.Divide(lastNumber, newNumber);
                        break;
                }
                displayLabel.Content = result.ToString();

            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            displayLabel.Content = "0";
        }

        private void NegativeBotton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(displayLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                displayLabel.Content = lastNumber.ToString();
            }
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(displayLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                displayLabel.Content = lastNumber.ToString();
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int buttonValue = 0;

            if (sender == zeroButton)
            {
                buttonValue = 0;
            }
            if (sender == oneButton)
            {
                buttonValue = 1;
            }
            if (sender == twoButton)
            {
                buttonValue = 2;
            }
            if (sender == ThreeButton)
            {
                buttonValue = 3;
            }
            if (sender == fourButton)
            {
                buttonValue = 4;
            }
            if (sender == fiveButton)
            {
                buttonValue = 5;
            }
            if (sender == sixButton)
            {
                buttonValue = 6;
            }
            if (sender == sevenButton)
            {
                buttonValue = 7;
            }
            if (sender == eightButton)
            {
                buttonValue = 8;
            }
            if (sender == nineButton)
            {
                buttonValue = 9;
            }

            if (displayLabel.Content.ToString() == "0")
            {
                displayLabel.Content = $"{buttonValue}";
            }
            else
            {
                displayLabel.Content = $"{displayLabel.Content}{buttonValue}";
            }

        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayLabel.Content.ToString().Contains(","))
            {

            }
            else
            {

                displayLabel.Content = $"{displayLabel.Content},";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(displayLabel.Content.ToString(), out lastNumber))
            {
                displayLabel.Content = "0";
            }

            if (sender == multiplyingButton)
            {
                selectedoperator = SelectedOperator.Multiplication;
            }
            if (sender == divideButton)
            {
                selectedoperator = SelectedOperator.Division;
            }
            if (sender == addButton)
            {
                selectedoperator = SelectedOperator.Addition;
            }
            if (sender == minusButton)
            {
                selectedoperator = SelectedOperator.Subtraction;
            }
        }

    }
    public enum SelectedOperator
    {
        Multiplication,
        Addition,
        Subtraction,
        Division
    }
}
