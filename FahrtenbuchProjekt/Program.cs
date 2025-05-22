using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Data;

namespace FahrtenbuchProjekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Ensure DB exists and is seeded
            using (var context = new JourneybookContext())
            {
                DbInitializer.Initialize(context);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginWindow());
        }
    }
}