using Courses.DBModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Courses.Page
{
    /// <summary>
    /// Логика взаимодействия для Submodule.xaml
    /// </summary>
    public partial class Submodule : UserControl
    {
        CoursesContext db = new CoursesContext();
        List<submodule> submodules;
        int n = 1;
        int moduleId, testId;
        public Submodule(int moduleId)
        {
            InitializeComponent();
            this.moduleId = moduleId;
            submodules = db.submodule.Where(p => p.moduleId == moduleId).ToList();
            testId = db.test.Where(p => p.moduleId == moduleId).Select(p => p.testId).FirstOrDefault();
            doc.DataContext = submodules[0];
        }

        private void NextPage()
        {
            try
            {
                if (n < submodules.Count())
                {
                    doc.DataContext = null;
                    doc.DataContext = submodules[n++];
                }
                else
                {
                    main.Children.Clear();
                    main.Children.Add(new Test(testId, moduleId));
                }
            }
            catch { }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            NextPage();
        }
    }
}
