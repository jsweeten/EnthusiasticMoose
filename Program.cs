using System;
using System.Collections.Generic;

var responses = new Dictionary<string, List<string>>()
{
  {"Canada", new List<string>(){"Really? It seems very unlikely.", "I  K N E W  I T !!!"}},
  {"enthusiastic", new List<string>(){"Yay!", "You should try it!"}},
  {"cSharp", new List<string>(){"Good job sucking up to your instructor!", "You will...oh, yes, you will..."}},
  {"secret", new List<string>(){"ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!"}}
};

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    // MooseSays(@"Confess to me your deepest of desires and I shall
    // bestow upon you the knowledge of my Capreolinaeic brain");
    // Console.WriteLine("Ask your question...");
    // Console.ReadLine();
    // MooseAnswer();
    question("Is Canada real?", "Canada");
    question("Are you enthusiastic?", "enthusiastic");
    question("Do you love C# yet?", "cSharp");
    question("Do you want to know a secret?", "secret");
};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
  ");
};

void question(string question, string topic)
{
    if (MooseAsks(question))
    {
        MooseSays(responses[topic][0]);
    }
    else
    {
        MooseSays(responses[topic][1]);
    }
};

// void MooseAnswer()
// {
//     Random r = new Random();
//     int GenRand = r.Next(0, 19);

//     if (GenRand = 0)
//     {
//         MooseSays("As I see it, yes.");
//     }
//     else if (GenRand = 1)
//     {
//         MooseSays("Ask again later.");
//     }
//     else if (GenRand = 2)
//     {
//         MooseSays("Better not tell you now.");
//     }
//     else if (GenRand = 3)
//     {
//         MooseSays("Cannot predict now.");
//     }
//     else if (GenRand = 4)
//     {
//         MooseSays("Concentrate and ask again.");
//     }
//     else if (GenRand = 5)
//     {
//         MooseSays("Don’t count on it.");
//     }
//     else if (GenRand = 6)
//     {
//         MooseSays("It is certain.");
//     }
//     else if (GenRand = 7)
//     {
//         MooseSays("It is decidedly so.");
//     }
//     else if (GenRand = 8)
//     {
//         MooseSays("Most likely.");
//     }
//     else if (GenRand = 9)
//     {
//         MooseSays("My reply is no.");
//     }
//     else if (GenRand = 10)
//     {
//         MooseSays("My sources say no.");
//     }
//     else if (GenRand = 11)
//     {
//         MooseSays("Outlook not so good.");
//     }
//     else if (GenRand = 12)
//     {
//         MooseSays("Outlook good.");
//     }
//     else if (GenRand = 13)
//     {
//         MooseSays("Reply hazy, try again.");
//     }
//     else if (GenRand = 14)
//     {
//         MooseSays("Signs point to yes.");
//     }
//     else if (GenRand = 15)
//     {
//         MooseSays("Very doubtful.");
//     }
//     else if (GenRand = 16)
//     {
//         MooseSays("Without a doubt.");
//     }
//     else if (GenRand = 17)
//     {
//         MooseSays("Yes.");
//     }
//     else if (GenRand = 18)
//     {
//         MooseSays("Yes – definitely.");
//     }
//     else
//     {
//         MooseSays("You may rely on it.");
//     }