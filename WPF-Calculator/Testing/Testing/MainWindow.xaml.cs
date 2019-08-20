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

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
<<<<<<< HEAD
        private const string Zero = "0";
        private string firstnums = string.Empty;
        private  int numLengt = 16;
        private List<decimal> CalcCore;
        private string Operator; 

        public MainWindow()
        {
            this.CalcCore = new List<decimal>();
=======

        private string firstnums = string.Empty;
        public MainWindow()
        {
>>>>>>> f442ab49834bf2f24b3e2929dbebb84866455792
            InitializeComponent();
        }


<<<<<<< HEAD
        
        
        private void ButtonClick(object sender, RoutedEventArgs e)
=======

        
        private void numZero(object sender, RoutedEventArgs e)
>>>>>>> f442ab49834bf2f24b3e2929dbebb84866455792
        {
            ChekStringSize(firstnums,sender);
           
        }

<<<<<<< HEAD
        

        

        private void ClearEntry(object sender, RoutedEventArgs e)
        {
            firstnums = string.Empty;
            Result.Text = Zero;
        }

        private void ChekStringSize(string str, object sender)
        {
            if (str.Length < numLengt)
=======
        private void ChekStringSize(string str , object sender)
        {
            if (str.Length < 16)
>>>>>>> f442ab49834bf2f24b3e2929dbebb84866455792
            {
                Button button = sender as Button;

                firstnums += button.Content;
<<<<<<< HEAD
                Result.Text = firstnums;
            }

        }

        private void BackSpace(object sender, RoutedEventArgs e)
        {
            if(this.firstnums.Length > 0)
            {
                int currentLengt = firstnums.Length - 1;
                firstnums = firstnums.Substring(0, currentLengt);
                Result.Text = firstnums;
                
            }

            if (firstnums.Length == 0)
            {
                Result.Text = Zero;
            }

            

        }

        private void DecimalDot(object sender, RoutedEventArgs e)
        {
            if (!firstnums.Contains("."))
            {
                if (firstnums.Length == 16)
                {
                   
                    this.numLengt = 17;
                }
                firstnums += ".";
                Result.Text = firstnums;

            }

        }

        private void Operation(object sender, RoutedEventArgs e)
        {
            CalcCore.Add(decimal.Parse(firstnums));
            firstnums = string.Empty;
            
            

=======
                ResultRado.Text = firstnums;
            }
           
        }

        private void numOne(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numTwo(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numThree(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numFourth(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numFive(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numSix(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numSeven(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
        private void numEigth(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
        }
       
        private void numNine(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums, sender);
>>>>>>> f442ab49834bf2f24b3e2929dbebb84866455792
        }
    }
}
