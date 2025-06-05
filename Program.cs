namespace EducationSystemApp
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
            tempProfile.profiles = new Dictionary<string, tempProfile>() {
                { "a", new tempProfile(1, 2, 3) },
                { "b", new tempProfile(3, 2, 1) },
                { "c", new tempProfile(30000, 0, 30) },
                { "d", new tempProfile(5, 6, 7) },
            }; //temp
            Application.Run(new ProfileComparor());
        }
    }
}