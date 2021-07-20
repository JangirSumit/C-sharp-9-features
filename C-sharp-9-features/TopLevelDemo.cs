/*
using System;
using System.Threading.Tasks;

Console.WriteLine("Starting Top Level");

foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

for (int i = 0; i < 20; i++)
{
    Console.Write("| -");
    await Task.Delay(50);
    Console.Write("\b\b\b");
    Console.Write("/ \\");
    await Task.Delay(50);
    Console.Write("\b\b\b");
    Console.Write("- |");
    await Task.Delay(50);
    Console.Write("\b\b\b");
    Console.Write("\\ /");
    await Task.Delay(50);
    Console.Write("\b\b\b");
}
Console.WriteLine();

string[] answers =
{
    "It is certain.",       "Reply hazy, try again.",     "Don't count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};

var index = new Random().Next(answers.Length - 1);
Console.WriteLine(answers[index]);


//Functions works like this
async static Task<int> Calculate(int a, int b)
{
    return await Task.Run(() => a + b);
}

var result = await Calculate(1, 2);
Console.WriteLine(result);

*/
/*
Top-level statements make it easier to create simple programs for use to explore new algorithms. 
You can experiment with algorithms by trying different snippets of code. Once you've learned what works, you can refactor the code to be more maintainable.

Top-level statements simplify programs that are based on console applications. 
These include Azure functions, GitHub actions, and other small utilities.
 */
