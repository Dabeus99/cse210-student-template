using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;

        JournalEntry journal = new JournalEntry();



        while (response != 5)
        {

        response = myMenu.ProcessMenu();
        switch (response)
        {
            case 1:
                Console.WriteLine("Create");
                    journal.newEntry();
                break;
            case 2:
                Console.WriteLine("Display");
                    journal.display();
                break;
            case 3:
                Console.WriteLine("Save");
                    journal.ToFile("fileSave.txt");
                break;
            case 4:
                Console.WriteLine("Load");
                journal.FromFile("fileSave.txt");
                break;
            case 5:
                Console.WriteLine("Quite");
                break;
        }
        }
    }
}