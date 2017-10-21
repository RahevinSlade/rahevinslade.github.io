using System;
using System.Windows.Forms;

namespace MyProgram
{
    static class Program
        [STAThread]
    static void Main(string[] args)
    {
        System.Console.WriteLine("ABC");
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1(args));
    }
}
}

