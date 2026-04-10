namespace Maturski
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }

    // pomocne funkcije za estetiku
    public static class FM
    {
        // f1 = trenutna forma, f2 = forma koja se otvara
        public static void OpenForm(Form f1, Form f2)
        {
            var location = f1.Location;
            var windowState = f1.WindowState;

            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = location;
            f2.WindowState = windowState;

            f2.Show();
            f1.Hide();
        }
    }
}