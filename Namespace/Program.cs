namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is my first C# program, I'm learning the basics. Are you ready to start this journey with me?");
             
        Continue nextStep = new Continue();
        nextStep.NextStep("Are you ready to start this journey with me?");

        Hello userIntro = new Hello();

        userIntro.HelloUser();

        nextStep.NextStep("Should we play a bit with numbers?");

        Math math = new Math();
        math.DoMath();

        nextStep.NextStep("How about we play a bit with words now?");

        Words words = new Words();
        words.CountLetters();

        Console.WriteLine("Thank you for joining me on this journey! I hope we both learned something new today.");

    }
}