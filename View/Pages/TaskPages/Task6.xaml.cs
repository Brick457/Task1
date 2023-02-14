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
    /// Логика взаимодействия для Task6.xaml
    /// </summary>
    public partial class Task6 : Page
    {
        public Task6()
        {
            InitializeComponent();
        }
        public void BTN6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double i = Convert.ToDouble(TBi.Text);
                double y = Convert.ToDouble(TBy3.Text);
                MessageBox.Show($"L = {(0.81 * Math.Cos(i) / Math.Log10(y) + 2 * Math.Pow(y, 3))}", "задание 1.6",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.6",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }

        private void TBy3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
