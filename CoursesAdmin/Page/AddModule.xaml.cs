﻿using CoursesAdmin.Class;
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
	/// Логика взаимодействия для AddModule.xaml
	/// </summary>
	public partial class AddModule : UserControl
    {
		CoursesContext db;
		byte[] imageArray;
		BitmapImage image;
		int moduleID;

		public AddModule()
        {
            InitializeComponent();
			db = new CoursesContext();
			addEditButton.Content = "Добавить";
		}

		public AddModule(int moduleID)
		{
			InitializeComponent();
			this.moduleID = moduleID;
			db = new CoursesContext();
			addEditButton.Content = "Изменить";
			GetModule();
		}

		private void GetModule()
		{
			var module = db.module.Where(p => p.moduleId == moduleID).ToList();
			moduleName.Text = module.Select(p => p.moduleName).FirstOrDefault();
			imageArray = module.Select(p => p.moduleImage).FirstOrDefault();
			moduleImage.ImageSource = ConvertToImage.ToImage(imageArray);
			rtbEditor.AppendText(module.Select(p => p.description).FirstOrDefault());
		}

		private void back_Click(object sender, RoutedEventArgs e)
		{
			main.Children.Clear();
			main.Children.Add(new MainPage());
		}

		private void addEditButton_Click(object sender, RoutedEventArgs e)
		{
			string descriptionModule = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;
			if (db.module.Where(p => p.moduleId == moduleID).Any())
			{
				if (moduleName.Text != "" || descriptionModule != "" || imageArray != null)
				{
					var module = db.module.Where(p => p.moduleId == moduleID).FirstOrDefault();
					module.moduleName = moduleName.Text;
					module.description = descriptionModule;
					module.moduleImage = imageArray;
					db.SaveChanges();
				}
			}
			else
			{
				if (moduleName.Text != "" && descriptionModule != "" && imageArray != null)
				{
					module addModule = new module
					{
						moduleName = moduleName.Text,
						description = descriptionModule,
						moduleImage = imageArray
					};
					
					test addTest = new test
					{
						testName = moduleName.Text,
						moduleId = addModule.moduleId
					};

					badge addBadge = new badge
					{
						badgeName = moduleName.Text,
						badgeImage = imageArray,
						moduleId = addModule.moduleId
					};

					db.module.Add(addModule);
					db.test.Add(addTest);
					db.badge.Add(addBadge);
					db.SaveChanges();
				}
				moduleName.Clear();
				moduleImage.ImageSource = null;
				rtbEditor.Document.Blocks.Clear();
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
				moduleImage.ImageSource = image;
			}
		}
	}
}
