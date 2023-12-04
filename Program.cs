using System.Linq;


namespace Catan
{
    
    internal static class Program
    {
        

        public static Game game = new Game();
        public static DAL Dal = new DAL();
        public static Settlement[] settlements = new Settlement[] { };
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
           
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartMenu());
        }
    }
}