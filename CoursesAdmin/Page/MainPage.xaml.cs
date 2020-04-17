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

namespace CoursesAdmin.Page
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        CoursesContext db;
        List<module> modules;
        List<submodule> submodules;
        List<test> tests;
        int moduleID, submoduleID;
        public MainPage()
        {
            InitializeComponent();
            db = new CoursesContext();
            moduleID = db.module.Select(p => p.moduleId).FirstOrDefault();
            StartProgramm(moduleID);
        }

        private void StartProgramm(int moduleId)
        {
            try
            {
                modules = db.module.ToList();
                submodules = db.submodule.Where(p => p.moduleId == moduleId).ToList();
                tests = db.test.Where(p => p.moduleId == moduleId).ToList();
                lv.ItemsSource = modules;
                submodule.ItemsSource = submodules;
                testModule.ItemsSource = tests;
                var moduleNameString = modules.Where(p => p.moduleId == moduleId).Select(p => p.moduleName).FirstOrDefault();
                moduleName.Text = $"Разделы модуля - {moduleNameString}";
                testModuleName.Text = $"Тест модуля - {moduleNameString}";
            }
            catch { }
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
                        moduleID = fam.moduleId;
                        StartProgramm(moduleID);
                    }
                    catch { }
                }
            }
        }

        private void ListViewItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem lbi = sender as ListViewItem;
            if (lbi != null)
            {
                module fam = lbi.DataContext as module;
                if (fam != null)
                {
                    try
                    {
                        moduleID = fam.moduleId;
                    }
                    catch { }
                }
            }
        }

        private void contextModule_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Name)
            {
                case "deleteModule":
                    if (moduleID != 0)
                    {
                        db = new CoursesContext();
                        module modules = new module
                        {
                            moduleId = moduleID
                        };
                        db.module.Attach(modules);
                        db.module.Remove(modules);
                        db.SaveChanges();
                        StartProgramm(db.module.Select(p => p.moduleId).FirstOrDefault());
                    }
                    break;

                case "editModule":
                    if (moduleID != 0)
                    {
                        main.Children.Clear();
                        main.Children.Add(new AddModule(moduleID));
                    }
                    break;

                case "addModule":
                    main.Children.Clear();
                    main.Children.Add(new AddModule());
                    break;

                default:
                    break;
            }
        }

        private void contextSubmodule_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Name)
            {
                case "deleteSubmodule":
                    if (submoduleID != 0)
                    {
                        db = new CoursesContext();
                        submodule submodules = new submodule
                        {
                            submoduleId = submoduleID
                        };
                        db.submodule.Attach(submodules);
                        db.submodule.Remove(submodules);
                        db.SaveChanges();
                        StartProgramm(db.module.Select(p => p.moduleId).FirstOrDefault());
                    }
                    break;

                case "editSubmodule":
                    if (submoduleID != 0)
                    {
                        main.Children.Clear();
                        main.Children.Add(new AddSubmodule(submoduleID));
                    }
                    break;

                case "addSubmodule":
                    main.Children.Clear();
                    main.Children.Add(new AddSubmodule(moduleID, ""));
                    break;

                default:
                    break;
            }
        }

        private void ListBoxItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem lbi = sender as ListBoxItem;
            if (lbi != null)
            {
                submodule fam = lbi.DataContext as submodule;
                if (fam != null)
                {
                    try
                    {
                        submoduleID = fam.submoduleId;
                    }
                    catch { }
                }
            }
        }
    }
}
