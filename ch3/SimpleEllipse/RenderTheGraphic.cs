using System;
using System.Windows;

namespace ns
{
	class RenderTheGraphic : Window
	{
		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new RenderTheGraphic());
		}
	
		public RenderTheGraphic()
		{
			Title = "Render the Graphics";
			SimpleEllipse elips = new SimpleEllipse();
			Content = elips;	
		}
	}
}