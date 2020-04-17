using CoursesAdmin.Class;
using CoursesAdmin.DBModel;
using Microsoft.Win32;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace CoursesAdmin.Page
{
	/// <summary>
	/// Логика взаимодействия для AddSubmodule.xaml
	/// </summary>
	public partial class AddSubmodule : UserControl
    {
		CoursesContext db;
		byte[] imageArray;
		BitmapImage image;
		int submoduleID, moduleID;

		public AddSubmodule(int moduleID, string stub)
		{
			InitializeComponent();
			this.moduleID = moduleID;
			db = new CoursesContext();
			addEditButton.Content = "Добавить";
		}

		public AddSubmodule(int submoduleID)
		{
			InitializeComponent();
			this.submoduleID = submoduleID;
			db = new CoursesContext();
			addEditButton.Content = "Изменить";
			GetModule();
		}

		private void GetModule()
		{
			var submodule = db.submodule.Where(p => p.submoduleId == submoduleID).ToList();
			submoduleName.Text = submodule.Select(p => p.submoduleName).FirstOrDefault();
			imageArray = submodule.Select(p => p.submoduleImage).FirstOrDefault();
			submoduleImage.ImageSource = ConvertToImage.ToImage(imageArray);
			rtbEditor.AppendText(submodule.Select(p => p.submoduleText).FirstOrDefault());
		}

		private void back_Click(object sender, RoutedEventArgs e)
		{
			main.Children.Clear();
			main.Children.Add(new MainPage());
		}

		private void addEditButton_Click(object sender, RoutedEventArgs e)
		{
			string descriptionSubmodule = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;
			if (db.submodule.Where(p => p.submoduleId == submoduleID).Any())
			{
				if (submoduleName.Text != "" || descriptionSubmodule != "" || imageArray != null)
				{
					var submodule = db.submodule.Where(p => p.submoduleId == submoduleID).FirstOrDefault();
					submodule.submoduleName = submoduleName.Text;
					submodule.submoduleText = descriptionSubmodule;
					submodule.submoduleImage = imageArray;
					db.SaveChanges();
				}
			}
			else
			{
				if (submoduleName.Text != "" && descriptionSubmodule != "" && imageArray != null)
				{
					submodule addSubmodule = new submodule
					{
						submoduleName = submoduleName.Text,
						submoduleText = descriptionSubmodule,
						submoduleImage = imageArray,
						moduleId = moduleID
					};
					db.submodule.Add(addSubmodule);
					db.SaveChanges();
					submoduleName.Clear();
					submoduleImage.ImageSource = null;
					rtbEditor.Document.Blocks.Clear();
				}
			}
		}

		private void addImage_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.InitialDirectory = "";
			dlg.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				string selectedFileName = dlg.FileName;
				imageArray = ConvertToImage.ConvertImageToByteArray(selectedFileName);
				image = ConvertToImage.ToImage(imageArray);
				submoduleImage.ImageSource = image;
			}
		}
	}
}
