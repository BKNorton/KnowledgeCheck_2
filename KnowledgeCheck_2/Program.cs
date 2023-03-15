using KnowledgeCheck_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<XboxGame>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var xboxGame = new XboxGame();

    Console.WriteLine("Enter the value for Name");
    xboxGame.name = Console.ReadLine();

    Console.WriteLine("Enter the value for Difficulty");
    xboxGame.difficulty = Console.ReadLine();


    recordList.Add(xboxGame);
}

// Print out the list of records using Console.WriteLine()
foreach(var record in recordList)
{
    Console.WriteLine(record.name+ ": " + record.difficulty);
}