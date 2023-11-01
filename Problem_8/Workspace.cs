using System.Text;

class Workspace
{
    static void Main(string[] args)
    {
        List<Privates> privatesList = new List<Privates>();
        StringBuilder stringBuilder = new StringBuilder();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');

            if (input[0].ToLower() == "end") break;

            int id = int.Parse(input[1]);
            string firstName = input[2], lastName = input[3];
            double salary = double.Parse(input[4]);
            string corps = "";

            switch (input[0].ToLower())
            {


                case "private":
                    Privates privates = new Privates(firstName, lastName, id, salary);
                    stringBuilder.Append(privates.ToString() + "\n");
                    privatesList.Add(privates);
                    break;

                case "spy":
                    int codeNumber = int.Parse(input[4]);
                    Spy spy = new Spy(firstName, lastName, id, codeNumber);
                    stringBuilder.Append(spy.ToString() + "\n");
                    break;

                case "leutenantgeneral":
                    List<Privates> sublist = new List<Privates>();
                    for (int i = 5; i < input.Length; i++)
                    {
                        foreach (Privates pr in privatesList)
                        {
                            if (pr.id == int.Parse(input[i])) sublist.Add(pr);
                        }
                    }
                    LeutenantGenereal leutenantGenereal = new LeutenantGenereal(firstName, lastName, id, salary, sublist);
                    stringBuilder.Append(leutenantGenereal.ToString() + '\n');
                    break;

                case "engineer":
                    
                    if (input[5] == "Airforces") { corps = "Airforces"; }
                    else if (input[5] == "Marines") { corps = "Marines"; }
                    else break;

                    List<Repair> repairList = new List<Repair>();                    
                    for (int i = 6; i < input.Length; i=i+2)
                    {
                        string partName = input[i];
                        int hoursWorked = int.Parse(input[i + 1]);
                        repairList.Add(new Repair(partName, hoursWorked));
                    }
                    Engineer engineer = new Engineer(firstName, lastName, id, salary, corps, repairList);
                    stringBuilder.Append(engineer.ToString() + "\n");
                    break;

                case "commando":

                    if (input[5] == "Airforces") { corps = "Airforces"; }
                    else if (input[5] == "Marines") { corps = "Marines"; }
                    else break;

                    List<Mission> missionList = new List<Mission>();
                    for (int i = 6; i < input.Length; i=i+2)
                    {
                        string codeName = input[i];
                        if (input[i + 1] == "Finished")
                        {
                            bool state = false;
                            missionList.Add(new Mission(codeName, state));
                        }
                        else if (input[i + 1] == "inProgress")
                        {
                            bool state = true;
                            missionList.Add(new Mission(codeName, state));
                        }
                    }
                    Commando commando = new Commando(firstName, lastName, id, salary, corps, missionList);
                    stringBuilder.Append(commando.ToString() + "\n");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        Console.WriteLine(stringBuilder);
    }
}