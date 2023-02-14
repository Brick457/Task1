using System.Windows.Controls;
using System.Windows;
using System;
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
    /// Логика взаимодействия для Task29.xaml
    /// </summary>
    public partial class Task29 : Page
    {
        public Task29()
        {
            InitializeComponent();
        }
        public void BTN29_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy24.Text);
                double h = Convert.ToDouble(TBh3.Text);

                MessageBox.Show($"T = {0.355*Math.Pow(h,2)-4.355 / Math.Exp(y+h)+Math.Sqrt(2.7*y)}", "задание 1.29",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.29",
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