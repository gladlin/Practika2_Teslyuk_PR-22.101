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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Task_3.xaml
    /// </summary>
    public partial class Task_3 : Window
    {
        public Task_3()
        {
            InitializeComponent();
        }

        private void tbReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        /*
        В заданной последовательности целых чисел найти 
        максимально длинную подпоследовательность чисел 
        такую, что каждый последующий элемент подпоследовательности 
        делился нацело на предыдущий.
        */
        private void tbFound_Click(object sender, RoutedEventArgs e)
        {
            string[] ListOfNumbers = tbSequence.Text.Split(',');

            int startIndex = 0;
            int lenghtOfSequence = 0;
            Dictionary<int, int> sequence = new Dictionary<int, int>(); //first - start index, second - length of sequence

            for (int i = 1; i < ListOfNumbers.Length; i++)
            {
                if (Convert.ToInt32(ListOfNumbers[i]) % Convert.ToInt32(ListOfNumbers[i - 1]) == 0)
                {
                    if (lenghtOfSequence == 0)
                        startIndex = i - 1;

                    lenghtOfSequence++;
                }
                else
                {
                    if (lenghtOfSequence > 0)
                        sequence.Add(startIndex, lenghtOfSequence + 1);

                    lenghtOfSequence = 0;
                }
            }

            if (lenghtOfSequence > 0)
                sequence.Add(startIndex, lenghtOfSequence + 1);
            if (sequence.Count == 0)
            {
                tbResult.Text = "Нет подходящих последовательностей.";
                return;
            }
            var sortedDict = from entry in sequence orderby entry.Value descending select entry;
            var longestSequence = sortedDict.First();
            startIndex = longestSequence.Key;
            lenghtOfSequence = longestSequence.Value;

            string[] result = new string[lenghtOfSequence];
            for (int i = startIndex; i < startIndex + lenghtOfSequence; i++)
            {
                result[i - startIndex] = ListOfNumbers[i];
            }

            tbResult.Text = string.Join(", ", result);
        }

    }
}
