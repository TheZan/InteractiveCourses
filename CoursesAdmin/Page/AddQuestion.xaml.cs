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
    /// Логика взаимодействия для AddQuestion.xaml
    /// </summary>
    public partial class AddQuestion : UserControl
    {
        CoursesContext db;
        int questionID, answerID;
        public AddQuestion(int questionID)
        {
            InitializeComponent();
            this.questionID = questionID;
            db = new CoursesContext();
            GetAnswer();
        }

        private void GetAnswer()
        {
            questionName.Text = db.question.Where(p => p.questionId == questionID).Select(p => p.questionText).FirstOrDefault();
            lvAnswer.ItemsSource = db.answer.Where(p => p.questionId == questionID).ToList();
            var result = (from PR in db.answer
                          join OD in db.correctAnswer on PR.answerId equals OD.answer

                          where PR.answerId == OD.answer && OD.question == questionID
                          select new
                          {
                              corectAnswerName = PR.answerText
                          }).ToList();
            correctAnswer.Text = $"Правильный ответ - {result[0].corectAnswerName}";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            main.Children.Clear();
            main.Children.Add(new MainPage());
        }

        private void addEditButton_Click(object sender, RoutedEventArgs e)
        {
            var answers = db.answer.Where(p => p.answerId == answerID).FirstOrDefault();
            answers.answerText = answerText.Text;
            db.SaveChanges();
            GetAnswer();
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            if (answerID != 0)
            {
                db = new CoursesContext();
                CoursesContext db1 = new CoursesContext();
                if (db1.correctAnswer.Where(p => p.answer == answerID).Any())
                {
                    correctAnswer correctAnswers = new correctAnswer
                    {
                        answer = answerID
                    };
                    db1.correctAnswer.Attach(correctAnswers);
                    db1.correctAnswer.Remove(correctAnswers);
                }
                answer answers = new answer
                {
                    answerId = answerID
                };
                db.answer.Attach(answers);
                db.answer.Remove(answers);
                db.SaveChanges();
                answerText.Clear();
                GetAnswer();
            }
        }

        private void setCorrect_Click(object sender, RoutedEventArgs e)
        {
            if(answerID != 0)
            {
                if(db.correctAnswer.Where(p => p.question == questionID).Any())
                {
                    var correct = db.correctAnswer.Where(p => p.question == questionID).FirstOrDefault();
                    correct.answer = answerID;
                }
                else
                {
                    correctAnswer correctAnswers = new correctAnswer
                    {
                        question = questionID,
                        answer = answerID
                    };
                    db.correctAnswer.Add(correctAnswers);
                }
                db.SaveChanges();
                GetAnswer();
            }
        }

        private void ListViewItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            answerID = 0;
            ListBoxItem lbi = sender as ListBoxItem;
            if (lbi != null)
            {
                answer fam = lbi.DataContext as answer;
                if (fam != null)
                {
                    try
                    {
                        answerID = fam.answerId;
                    }
                    catch { }
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            answer answers = new answer
            {
                answerText = answerText.Text,
                questionId = questionID
            };
            db.answer.Add(answers);
            db.SaveChanges();
            GetAnswer();
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            answerID = 0;
            ListBoxItem lbi = sender as ListBoxItem;
            if (lbi != null)
            {
                answer fam = lbi.DataContext as answer;
                if (fam != null)
                {
                    try
                    {
                        answerID = fam.answerId;
                        var answers = db.answer.Where(p => p.answerId == answerID).FirstOrDefault();
                        answerText.Text = answers.answerText;
                    }
                    catch { }
                }
            }
        }
    }
}
