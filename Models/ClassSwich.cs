using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Task.Models
{
    class ClassSwich
    {
        TaskCommand taskCommand = new TaskCommand();

        public Page _page;

        TextBlock TextBlock1;
        RadioButton ActiveOption;

        public void Swich(int i, Page page)
        {
            //TextBlock1 = FindElement<TextBlock>("TextBlock1", page);
            //ActiveOption = FindActiveRadioButton<RadioButton>("Options", page);
            
            switch (i)
            {
                case 1:
                    //TextBlock1.Text = $"{ActiveOption.Content}";
                    taskCommand.task1(page);
                    break;
                case 2:
                    taskCommand.task2(page);
                    break;
                case 3:
                    taskCommand.task3(page);
                    break;
                default:
                    MessageBox.Show(i.ToString());
                    break;
            }
        
        }

        /*
        private T? FindElement<T>(string name, Page page) where T : FrameworkElement
        {
            return page.FindName(name) as T;
        }

        private T? FindActiveRadioButton<T>(string groupName, Page page) where T : RadioButton
        {
            return (page.Content as Panel)?
                .Children.OfType<T>()
                .FirstOrDefault(rb => rb.IsChecked == true && rb.GroupName == groupName);

        }
        */
    }
}