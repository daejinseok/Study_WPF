using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace ns
{
	public class ExaminRoutedEvents : Application
	{
		static readonly FontFamily fotfam = new FontFamily("맑은 고딕");
		const string strFormat = "{0,-30} {1,-15} {2,-15} {3,-15}";
		StackPanel stackOutput;
		DateTime dtLast;

		[STAThread]
		public static void Main()
		{
			ExaminRoutedEvents app = new ExaminRoutedEvents();
			app.Run();
		}

		protected override void OnStartup(StartupEventArgs args)
		{
			base.OnStartup(args);

			Window win = new Window();
			win.Title = "Examine Routed Events";

			Grid grid = new Grid();
			win.Content = grid;

			RowDefinition rowdef = new RowDefinition();
			rowdef.Height = GridLength.Auto;
			grid.RowDefinitions.Add(rowdef);

			rowdef = new RowDefinition();
			rowdef.Height = GridLength.Auto;
			grid.RowDefinitions.Add(rowdef);

			rowdef = new RowDefinition();
			rowdef.Height = new GridLength(100, GridUnitType.Star);
			grid.RowDefinitions.Add(rowdef);

			Button btn = new Button();
			btn.HorizontalAlignment = HorizontalAlignment.Center;
			btn.Margin = new Thickness(24);
			btn.Padding = new Thickness(24);
			grid.Children.Add(btn);

			TextBlock text = new TextBlock();
			text.FontSize = 24;
			text.Text = win.Title;
			btn.Content = text;

			TextBlock textHeadings = new TextBlock();
			textHeadings.FontFamily = fontfam;
			textHeadings.Inlines.Add(new Underline(new Run(
				String.Format(strFormat,
					"Routed Event",
					"sender",
					"Source",
					"OriginalSource"))));
			grid.Children.Add(textHeadings);
			Grid.SetRow(textHeadings, 1);

			ScrollViewer scroll = new ScrollViewer();
			grid.Children.Add(scroll);
			Grid.SetRow(scroll, 2);

			stackOutput = new StackPanel();
			scroll.Content = stackOutput;

			UIElement[] els = { win, grid, btn, text };

			foreach (UIElement el in els)
			{
				el.Pri
			}
		}
	}
}