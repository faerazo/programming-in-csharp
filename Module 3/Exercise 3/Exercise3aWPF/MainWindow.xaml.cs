// Code example
// Created by Ferhat Sevim, Oct 2022

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

namespace Exercise3a
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                name = name.ToUpper(); // Convert name to uppercase
                lblResult.Content = name;
            }
            else
            {
                MessageBox.Show("Please give your name!");
            }
        }
    }
}
