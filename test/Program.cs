System.Console.InputEncoding = System.Text.Encoding.GetEncoding(1251);

Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if (username.ToLower().Equals("маша", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("да!");
}
else
{
    Console.Write("нет, ");
    Console.Write(username);}