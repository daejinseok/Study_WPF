using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace ns
{
	public class PaintTheButton : Window
	{
		const int SIZE = 64;
		const int BORD = 6;

		[STAThread]		
		public static void Main()
		{
			Application app = new Application();
			app.Run(new PaintTheButton());
		}
	
		public PaintTheButton()
		{
			Title = "Paint the Button";

			Button btn = new Button();
			btn.HorizontalAlignment = HorizontalAlignment.Center;
			btn.VerticalAlignment   = VerticalAlignment.Center;
			Content = btn;
			
			Canvas canv = new Canvas();
			canv.Width = 144;
			canv.Height = 144;
			btn.Content = canv;
			
			Rectangle rect = new Rectangle();
			rect.Width = canv.Width;
			rect.Height = canv.Height;
			rect.RadiusX = 24;
			rect.RadiusY = 24;
			rect.Fill = Brushes.Blue;
			canv.Children.Add(rect);
			Canvas.SetLeft(rect, 0);
			Canvas.SetTop(rect, 0);

			// Polygon poly = new Polygon();
			// poly.Fill = Brushes.Yellow;
			// poly.Points = new PointCollection();

			// for (int i = 0; i < 5; i++)
			// {
			// 	double angle = i * 4 * Math.PI / 5;
			// 	//Point pt = new Point(48 * Math.Sin(angle), -48 * Math.Cos(angle));
			// 	Point pt = new Point(48 * Math.Sin(angle), 100*i);
			// 	poly.Points.Add(pt);
			// }
			// canv.Children.Add(poly);
			// Canvas.SetLeft(poly, canv.Width/2);
			// Canvas.SetTop(poly, canv.Height/2);

			Polygon poly = new Polygon();
			poly.Points = new PointCollection(new Point[]
			{
				new Point(0, 0),
				new Point(SIZE, 0),
				new Point(SIZE-BORD, BORD),
				new Point(BORD, BORD),
				new Point(BORD, SIZE-BORD),
				new Point(0, SIZE)
			});

			poly.Fill = SystemColors.ControlLightLightBrush;
			canv.Children.Add(poly);

			poly = new Polygon();
			poly.Points = new PointCollection(new Point[]
			{
				new Point(SIZE, SIZE),
				new Point(SIZE, 0),
				new Point(SIZE-BORD, BORD),
				new Point(SIZE-BORD, SIZE-BORD),
				new Point(BORD, SIZE-BORD),
				new Point(0, SIZE)
			});

			poly.Fill = SystemColors.ControlDarkBrush;
			canv.Children.Add(poly);

			Border bord = new Border();
			bord.Width  = SIZE - 2 * BORD;
			bord.Height = SIZE - 2 * BORD;
			bord.Background = SystemColors.ControlBrush;
			canv.Children.Add(bord);
			Canvas.SetLeft(bord, BORD);
			Canvas.SetTop(bord, BORD);

			txtblk = new TextBlock();
			txtblk.FontSize = 32;
			txtblk.Foreground = SystemColors.ControlTextBrush;
			txtblk.HorizontalAlignment = HorizontalAlignment.Center;
			txtblk.VerticalAlignment   = VerticalAlignment.Center;
			bord.Child = txtblk;
		}

		public string Text
		{
			set { txtblk.Text = value; }
			get { return txtblk.Text; }
		}
	}
}