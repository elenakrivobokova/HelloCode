Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "лена")
{
  Console.WriteLine("Ура, это же Лена!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}