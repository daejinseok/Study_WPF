using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ns
{
	public class DisplaySomeText : Window
	{
		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new DisplaySomeText());
		}

		public DisplaySomeText()
		{
			Title = "Display Some Text";
			Content = "Content can be simple text";
			//FontFamily = new FontFamily("Comic Sans MS");
			FontFamily = new FontFamily("D2Coding");
			FontSize = 48;

			Brush brush = new LinearGradientBrush(Colors.Black, Colors.White,
				new Point(0, 0), new Point(1, 1));
			Background = brush;
			Foreground = brush;

			SizeToContent = SizeToContent.WidthAndHeight;
		}
	}
}