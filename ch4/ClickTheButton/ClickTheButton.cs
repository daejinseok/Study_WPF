using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace ns
{
	class ClickTheButton : Window
	{
		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new ClickTheButton());
		}
	
		public ClickTheButton()
		{
			Title = "Click the Button";

			Button btn = new Button();
			btn.Content = "_Click me, please!";
			btn.Click += ButtonOnClick;

			Content = btn;

			Button b = Content as Button;

			b.IsDefault = true;
			b.IsCancel = true;
			b.Margin = new Thickness(96);
			//b.HorizontalContentAlignment = HorizontalAlignment.Left;
			//b.VerticalContentAlignment = VerticalAlignment.Bottom;
			btn.Padding = new Thickness(96);

			// b.HorizontalAlignment = HorizontalAlignment.Center;
			// b.VerticalAlignment   = VerticalAlignment.Center;

			SizeToContent = SizeToContent.WidthAndHeight;
			btn.FontSize = 48;
			//btn.FontFamily = new FontFamily("Times New Roman");
			btn.FontFamily = new FontFamily("D2Coding");

			btn.Background = Brushes.AliceBlue;
			btn.Foreground = Brushes.DarkSalmon;
			btn.BorderBrush = Brushes.Magenta;


		}

		void ButtonOnClick(object sender, RoutedEventArgs args)
		{
			MessageBox.Show("The button...", Title);
		}
	}
}