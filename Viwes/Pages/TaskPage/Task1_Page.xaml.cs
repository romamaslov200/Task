using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
using Task.Models;

namespace Task.Viwes.Pages.TaskPage
{
    /// <summary>
    /// Логика взаимодействия для Task1_Page.xaml
    /// </summary>
    public partial class Task1_Page : Page
    {
        ClassSwich classSwich = new ClassSwich();
        
        int SelectRadioID;


        public Task1_Page()
        {
            InitializeComponent();
            TextBlock1.Text = SelectRadioID.ToString();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            start();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Логика для отображения выбранного значения int
            SelectRadioID = (sender as RadioButton)?.Tag != null ? int.Parse((sender as RadioButton).Tag.ToString()) : 0;
            TextBlock1.Text = $"{(sender as RadioButton).Content}";

            //TextBlock1.Text = $"Выбранный вариант: {SelectRadioID}";
        }


        private void home_Button_Click(object sender, RoutedEventArgs e)
        {
            NavArcCore.ChageFrame(new Home_Page());
        }

        private void pags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) { start(); }
        }

        private void start()
        {
            //int result;

            classSwich.Swich(SelectRadioID, NavArcCore.MainFrame.Content as Page);
        }
    }
}
