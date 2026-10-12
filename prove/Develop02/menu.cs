class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load a journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter a number from 1 to 5: ");


            if (!int.TryParse(Console.ReadLine(), out input))
            {
                input = 0;
            }

            if (input < 1 || input > 5)
            {
                Console.WriteLine("Inalid choice. Please enter a number from 1 to 5.");
            }
        }
        return input;   
    }




}