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
    /// Логика взаимодействия для Task15.xaml
    /// </summary>
    public partial class Task15 : Page
    {
        public Task15()
        {
            InitializeComponent();
        }
        public void BTN15_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy13.Text);
                double j = Convert.ToDouble(TBj1.Text);
                double n = Convert.ToDouble(TBn5.Text);
                MessageBox.Show($"F = {2 * Math.Sin(0.354 *y+1) / 1 * n*(y+2*j)}", "задание 1.15",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information); 
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.15",
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