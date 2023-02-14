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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();
        }
        public void BTN2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(TBd.Text);
                double y = Convert.ToDouble(TBy1.Text);
                MessageBox.Show($"F={Math.Log10(d)+(3.5*Math.Pow(d, 2)+1)/Math.Cos(2*y)}", "задание 1.2",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.2",
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
