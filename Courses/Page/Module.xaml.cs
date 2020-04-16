using Courses.DBModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Courses.Page
{
    /// <summary>
    /// Логика взаимодействия для Module.xaml
    /// </summary>
    public partial class Module : UserControl
    {
        CoursesContext db = new CoursesContext();
        int moduleId;
        public Module(int moduleId)
        {
            InitializeComponent();
            this.moduleId = moduleId;
            FillPage();
        }
        private void FillPage()
        {
            try
            {
                List<module> modules = db.module.Where(p => p.moduleId == moduleId).ToList();
                List<submodule> submodules = db.submodule.Where(p => p.moduleId == moduleId).ToList();
                doc.DataContext = modules;
                description.Text = modules[0].description;
                submodule.ItemsSource = submodules;
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                main.Children.Clear();
                main.Children.Add(new Submodule(moduleId));
            }
            catch { }
        }
    }
}
