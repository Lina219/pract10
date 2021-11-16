using System;
using System.Collections;
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

namespace pract10
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

        List<int> list = new List<int>();

        private void справка_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31\nПеревезенцева Полина\n\nДан массив в диапазоне [0;10]найти количество значений равных 5 и 7. ");
        }

        private void выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void рассчитать_Click(object sender, RoutedEventArgs e)
        {
            
            int counterOfFive = 0;
            int counterOfSeven = 0;
            bool a = Int32.TryParse(элемент.Text, out int item);
            if (a && item >= 0 && item <= 10)
            {
                list.Add(item);
                список.Items.Add(item);
                int[] mas = new int [list.Count];
                mas = list.ToArray();
                for (int i=0; i<mas.Length; i++)
                {
                    if(mas[i] == 5)
                    {
                        counterOfFive++;
                    }
                    if (mas[i] == 7)
                    {
                        counterOfSeven++;
                    }
                }
                вывод.Text = ("Количество значений равных пяти - " + counterOfFive + "\nКоличество значений равных семи - " + counterOfSeven);
            }
            else
            {
                MessageBox.Show("Введите целое число в диапазоне [0;10]");
            }
            элемент.Clear();
        }

        private void очистить_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            список.Items.Clear();
            элемент.Clear();
            вывод.Clear();
        }
    }
}
