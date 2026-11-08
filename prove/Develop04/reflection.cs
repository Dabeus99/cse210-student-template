class ReflectionActivity : BaseActivity
{

        private List<string> _questions = new List<string>
{
    "Why was this experience meaningful to you?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What did you learn about yourself?",
    "How could this experience help you in the future?"
};

private List<string> _prompts = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times when you showed strength and resilience.")
    {
    }



    public void RunActivity()
    {
       
        StartActivity();

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];

        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter when you have an experience in mind.");
        Console.ReadLine();

        Timer();

        while (!HasTimerExpired())
        {
            int index = random.Next(_questions.Count);
            DisplaySpinner(_questions[index] +" ", 5);
        }

        DisplayEnding();
    }
}