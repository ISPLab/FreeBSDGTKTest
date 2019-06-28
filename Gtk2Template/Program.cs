using System;
using Gtk;

namespace Gtk2Template
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Window win = new Window("BSDWindow");
            win.Resize(200, 200);
            Label label = new Label();
            label.Text = "For Frebsd";
            win.Add(label);
            win.ShowAll();
            Application.Run();
        }
    }
}
