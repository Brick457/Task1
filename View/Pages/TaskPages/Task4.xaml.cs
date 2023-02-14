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
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Page
    {
        public Task4()
        {
            InitializeComponent();
        }
        public void BTN4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(TBw.Text);
                double y = Convert.ToDouble(TBy3.Text);
                MessageBox.Show($"G = {(9.33 * Math.Pow(w,3) + Math.Sqrt(w)) / (Math.Log10(y + 3.55) + Math.Sqrt(y))}", "задание 1.4",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.4",
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
