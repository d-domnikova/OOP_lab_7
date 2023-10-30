class Workspace
{
    static void Main(string[] args)
    {
        List<DateOnly> birthdates = new List<DateOnly>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length == 1 && input[0].ToLower() == "end") break;

            if (input[0].ToLower().Equals("citizen"))
            {
                Citizens citizen = new Citizens(input[1], int.Parse(input[2]), input[3], DateOnly.Parse(input[4]));
                birthdates.Add(citizen.birthdate);
            }
            else if (input[0].ToLower().Equals("robot"))
            {
                Robot robot = new Robot(input[1], input[2]);
            }
            else if (input[0].ToLower().Equals("pet"))
            {
                Pet pet = new Pet(input[1], DateOnly.Parse(input[2]));
                birthdates.Add(pet.birthdate);
            }

        }

        string yearOfBirth = Console.ReadLine();
        foreach (DateOnly birthdate in birthdates)
        {
            if (birthdate.Year.ToString().Equals(yearOfBirth)) { Console.WriteLine(birthdate); }
        }
    }
}
