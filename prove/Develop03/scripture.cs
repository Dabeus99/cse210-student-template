using System.Runtime.CompilerServices;

class Scripture 
{
    //Attributes
    private List<Word> _words;
    
  

    //constructor

    public Scripture(string bookName, int chapter, int verse, string text) {
        
        _words = ConvertToWordList(text);
        
    }

     public Scripture(string bookName, int chapter, int verse, int endVerse, string text) {
        
        
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    //todo add sctiptrue consturctor refferecne


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