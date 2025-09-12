namespace Drones
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

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            for (int i = 0; i < 6; i++)
            {
                string name = "kiks'miousik";
                string namei = name + i;
                Drone drone = new Drone(i * 10, i * 100, namei);
                fleet.Add(drone);
            }
            

            // Démarrage
            Application.Run(new AirSpace(fleet));
        }
    }
}