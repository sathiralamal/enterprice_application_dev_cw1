namespace FitnessTrackingApplication
{
    using FitnessTrackingApplication.Controller;
    using FitnessTrackingApplication.Views;
    using Microsoft.EntityFrameworkCore;
    using FitnessTrackingApplication.Models;
    using FitnessTrackingApplication.Utils;

    internal static class Program
       
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FitnessAppContext dbContext = new FitnessAppContext();
            bool canConnectDb =  dbContext.Database.CanConnect();
            if (!canConnectDb)
            {
                dbContext.Database.Migrate();

            }


            UserController userControl = UserController.GetInstance();
            LoginView loginView = new LoginView(userControl);

            Application.Run(loginView);
        }


    }
}