// See https://aka.ms/new-console-template for more information

using DiamondKataLib;

if (args.Length != 1)
{
    PrintHelp();
    return;
}

var inputChar = args[0][0];
if (Diamond.Alphabet.IndexOf(inputChar) == -1)
{
    PrintHelp();
    return;
}

PrintDiamond(inputChar);


void PrintDiamond(char c)
{
    var result = Diamond.Create(c);
    foreach(var line in result)
        Console.WriteLine(line);
    WaitForExit();
}

void PrintHelp()
{
    Console.WriteLine("Diamond Kata Help");
    Console.WriteLine();
    Console.WriteLine("Usage:");
    Console.WriteLine("\tDiamondKataApp [character]");
    Console.WriteLine("\t(Where character must be in the range A-Z)");
    WaitForExit();
}

void WaitForExit()
{
    Console.WriteLine();
    Console.WriteLine("Hit enter to exit");
    Console.ReadLine();
}