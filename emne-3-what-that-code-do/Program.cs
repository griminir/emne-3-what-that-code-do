// See https://aka.ms/new-console-template for more information
Console.WriteLine("hva gjør denne koden? oppgave");

var range = 250;
var counts = new int[range];
int allChars = 0;
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text.ToUpper() ?? string.Empty)
    {
        counts[(int)character]++;
        allChars++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            var output = character + " - " + (counts[i]/ (double)allChars) * 100 + '%';
            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
            Console.WriteLine(output);
        }
    }
}