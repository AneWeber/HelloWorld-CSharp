namespace HelloWorld;
class Hello
{
    public void HelloUser()
    {
        Console.WriteLine("Welcome, What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Welcome to this page!");

        Console.WriteLine($"What is your surname?");
        string userSurname = Console.ReadLine();

        Console.WriteLine($"{userName} {userSurname}! That is a lovely name!");
    }
}