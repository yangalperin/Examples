Console.Write("введите имя пользователя: ");
string usermame = Console.ReadLine();
Double numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
Double numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
Double result = numberA / numberB;
if(result < 1)
{
Console.WriteLine(result);
Console.Write(usermame);
Console.WriteLine(", херовый результат!");
}
else
{
    Console.WriteLine(result);
    Console.Write(usermame);
    Console.WriteLine(" - молодец");
}
