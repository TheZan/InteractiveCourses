using Courses.Class;
using Courses.DBModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Courses.Page
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : UserControl
    {
        CoursesContext db = new CoursesContext();
        MainWindow mainWindow = new MainWindow();
        List<question> questions;
        int testId, numberQuestion, i = 0, moduleId;

        public Test(int testId, int moduleId)
        {
            InitializeComponent();
            this.testId = testId;
            this.moduleId = moduleId;
            questions = db.question.Where(p => p.testId == testId).ToList();
            GetAnswer(i);
        }

        private void GetAnswer(int questionNumber)
        {
            numberQuestion = questions[questionNumber].questionId;
            groupTitle.Text = db.question.Where(p => p.questionId == numberQuestion).Select(p => p.questionText).FirstOrDefault();
            answerBox.ItemsSource = db.answer.Where(p => p.questionId == numberQuestion).ToList();
            i++;
        }

        private void GetBadge()
        {
            var badgeId = db.badge.Where(p => p.moduleId == moduleId).Select(p => p.badgeId).FirstOrDefault();
            var resultTest = db.result.Where(p => p.userId == MainWindow.userIdToTest && p.badgeId == badgeId).Any();
            if (resultTest)
            {
                var image = ConvertToImage.ToImage(db.badge.Where(p => p.moduleId == moduleId).Select(p => p.badgeImage).FirstOrDefault());
                badgeImage.Source = image;
                dialogEnd.IsOpen = true;
            }
            else
            {
                var image = ConvertToImage.ToImage(db.badge.Where(p => p.moduleId == moduleId).Select(p => p.badgeImage).FirstOrDefault());
                badgeImage.Source = image;
                dialogEnd.IsOpen = true;
                result finishTest = new result
                {
                    badgeId = badgeId,
                    userId = MainWindow.userIdToTest
                };
                db.result.Add(finishTest);
                db.SaveChanges();
            }
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem lbi = sender as ListBoxItem;
            if (lbi != null)
            {
                answer fam = lbi.DataContext as answer;
                if (fam != null)
                {
                    int answerId = fam.answerId;
                    int correctAnswerId = db.correctAnswer.Where(p => p.question == numberQuestion).Select(p => p.answer).FirstOrDefault();
                    
                    if (i <= db.question.Where(p => p.testId == testId).Count())
                    {
                        if (answerId == correctAnswerId)
                        {
                            try
                            {
                                GetAnswer(i);
                                messageError.Visibility = Visibility.Collapsed;
                            }
                            catch
                            {
                                GetBadge();
                            }
                        }
                        else
                        {
                            messageError.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        GetBadge();
                    }
                }
            }
        }

        private void goMain_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new Main());
        }

        private void goProfile_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new Profile());
        }
    }
}
