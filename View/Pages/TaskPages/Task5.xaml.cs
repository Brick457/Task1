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
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Page
    {
        public Task5()
        {
            InitializeComponent();
        }
        public void BTN5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TBa.Text);
                double t = Convert.ToDouble(TBt.Text);
                double y = Convert.ToDouble(TBy4.Text);
                MessageBox.Show($"D = {(7.8 * Math.Pow(a,2) + 3.52 * Math.Pow(t,2)) /( (Math.Log10(a) + 2 * y) + Math.Exp(y))}", "задание 1.5",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.5",
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
