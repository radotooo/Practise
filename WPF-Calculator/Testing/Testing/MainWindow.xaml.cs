﻿using System;
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
        private const string Zero = "0";
        private string firstnums = string.Empty;
        private  int numLengt = 16;
        private List<decimal> CalcCore;
        private string Operator; 

        public MainWindow()
        {
            this.CalcCore = new List<decimal>();
            InitializeComponent();
        }


        
        
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            ChekStringSize(firstnums,sender);
           
        }

        

        

        private void ClearEntry(object sender, RoutedEventArgs e)
        {
            firstnums = string.Empty;
            Result.Text = Zero;
        }

        private void ChekStringSize(string str, object sender)
        {
            if (str.Length < numLengt)
            {
                Button button = sender as Button;

                firstnums += button.Content;
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
            
            

        }
    }
}
