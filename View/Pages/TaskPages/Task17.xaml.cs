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
using static WpfApp3.Core.Core;

namespace WpfApp3.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task17.xaml
    /// </summary>
    public partial class Task17 : Page
    {
        public Task17()
        {
            InitializeComponent();
        }
        public void BTN17_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy15.Text);
                double n = Convert.ToDouble(TBn6.Text);
                MessageBox.Show($"H = {Math.Pow(y,2)- 0.8*y+Math.Sqrt(y) / 23.1*Math.Pow(n,2) + Math.Cos(n)}", "задание 1.17",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.17",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}