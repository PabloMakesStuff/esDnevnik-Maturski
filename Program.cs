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

        public static Font btnFont = new Font("Arial", 12);


        //centrira usercontrol sa panelom, drugacije ne znam
        public static void AddCenteredControl(UserControl uc, FlowLayoutPanel f1)
        {
            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;

            Panel wrapper = new Panel();
            wrapper.Margin = new Padding(0);

            wrapper.Width = f1.ClientSize.Width - f1.Padding.Horizontal - scrollbarWidth;

            wrapper.Height = uc.Height;

            uc.Top = 5;
            uc.Left = (wrapper.Width - uc.Width) / 2;

            wrapper.Controls.Add(uc);
            f1.Controls.Add(wrapper);

            wrapper.Resize += (s, e) =>
            {
                uc.Left = (wrapper.Width - uc.Width) / 2;
            };
        }
    }
}