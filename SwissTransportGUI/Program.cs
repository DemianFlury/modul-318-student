namespace SwissTransportGUI
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
            try
            {
                Application.Run(new Form1());
            }catch (Exception ex) 
            {
                MessageBox.Show("Da ist was ganz falsch, schade eigentlich :>\n\n" + ex.Message);
            }
        }
    }
}