namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };
            //DirectAll(rovers);
            object[] allProbes = { lunokhod, apollo, sojourner, sputnik };

            foreach(object probe in allProbes)
            {
                Console.WriteLine(probe.GetType());
            }

        }

        static void DirectAll(Rover[] rovers)
        {
            foreach (Rover rover in rovers)
            {
                Console.WriteLine(rover.GetInfo());
                Console.WriteLine(rover.Explore());
                Console.WriteLine(rover.Collect());
            }
        }
    }
}


