using BasicCorePgm;
Console.WriteLine("Welcome to basic core program");
HormonicNumber basic = new HormonicNumber();
Console.WriteLine($"Enter any number within 31");
int a = Convert.ToInt32(Console.ReadLine());
basic.Core(a);