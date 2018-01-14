using System;
using System.Windows;

namespace ns
{
	class SayHello : Window
	{
        SayHello()
        {
            Title = "Say Hello";
        }

		[STAThread]
		public static void Main()
		{
			Application app = new Application();
            app.Run(new SayHello());
		}
	}
}