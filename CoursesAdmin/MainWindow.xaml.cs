using CoursesAdmin.DBModel;
using CoursesAdmin.Page;
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

namespace CoursesAdmin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            main.Children.Add(new MainPage());
        }

        private void topPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void topBanelButton(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "minimize":
                    WindowState = WindowState.Minimized;
                    break;

                case "close":
                    Application.Current.Shutdown();
                    break;

                default:
                    break;
            }
        }
    }
}
