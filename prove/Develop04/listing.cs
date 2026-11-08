class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on good things by listing as many as you can.")
    {
    }

    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine(_prompts[index]);
        RunCountDown("Begin listing in...", 5);

        int count = 0;
Timer();

while (!HasTimerExpired())
{
    Console.Write("> ");
    string answer = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(answer))
    {
        count++;
    }
}

Console.WriteLine($"You listed {count} items.");
DisplayEnding();
    }
}