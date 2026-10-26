using System.Runtime.CompilerServices;

class Scripture 
{
    //Attributes
    private List<Word> _words;
    private scriptureReference _reference;

    //constructor

    public Scripture(string bookName, int chapter, int verse, string text) {
        _reference = new scriptureReference(bookName, chapter, verse);
        _words = ConvertToWordList(text);
       
        
    }

     public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text) {
        
        _reference = new scriptureReference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWordList(text);
    }


    public void HideRandomWords()
    {
        Random randomWord = new Random();
        for(int i = 0; i < 3; i++)
        {
            int RandomIndex = randomWord.Next(_words.Count);
            _words[RandomIndex].Hide();
        }
    }

        public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
    public void ShowScripture()
    {

        _reference.DisplayReference();
        
        foreach(Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }

        Console.WriteLine();
    }





private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }

}