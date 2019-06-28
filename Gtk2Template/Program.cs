using System;
using Gtk;

namespace Gtk2Template
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            Label label = new Label();
            label.Text = "For Frebsd";
            win.Add(label);
            win.ShowAll();
            Application.Run();
        }
    }
}
