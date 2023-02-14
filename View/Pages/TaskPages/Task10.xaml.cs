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
    public partial class Task10 : Page
    {
        public Task10()
        {
            InitializeComponent();
        }
        public void BTN10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TBt2.Text);
                double y = Convert.ToDouble(TBy8.Text);
                MessageBox.Show($"Z = {2 * t + y * Math.Cos(t) / (Math.Sqrt(y) + 4.831)}", "задание 1.10",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.10",
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
