System.Console.WriteLine("Where to get Schnitzel");
System.Console.WriteLine("======================");

var files = Directory.GetFiles(@"C:\HTL\1AHIF\Programmieren\SchnitzelHuntFiles");

foreach (var file in files)
{
    var lines = File.ReadAllLines(file);
    var firstSchnitzelFound = false;
    foreach (var line in lines)
    {
        var splittedLine = line.Split(':');
        var dish = splittedLine[0];
        if (!line.Contains(":")) { continue; }
        if (dish.Contains("Schnitzel"))
        {
            if (!firstSchnitzelFound)
            {
                System.Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                firstSchnitzelFound = true;
            }
            System.Console.Write("   ");
            System.Console.WriteLine(dish);
        }
    }
}