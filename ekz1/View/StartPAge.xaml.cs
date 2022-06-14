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

namespace ekz1.View
{
    /// <summary>
    /// Логика взаимодействия для StartPAge.xaml
    /// </summary>
    public partial class StartPAge : Page
    {
        public StartPAge()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Content = new MainPage();
        }
    }
}
