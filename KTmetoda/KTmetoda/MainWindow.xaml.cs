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

namespace KTmetoda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> parametriList;
        public MainWindow()
        {
            InitializeComponent();
            parametriList = new List<string>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string g = parametri.Text + "," + teza.Text;
            parametriList.Add(g);
            parametri.Text = "";
            teza.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            alternative bb = new alternative(parametriList);
            bb.ShowDialog();
        }
    }
}
