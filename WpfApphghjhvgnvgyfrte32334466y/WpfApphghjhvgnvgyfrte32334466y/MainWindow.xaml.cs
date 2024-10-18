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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApphghjhvgnvgyfrte32334466y
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string d = Name.Text;
            bool a = d.All(n=>char.IsLetter(n)&&(n>='a'&&n<='z'));
            if (a)
                MessageBox.Show("Имя введно правельно", "Хорошо", MessageBoxButton.OK, MessageBoxImage.Information);
            else MessageBox.Show("Имя введено не верно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
