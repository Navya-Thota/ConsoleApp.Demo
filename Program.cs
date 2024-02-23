int age = 0;

string name = string.Empty;

Console.WriteLine("Please Enter Your Name:");

name = Console.ReadLine();

Console.WriteLine("Please Enter Your age:");

age = Convert.ToInt32(Console.ReadLine());

int ageEligibleToWork =62 - age;


Console.WriteLine($"Your Name: {name}");

Console.WriteLine($"Your working years remaining:{ageEligibleToWork}");

