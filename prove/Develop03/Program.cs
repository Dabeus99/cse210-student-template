
class Program
{
    static void main(string[] args)
    {
        Word myWord = new Word("Secret");

        myWord. Display();
        myWord.Hide();
        myWord.Display();

        Scripture myScripture = new Scripture("Mosses", 1, 39, "Behold this is my work and my glory to bring to pass the immortality adn eternal life of man");
        myScripture.ShowScripture();
    }
}