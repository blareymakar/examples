Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "Маша")
{
    Console.WriteLine("О, Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}


