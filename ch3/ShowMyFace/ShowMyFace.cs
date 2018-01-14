using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging; // BitmapImage class
using System.Windows.Controls; // Image class

namespace ns
{
	class ShowMyFace : Window
	{
		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new ShowMyFace());
		}
	
		public ShowMyFace()
		{
			Title = "Show My Face";

			// Uri uri = new Uri("http://www.charlespetzold.com/PetzoldTattoo.jpg");
			Uri uri = new Uri(
				System.IO.Path.Combine(
					Environment.GetEnvironmentVariable("userProfile"), 
					"pictures", 
					"msbuild_win.PNG"));

			//BitmapImage bitmap = new BitmapImage(uri);

			BitmapImage bitmap = new BitmapImage();
			bitmap.BeginInit();
			bitmap.UriSource = uri;
			bitmap.EndInit();

			Image img = new Image();
			img.Source = bitmap;
			Content = img;
		}
	}
}