global using TextCopy;

UwUifier.Uwuifier uwuifier = new UwUifier.Uwuifier();

while(true)
{
    Console.Write("Provide text to uwuify: ");
    var input = Console.ReadLine();
    if (input != null)
    {
        string uwuResult = uwuifier.Uwuify(input);
        ClipboardService.SetText(uwuResult);
        Console.WriteLine("Result: "+ uwuResult + "\n\nCopied result to clipboard!\nPress any key to continue with new output...");
        Console.ReadKey();
        Console.Clear();
    }
}