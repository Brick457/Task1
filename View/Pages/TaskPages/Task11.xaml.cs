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
    /// Логика взаимодействия для Task10.xaml
    /// </summary>
    public partial class Task11 : Page
    {
        public Task11()
        {
            InitializeComponent();
        }
        public void BTN11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(TBn2.Text);
                double y = Convert.ToDouble(TBy9.Text);
                MessageBox.Show($"D = {(Math.Pow(y, 2) + 0.5 * n + 4.8 / Math.Sin(y))}", "задание 1.11",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.11",
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