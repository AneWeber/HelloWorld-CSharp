namespace HelloWorld;
class Continue
{
    public void NextStep(string question)
    {
        Console.WriteLine(question);
        Console.WriteLine("Type Y/N");
        string answer = Console.ReadLine();

        if (answer?.ToUpper() != "Y")
        {
            Console.WriteLine("Goodbye!");
            return;
        }
        Console.WriteLine("Great! Let's keep going.");
    }
}
