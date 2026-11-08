class BreathingActivity: BaseActivity
{
    
    public BreathingActivity()
    : base(
        "Breathing Activity",
        "This activity will help you relax by breakthing in and out slowly.")
    {
        
    }
    public void RunActivity()
    {
        StartActivity();
        Timer();
        
        while (!HasTimerExpired())
        {
           RunCountDown("Breath in...", 4);
           RunCountDown("Breathe out...", 6);
        }

        DisplayEnding();
    }
}