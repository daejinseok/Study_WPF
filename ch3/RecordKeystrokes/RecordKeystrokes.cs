using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Text;

namespace ns
{
	public class RecordKeystrokes : Window
	{
		StringBuilder build = new StringBuilder("text");

		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new RecordKeystrokes());
		}

		public RecordKeystrokes()
		{
			Title = "Record Keystrokes";
			Content = build;
		}

		protected override void OnTextInput(TextCompositionEventArgs args)
		{
			base.OnTextInput(args);

			if(args.Text == "\b")
			{
				if(build.Length > 0) build.Remove(build.Length -1, 1);
			}
			else
			{
				build.Append(args.Text);
			}

			Content = null;
			Content = build;

		}
	}
}