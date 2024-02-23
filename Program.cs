int age = 0;

string firstName = string.Empty;

string lastName = string.Empty;

Console.WriteLine("Please Enter Your first Name:");

Console.WriteLine("Please Enter Your last Name:");

firstName = Console.ReadLine();
lastName = Console.ReadLine();

Console.WriteLine("Please Enter Your age:");

age = Convert.ToInt32(Console.ReadLine());

int ageEligibleToWork =62 - age;


Console.WriteLine($"Full Name: {firstName} {lastName}");

Console.WriteLine($"Your working years remaining:{ageEligibleToWork}");

