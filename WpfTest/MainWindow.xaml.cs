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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private SettingInfo vm = new SettingInfo();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SubWindow sw = new SubWindow();
            sw.DataContext = vm;
            sw.Show();
        }
    }
}
