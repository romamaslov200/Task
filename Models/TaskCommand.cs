using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Task.Core;
using Task.Viwes.Pages.TaskPage;

namespace Task.Models
{
    class TaskCommand
    {
        private T? FindElement<T>(string name, Page page) where T : FrameworkElement
        {
            return page.FindName(name) as T;
        }

        public void task1(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[,] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {


                TextBlock1.Text = "";
                ar = new int[10, result];


                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                    {
                        ar[i, j] = rnd.Next(100, 1000);
                    }
                }


                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                    {
                        TextBlock1.Text += $"{ar[i, j]} ";
                    }
                    TextBlock1.Text += "\n";
                }
            }
            else
            {
                TextBlock1.Text = "Еблан напиши цифру!";
            }
        }

        public void task2(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {


                TextBlock1.Text = "";
                ar = new int[result];

                for (int i = 0;i < ar.Length; i++)
                {
                    ar[i] = i;

                    if ((i % 2) == 0)
                    {
                        ar[i] = ar[i] * -1;
                    }
                    TextBlock1.Text += $"{ar[i]}\n";
                }
            }
            else
            {
                TextBlock1.Text = "Еблан напиши цифру!";
            }
        }

        public async void task3(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);




            var url = "https://example.com"; // Замените на нужный URL
            
            TextBlock1.Text = "";
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Загружаем страницу
                    var html = await httpClient.GetStringAsync(input_TextBox.Text);

                    // Используем регулярные выражения для поиска H1
                    var pPattern = "<p>(.*?)</p>";
                    var matches = Regex.Matches(html, pPattern, RegexOptions.IgnoreCase);

                    if (matches.Count != 0)
                    {
                        foreach (Match match in matches)
                        {
                            TextBlock1.Text += $"{match.Groups[1].Value}";
                            //Console.WriteLine(match.Groups[1].Value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("P заголовков не найдено.");
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Ошибка при загрузке страницы: {e.Message}");
                }
            }
        }

        public void task4(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {


                TextBlock1.Text = "";
                ar = new int[result];

                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(1,1000);
                }

                Array.Sort(ar);
                Array.Reverse(ar);

                for (int i = 0; i < ar.Length; i++)
                {
                    TextBlock1.Text += $"{ar[i]}\n";
                }
            }
            else
            {
                TextBlock1.Text = "Еблан напиши цифру!";
            }
        }

        public void task5(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {

                TextBlock1.Text = "";
                ar = new int[result];

                int h = 0;
                int nh = 0;

                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(1, 1000);

                    if ((ar[i] % 2) == 0) { h++; }
                    else { nh++; }
                }

                TextBlock1.Text = $"Чётных чисел в масиве - {h}\nНе чётных чисел в масиве - {nh}\n\nДанные масива\n";

                foreach (var item in ar)
                {
                    TextBlock1.Text += $"{item}\n";
                }

            }
            else
            {
                TextBlock1.Text = "Еблан напиши цифру!";
            }
        }

        public async void task6(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {
                s:

                TextBlock1.Text = "";
                ar = new int[result];

                int maxValue;
                int maxIndex;

                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(1, 1000);
                }

                maxValue = ar.Max();
                maxIndex = ar.ToList().IndexOf(maxValue);

                TextBlock1.Text += $"Индекс наибольшего чесла - {maxIndex}\n\nДанные масива:\n";

                foreach (var item in ar)
                {
                    TextBlock1.Text += $"{item}\n";
                }
                
                
                //await System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1));

            }
            else
            {
                TextBlock1.Text = "Еблан напиши цифру!";
            }
        }

        public void task7(Page page)
        {
            TextBox input_TextBox = FindElement<TextBox>("input_TextBox", page);
            TextBlock TextBlock1 = FindElement<TextBlock>("TextBlock1", page);

            int[] ar;
            Random rnd = new Random();

            int result;

            if (int.TryParse(input_TextBox.Text, out result))
            {
                if ((result % 2) == 0)
                {
                    TextBlock1.Text = "";
                    ar = new int[result];

                    int[] h = new int[result];
                    int[] nh = new int[result];

                    int idh = 0;
                    int idnh = 0;

                    for(int i = 0; i < ar.Length; i++)
                    {
                        ar[i] = rnd.Next(1, 1000);
                    }

                    for (int i = 0; i < ar.Length; i++)
                    {
                        ar[i] = rnd.Next(100, 1000);

                        if ((ar[i] % 2) == 0) 
                        {
                            idh++;
                            h[i] = ar[idh];
                        }
                        else 
                        {
                            idnh++;
                            nh[i] = ar[idnh];
                        }
                    }
                    MessageBox.Show($"{h.Length}");
                    for (int i = 0; i < result/2; i++)
                    {
                        MessageBox.Show($"{i}");
                        TextBlock1.Text += $"{h[i]} - {nh[i]} = {h[i] - nh[i]}\n";
                    }
                }
                else
                {
                    TextBlock1.Text = "Еблан напиши чотную цифру!";
                }
            }
            else
            {
                TextBlock1.Text = "Еблан напиши не цифру!";
            }
        }

    }
}
