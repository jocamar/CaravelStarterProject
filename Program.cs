using System;
using MyNewGame;

namespace GameProject
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var app = new MyNewGameApp(1280, 720))
            {
                app.Run();
            }
        }
    }
}