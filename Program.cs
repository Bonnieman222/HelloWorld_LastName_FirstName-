// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    // this says words
Console.WriteLine("What is your first name buckaroo?");
    //this asks for input
string firstNameinput  = Console.ReadLine();
    //this is  prepares for an output
Console.WriteLine($"So your first name is {firstNameinput}, so what is your last name?");
    //this is both giving output and asking for input
string lastNameinput = Console.ReadLine();
    //this also preps for output
Console.WriteLine($"So your full name is {firstNameinput} {lastNameinput}.");
    //in this world it's output or be output
Console.WriteLine($"Well howdy then {firstNameinput} {lastNameinput}!");
    //it's the final output