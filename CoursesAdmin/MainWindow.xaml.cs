using CoursesAdmin.DBModel;
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
        CoursesContext db = new CoursesContext();
        List<module> modules;
        List<submodule> submodules;
        public MainWindow()
        {
            InitializeComponent();
            int firstModuleId = db.module.Select(p => p.moduleId).FirstOrDefault();
            StartProgramm(firstModuleId);
        }

        private void StartProgramm(int moduleId)
        {
            try
            {
                modules = db.module.ToList();
                submodules = db.submodule.Where(p => p.moduleId == moduleId).ToList();
                lv.ItemsSource = modules;
                submodule.ItemsSource = submodules;
            }
            catch { }
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

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem lbi = sender as ListViewItem;
            if (lbi != null)
            {
                module fam = lbi.DataContext as module;
                if (fam != null)
                {
                    try
                    {
                        int moduleId = fam.moduleId;
                        StartProgramm(moduleId);
                        //main.Children.Clear();
                        //main.Children.Add(new Module(moduleId));
                    }
                    catch { }
                }
            }
        }
    }
}
