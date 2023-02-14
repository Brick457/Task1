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
    /// Логика взаимодействия для Task19.xaml
    /// </summary>
    public partial class Task20 : Page
    {
        public Task20()
        {
            InitializeComponent();
        }
        public void BTN20_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy18.Text);
                double t = Convert.ToDouble(TBt4.Text);
                double l = Convert.ToDouble(TBl1.Text);
                MessageBox.Show($"K = {2*Math.Pow(t,2)+3*l+7.2 / Math.Log10(10) * y + Math.Pow(y,21)}", "задание 1.20",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.20",
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
