Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ириша")
{
    Console.WriteLine("Ура, это же ИРИША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}