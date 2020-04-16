using Courses.Class;
using Courses.DBModel;
using Courses.Page;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Courses
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CoursesContext db;
        public static int userIdToTest;
        MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            main.Children.Add(new Main());
            dialogAuth.IsOpen = true;
            back.Visibility = Visibility.Visible;
            mainWindow = this;
        }

        private void topPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void ReloadPhoto()
        {
            db = new CoursesContext();
            profileIcon.ImageSource = ConvertToImage.ToImage(db.users.Where(p => p.userId == userIdToTest).Select(p => p.userPhoto).FirstOrDefault());
            noPhoto.Visibility = Visibility.Collapsed;
        }

        private void topBanelButton(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "minimize":
                    WindowState = WindowState.Minimized;
                    break;
                case "maximize":
                    if (WindowState == WindowState.Normal)
                    {
                        WindowState = WindowState.Maximized;
                    }
                    else
                    {
                        WindowState = WindowState.Normal;
                    }
                    break;
                case "close":
                    Application.Current.Shutdown();
                    break;
                default:
                    break;
            }
        }

        private void general_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new Main());
        }

        private async void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text != "" && tbPassword.Password != "")
            {
                string username = tbLogin.Text;
                string password = tbPassword.Password;
                using (CoursesContext context = new CoursesContext())
                {
                    var user = await(context.users.FirstOrDefaultAsync(u => u.userLogin == username));
                    var userId = await(context.users.Where(u => u.userLogin == username).Select(u => u.userId).ToArrayAsync());
                    if (user != null)
                    {
                        if (PBKDF2HashHelper.VerifyPassword(tbPassword.Password, user.userPassword))
                        {
                            tbLoginMain.Text = username;
                            tbNameMain.Text = $"{context.users.Where(p => p.userLogin == username).Select(p => p.firstname).FirstOrDefault()} {context.users.Where(p => p.userLogin == username).Select(p => p.surname).FirstOrDefault()}";
                            if (context.users.Where(p => p.userLogin == username).Select(p => p.userPhoto).FirstOrDefault() != null)
                            {
                                profileIcon.ImageSource = ConvertToImage.ToImage(context.users.Where(p => p.userLogin == username).Select(p => p.userPhoto).FirstOrDefault());
                                noPhoto.Visibility = Visibility.Collapsed;
                            }
                            dialogAuth.IsOpen = false;
                            back.Visibility = Visibility.Collapsed;
                            userIdToTest = userId[0];
                        }
                        else { tbError.Visibility = Visibility.Visible; }
                    }
                    else { tbNot.Visibility = Visibility.Visible; }
                }
            }
            else
            {
                tbNotNullLogin.Visibility = Visibility.Visible;
            }
        }

        private void Register_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dialogAuth.IsOpen = false;
            dialogReg.IsOpen = true;
        }

        private void backToLogin_Click(object sender, RoutedEventArgs e)
        {
            Back();
        }

        private void Back()
        {
            dialogAuth.IsOpen = true;
            dialogReg.IsOpen = false;
            tbFirstname.Clear();
            tbSurname.Clear();
            tbRegLogin.Clear();
            tbRegPassword.Clear();
            tbDob.SelectedDate = null;
            tbSex.SelectedItem = null;
            tbNotNull.Visibility = Visibility.Collapsed;
            tbUnikUser.Visibility = Visibility.Collapsed;
        }

        private void tbRegLogin_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            tbNotNull.Visibility = Visibility.Collapsed;
            tbUnikUser.Visibility = Visibility.Collapsed;
            tbNotNullLogin.Visibility = Visibility.Collapsed;
            tbError.Visibility = Visibility.Collapsed;
            tbNot.Visibility = Visibility.Collapsed;
        }

        bool IsGood(char c)
        {
            if (c >= '0' && c <= '9')
                return true;
            if (c >= 'a' && c <= 'z')
                return true;
            if (c >= 'A' && c <= 'Z')
                return true;
            return false;
        }

        bool IsGoodPassword(char c)
        {
            if (c >= '0' && c <= '9')
                return true;
            if (c >= 'a' && c <= 'z')
                return true;
            if (c >= 'A' && c <= 'Z')
                return true;
            if (c >= 33 && c <= 47)
                return true;
            if (c >= 58 && c <= 64)
                return true;
            if (c >= 91 && c <= 95)
                return true;
            if (c >= 123 && c <= 126)
                return true;
            return false;
        }

        private void tbRegLogin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(IsGood);
        }

        private void tbRegPassword_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(IsGoodPassword);
        }

        private void tbRegPassword_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            var stringData = (string)e.DataObject.GetData(typeof(string));
            if (stringData == null || !stringData.All(IsGoodPassword))
                e.CancelCommand();
        }

        private void tbRegLogin_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            var stringData = (string)e.DataObject.GetData(typeof(string));
            if (stringData == null || !stringData.All(IsGood))
                e.CancelCommand();
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (tbRegLogin.Text != "" && tbRegPassword.Password != "" && tbSurname.Text != "" && tbFirstname.Text != "" && tbDob.DisplayDate != null && tbSex.SelectedItem != null)
            {
                db = new CoursesContext();
                if (db.users.Where(p => p.userLogin == tbRegLogin.Text).Any())
                {
                    tbUnikUser.Visibility = Visibility.Visible;
                }
                else
                {
                    users registration = new users
                    {
                        userLogin = tbRegLogin.Text,
                        userPassword = PBKDF2HashHelper.CreatePasswordHash(tbRegPassword.Password, 15000),
                        surname = tbSurname.Text,
                        firstname = tbFirstname.Text,
                        dob = tbDob.DisplayDate,
                        sex = tbSex.Text
                    };
                    db.users.Add(registration);
                    db.SaveChanges();
                    dialogDone.IsOpen = true;
                }
            }
            else
            {
                tbNotNull.Visibility = Visibility.Visible;
            }
        }

        private void dialogDone_DialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            Back();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new Profile(mainWindow));
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new About());
        }
    }
}
