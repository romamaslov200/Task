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
using Task.Core;
using Task.Viwes.Pages.TaskPage;

namespace Task.Viwes.Pages
{
    /// <summary>
    /// Логика взаимодействия для Home_Page.xaml
    /// </summary>
    public partial class Home_Page : Page
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {
            NavArcCore.ChageFrame(new Settings_Page());
        }

        private void Task1_Button_Click(Object sender, RoutedEventArgs e) { NavArcCore.ChageFrame(new Task1_Page()); }
    }
}
