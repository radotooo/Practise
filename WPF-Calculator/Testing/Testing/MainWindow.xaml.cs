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

        private string firstnums = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }



        
        private void numZero(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums,sender);
           
        }

        private void ChekStringSize(string str , object sender)
        {
            if (str.Length < 16)
            {
                Button button = sender as Button;

                firstnums += button.Content;
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
        }
    }
}
