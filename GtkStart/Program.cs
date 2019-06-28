using System;
using Gtk;

namespace GtkStart
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{ 
			Application.Init();
			Window win = new Window("GtkStart FreeBSD window");
			win.Resize(200, 200);
				Gtk.Button but = new Button(); 
			Label myLabel = new Label();
			myLabel.Text = "Gtk label";
			//Add the label to the form
		 	win.Add(myLabel);
			win.ShowAll();
			Application.Run();
	  	    }
			catch(Exception ex)
			{

			}
		}
	}
}

