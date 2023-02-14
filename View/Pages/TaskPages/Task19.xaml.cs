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
    public partial class Task19 : Page
    {
        public Task19()
        {
            InitializeComponent();
        }
        public void BTN19_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy17.Text);
                double q = Convert.ToDouble(TBq2.Text);
                MessageBox.Show($"E = {Math.Log10(0.7*y+2*q) / Math.Sqrt(3*Math.Pow(y,2) + 0.5*y+4)}", "задание 1.19",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.19",
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
