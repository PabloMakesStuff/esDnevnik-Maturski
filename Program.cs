using System.Drawing.Drawing2D;

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



        public static void SetRoundedRegion(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            int diameter = radius * 2;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}