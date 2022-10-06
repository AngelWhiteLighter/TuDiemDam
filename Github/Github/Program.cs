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
            const string version = "QDH";
            const string cert = "b66825cb-2c3d-4d51-98a1-cd244f43dcfb";

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}