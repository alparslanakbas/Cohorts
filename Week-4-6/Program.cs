using Week_4_6;

Employee person = new("Alparslan Akbas", "Arge", "Software Developer");
person.WriteToConsole();

Console.WriteLine();

Employee unknownPerson = new("Alparslan Akbas", null ,"Software Developer");
unknownPerson.WriteToConsole();