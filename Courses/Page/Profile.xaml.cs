using Courses.Class;
using Courses.DBModel;
using Microsoft.Win32;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Courses.Page
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        CoursesContext db = new CoursesContext();
        MainWindow mainWindow;
        public Profile(MainWindow mainWindow)
        {
            InitializeComponent();
            GetInfo(MainWindow.userIdToTest);
            this.mainWindow = mainWindow;
        }

        public Profile()
        {
            InitializeComponent();
            GetInfo(MainWindow.userIdToTest);
        }

        private void GetInfo(int userId)
        {
            fullname.Text = $"{db.users.Where(p => p.userId == MainWindow.userIdToTest).Select(p => p.firstname).FirstOrDefault()} {db.users.Where(p => p.userId == MainWindow.userIdToTest).Select(p => p.surname).FirstOrDefault()}";
            dob.Text = $"Дата рождения: {db.users.Where(p => p.userId == MainWindow.userIdToTest).Select(p => p.dob).FirstOrDefault():d}";
            sex.Text = $"Пол: {db.users.Where(p => p.userId == MainWindow.userIdToTest).Select(p => p.sex).FirstOrDefault()}";
            profilePhoto.ImageSource = ConvertToImage.ToImage(db.users.Where(p => p.userId == MainWindow.userIdToTest).Select(p => p.userPhoto).FirstOrDefault());
            
            var result = (from PR in db.badge
                          join OD in db.result on PR.badgeId equals OD.badgeId

                          where PR.badgeId == OD.badgeId && OD.userId == userId
                          select new
                          {
                              badgeImage = PR.badgeImage,
                              badgeName = PR.badgeName
                          }).ToList();

            badgeList.ItemsSource = result;
        }

        private void uploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "";
            dlg.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                string selectedFileName = dlg.FileName;
                var profilePhoto = db.users.Where(p => p.userId == MainWindow.userIdToTest).FirstOrDefault();
                profilePhoto.userPhoto = ConvertToImage.ConvertImageToByteArray(selectedFileName);
                db.SaveChanges();
                GetInfo(MainWindow.userIdToTest);
                mainWindow.ReloadPhoto();
            }
        }
    }
}
