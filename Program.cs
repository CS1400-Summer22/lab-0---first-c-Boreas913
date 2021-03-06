// See https://aka.ms/new-console-template for more information
Console.Clear();
string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maria";
Console.WriteLine ($"Hello {aFriend}");
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine ($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine ($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine ($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");

Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine (songLyrics.StartsWith ("You"));
Console.WriteLine (songLyrics.StartsWith ("goodbye"));
Console.WriteLine (songLyrics.EndsWith ("goodbye"));
Console.WriteLine (songLyrics.EndsWith ("hello"));

string rickroll = "Never gonna give you up";
Console.WriteLine (rickroll);
Console.WriteLine (rickroll.EndsWith ("Let you down"));
Console.WriteLine (rickroll.EndsWith ("turn around"));
Console.WriteLine (rickroll.EndsWith ("and desert you"));
Console.WriteLine (rickroll.StartsWith ("Never gonna"));

rickroll = rickroll.Replace("give you up", "let you down");
Console.WriteLine(rickroll);