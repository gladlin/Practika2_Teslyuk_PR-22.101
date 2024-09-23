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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task_1_Click(object sender, RoutedEventArgs e)
        {
            Task_1 task_1 = new Task_1();
            task_1.Show();
            this.Close();
        }

        private void Task_2_Click(object sender, RoutedEventArgs e)
        {
            Task_2 task_2 = new Task_2();
            task_2.Show();
            this.Close();
        }

        private void Task_3_Click(object sender, RoutedEventArgs e)
        {
            Task_3 task_3 = new Task_3();
            task_3.Show();
            this.Close();
        }

        private void Task_5_Click(object sender, RoutedEventArgs e)
        {
            Task_5 task_5 = new Task_5();
            task_5.Show();
            this.Close();
        }

        private void Task_4_Click(object sender, RoutedEventArgs e)
        {
            Task_4 task_4 = new Task_4();
            task_4.Show();
            this.Close();
        }
    }
}
