using BasicCorePgm;
Console.WriteLine("Welcome to basic core program");
Powerof2 basic = new Powerof2();
Console.WriteLine($"Enter any number within 31");
int a = Convert.ToInt32(Console.ReadLine());
basic.Core(a);