using System;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class Task_5 : Window
    {
        public Task_5()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int n = -1;
            int m = -1;
            int.TryParse(tbN.Text, out n);
            int.TryParse(tbM.Text, out m);
            if (n <= 0 || m <= 0)
                return;

            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            int max = -11;
            int min = 11;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }

            int[] flatMatrix = matrix.Cast<int>().ToArray();

            int[] ascended = flatMatrix.OrderBy(x => x).ToArray();
            int[] descended = flatMatrix.OrderByDescending(x => x).ToArray();

            string ascendedString = "";
            string descendingString = "";
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ascendedString += ascended[index] + "  ";
                    descendingString += descended[index] + "  ";
                    index++;
                }
                ascendedString += "\n";
                descendingString += "\n";
            }

            tbAcsended.Text = ascendedString;
            tbDescending.Text = descendingString;
            tbMax.Text = "Максимальный элемент массива: " + max;
            tbMin.Text = "Минимальный элемент массива: " + min;
        }
    }
}
