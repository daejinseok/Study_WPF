using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.ThrowWindowParty
{

	class ThrowWindowParty: Application
	{
		[STAThread]
		public static void Main()
		{
			ThrowWindowParty app = new ThrowWindowParty();
			//app.ShutdownMode = ShutdownMode.OnMainWindowClose;
			app.Run();
		}

		protected override void OnStartup(StartupEventArgs args)
		{
			base.OnStartup(args);

			Window winMain = new Window();
			winMain.Title = "WindowOnMouseDown";
			winMain.MouseDown += WindowOnMouseDown;
			winMain.Show();

			for(int i = 0; i < 2; i++){
				Window win = new Window();
				win.Title = "Extra Window No. " + (i + 1);
				win.ShowInTaskbar = false;
				win.Show();
				//MainWindow = win;
				win.Owner = winMain;
			}
		}

		void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
		{
			Window win = new Window();
			win.Title = "Modal Dialog Box";
			win.ShowDialog();

			Window mainWin = sender as Window;
			mainWin.Title = "Main : " + Windows.Count;
		}


	}
}
