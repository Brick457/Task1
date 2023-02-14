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
    /// Логика взаимодействия для Task14.xaml
    /// </summary>
    public partial class Task14 : Page
    {
        public Task14()
        {
            InitializeComponent();
        }
        public void BTN14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy12.Text);
                double h = Convert.ToDouble(TBh2.Text);
                double n = Convert.ToDouble(TBn4.Text);
                MessageBox.Show($"P = {Math.Exp(y+2.5)+ 7.1 * Math.Pow(h,3) / 1 * n * Math.Sqrt(y +0.04* h) }", "задание 1.14",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.14",
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