using Courses.DBModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace Courses.Page
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        CoursesContext db = new CoursesContext();
        public Main()
        {
            InitializeComponent();
            List<module> modules = GetProducts();
            lv.ItemsSource = modules;
        }

        private List<module> GetProducts()
        {
            return db.module.ToList();
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
                        main.Children.Clear();
                        main.Children.Add(new Module(moduleId));
                    }
                    catch { }
                }
            }
        }
    }
}
