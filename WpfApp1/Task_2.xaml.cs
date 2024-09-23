using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для Task_2.xaml
    /// </summary>
    public partial class Task_2 : Window
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            String[] inputString = tbInputString.Text.Split();
            tbResult.Text = String.Join(" ", inputString.Reverse()).ToString();
        }
    }
}
