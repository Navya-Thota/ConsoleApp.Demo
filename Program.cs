int age = 0;

string firstName = string.Empty;

string lastName = string.Empty;
decimal salary =0;
char gender = char.MinValue;
bool working = false;

Console.WriteLine("Please Enter Your first Name:");

firstName = Console.ReadLine();

Console.WriteLine("Please Enter Your last Name:");

lastName = Console.ReadLine();

Console.WriteLine("Please Enter Your age:");

age = Convert.ToInt32(Console.ReadLine());

int ageEligibleToWork =62 - age;

Console.WriteLine("Enter your salary:");
salary= Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter your gender(M/F):");
gender =Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you Working?:");
working=Convert.ToBoolean(Console.ReadLine());


Console.WriteLine($"Full Name: {firstName} {lastName}");

Console.WriteLine($"Your working years remaining:{ageEligibleToWork}");

Console.WriteLine($"Your Salary is:{salary}");

Console.WriteLine($"Your gender is:{gender}");
Console.WriteLine($"Your working status{working}");

