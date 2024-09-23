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
    /// Логика взаимодействия для Task_4.xaml
    /// </summary>
    public partial class Task_4 : Window
    {
        public Task_4()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            var inputArray = tbInputArray.Text;
            var numbers = inputArray.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (int.TryParse(tbB.Text, out int b))
            {
                var partitionedArray = PartitionArray(numbers, b);
                tbResult.Text = string.Join(", ", partitionedArray);
            }
            else
            {
                MessageBox.Show("Введите корректное значение для b.");
            }

        }

        private int[] PartitionArray(int[] numbers, int b)
        {
            List<int> lessThanB = new List<int>();
            List<int> greaterThanB = new List<int>();

            greaterThanB.Add(b);
            foreach (int number in numbers)
            {
                if (number < b)
                    lessThanB.Add(number);
                else if (number > b)
                    greaterThanB.Add(number);
            }
            return lessThanB.Concat(greaterThanB).ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
