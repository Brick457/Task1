using System.Windows.Controls;
using System.Windows;
using System;
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
    /// Логика взаимодействия для Task29.xaml
    /// </summary>
    public partial class Task30 : Page
    {
        public Task30()
        {
            InitializeComponent();
        }
        public void BTN30_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TBy25.Text);
                double p = Convert.ToDouble(TBp3.Text);
                

                MessageBox.Show($"N = {3*Math.Pow(y,3)+Math.Sqrt(y+1)/Math.Log10(p+y)+Math.Exp(p)}", "задание 1.30",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "задание 1.30",
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