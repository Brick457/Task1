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
    /// Логика взаимодействия для Task25.xaml
    /// </summary>
    public partial class Task25 : Page
    {
        public Task25()
        {
            InitializeComponent();
        }
        public void BTN25_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TBt22.Text);
                double c = Convert.ToDouble(TBc1.Text);

                MessageBox.Show($"L = {Math.Pow(Math.Cos(c),2)+3*Math.Pow(t,2)+4/Math.Sqrt(c+t)}", "задание 1.25",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.25",
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
