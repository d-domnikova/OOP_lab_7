class Workspace
{
    static void Main(string[] args)
    {
        List<string> ids = new List<string>();
        while(true)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            if(input.Length == 1 && input[0].ToLower()=="end")  break;

            if (input.Length == 2) {
                Robot robot = new Robot(input[0], input[1]);
                ids.Add(robot.id);
            } else if (input.Length == 3)
            {
                Citizens citizen = new Citizens(input[0], int.Parse(input[1]), input[2]);
                ids.Add(citizen.id);
            }
        }

        string lastDigits = Console.ReadLine();
        foreach(string id in ids)
        {
            if(id.EndsWith(lastDigits)) { Console.WriteLine(id);}
        }
    }
}