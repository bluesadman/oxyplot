﻿using System.Windows;
using OxyPlot.Wpf;

namespace AreaDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            DataContext = vm;

            //foreach (DataPointSeries s in plot1.Series)
            //    s.ItemsSource = vm.Measurements;
        }
    }
}