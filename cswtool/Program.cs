using IrrKlang;

namespace cswtool
{
    internal static class Program
    {

        public static ISoundEngine Engine;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Engine = new ISoundEngine(SoundOutputDriver.AutoDetect);

            ApplicationConfiguration.Initialize();
            Application.Run(new cswEdit());
        }
    }
}