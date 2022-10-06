namespace Github
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
            const string version = "AbC";
            const string pass = "https://support.microsoft.com/en-ca/help/4469913/troubleshooting-windows-device-enrollment-problems-in-microsoft-intune";

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}