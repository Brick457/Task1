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
    /// Логика взаимодействия для Task16.xaml
    /// </summary>
    public partial class Task16: Page
    {
        public Task16()
        {
            InitializeComponent();
        }
        public void BTN16_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy14.Text);
                double r = Convert.ToDouble(TBr1.Text);
                double t = Convert.ToDouble(TBt4.Text);
                MessageBox.Show($"W = {4*Math.Pow(t,3)+Math.Log10(r) / Math.Exp(y+r) + 7.2 * Math.Sin(r)}", "задание 1.16",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.16",
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