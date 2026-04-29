/*
Console.WriteLine("Bu arifmetik amallarini bajarish uchun programma");
Console.WriteLine("Ishbu programmani ishlatish uchun sonlarni va amallarni kiritishingiz kk buladi");

Console.WriteLine("Birinchi son: ");
string str = Console.ReadLine();
decimal userNum1 = Convert.ToDecimal(str);

Console.WriteLine("Ikkinchi son: ");  
string str2 = Console.ReadLine();
decimal userNum2 = Convert.ToDecimal(str2);

// Console.WriteLine("Operator (+, -, *, /): ");
// string oper = Console.ReadLine(); 

Console.WriteLine("Qo'shuv amali: ");
Console.WriteLine(userNum1 + userNum2);

Console.WriteLine("Ayiruv amali: ");
Console.WriteLine(userNum1 - userNum2);

Console.WriteLine("Ko'paytirish amali: ");
Console.WriteLine(userNum1 * userNum2);

Console.WriteLine("Bo'luv amali: ");
Console.WriteLine(userNum1 / userNum2);
*/


Console.WriteLine("Xush kelibsiz!! Silindrni hajmini topish uchun quydagilarni kiriting");

Console.WriteLine("Radius :");
string radius = Console.ReadLine();
double R = Convert.ToDouble(radius);

Console.WriteLine("Balandlik :");
string height = Console.ReadLine();
double h = Convert.ToDouble(height);

const double pi = 3.14;

double V = pi * Math.Pow(R,2) * h;
Console.WriteLine($"V = pi * R^2 * h = {V} ");
