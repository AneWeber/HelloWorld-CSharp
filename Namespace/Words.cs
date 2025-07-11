namespace HelloWorld;
class Words
{
    public void CountLetters()
    {
        Console.WriteLine("Write to me a word or a sentece, and I will tell how many characters it has");
        string wordInput = Console.ReadLine();
        if (string.IsNullOrEmpty(wordInput))
        {
            Console.WriteLine("You didn't write anything! Please try again.");
            CountLetters();
            return;
        }
        wordInput = wordInput.Replace(" ", "");
        int letterCount = wordInput.Length;
        Console.WriteLine($"The word or sentence you wrote has {letterCount} characters.");
        Console.WriteLine("Would you like to count the letters again? (Y/N)");
        if (Console.ReadLine()?.ToUpper() == "Y")
        {
            CountLetters();
        }
        else
        {
            Console.WriteLine("Hope you enjoyed the characters counter");
        }
    }

}
