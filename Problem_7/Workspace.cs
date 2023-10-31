class Workspace
{
    static void Main(string[] args)
    {
        List<Citizens> citizens = new List<Citizens>();
        List<Rebel> rebels = new List<Rebel>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length == 4 && !citizens.Any(citizen => citizen.name.ToLower() == input[0].ToLower()))
            {
                Citizens citizen = new Citizens(input[0], int.Parse(input[1]), input[2], DateOnly.Parse(input[3]));
                citizens.Add(citizen);
            }
            else if (input.Length == 3 && !rebels.Any(rebel => rebel.name.ToLower() == input[0].ToLower())) 
            {
                Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                rebels.Add(rebel);
            } else
            {
                Console.WriteLine("Invalid name.");
            }
        }

        int totalFood = 0;
        while (true)
        {
            string names = Console.ReadLine();
            if (names.ToLower() == "end") break;

            foreach (Citizens citizen in citizens) {
                if (citizen.name.ToLower() == names.ToLower())
                {
                    citizen.buyFood();
                }
            }

            foreach (Rebel rebel in rebels)
            {
                if (rebel.name.ToLower() == names.ToLower())
                {
                    rebel.buyFood();
                }
            }

        }

        foreach (Citizens citizen in citizens) { totalFood += citizen.food; }
        foreach (Rebel rebel in rebels) { totalFood += rebel.food; }

        Console.WriteLine(totalFood);
    }
}
