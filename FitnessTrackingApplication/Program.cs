namespace FitnessTrackingApplication
{
    using FitnessTrackingApplication.Controller;
    using FitnessTrackingApplication.Views;
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
                       
            UserController userControl = UserController.GetInstance();
            LoginView loginView = new LoginView(userControl);

            Application.Run(loginView);
        }
    }
}