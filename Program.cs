Console.WriteLine("Bu arifmetik amallarini bajarish uchun programma");
Console.WriteLine("Ishbu programmani ishlatish uchun sonlarni va amallarni kiritishingiz kk buladi");

Console.WriteLine("Birinchi son: ");
decimal userNum1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ikkinchi son: ");  
decimal userNum2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Operator (+, -, *, /): ");
string oper = Console.ReadLine(); 

decimal result;

if (oper == "*")  
{
    result = userNum1 * userNum2;
    Console.WriteLine($"Natija: {userNum1} * {userNum2} = {result}");
}
else if (oper == "+")
{
    result = userNum1 + userNum2;
    Console.WriteLine($"Natija: {userNum1} + {userNum2} = {result}");
}
else if (oper == "-")
{
    result = userNum1 - userNum2;
    Console.WriteLine($"Natija: {userNum1} - {userNum2} = {result}");
}
else if (oper == "/")
{
    if (userNum2 != 0)
    {
        result = userNum1 / userNum2;
        Console.WriteLine($"Natija: {userNum1} / {userNum2} = {result}");
    }
    else
    {
        Console.WriteLine("Xato: Nolga bo'lish mumkin emas!");
    }
}
else
{
    Console.WriteLine("Xato: Noto'g'ri operator!");
}