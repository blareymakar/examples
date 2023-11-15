Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "maria")
{
    Console.WriteLine("ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}

