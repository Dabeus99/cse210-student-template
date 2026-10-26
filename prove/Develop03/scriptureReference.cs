

public class scriptureReference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

public scriptureReference(string book, int chapter, int startVerse, int endVerse )
{
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
}

public scriptureReference(string book, int chapter, int verse )
{
    _book = book;
    _chapter = chapter;
    _startVerse = verse;
}

public void DisplayReference()
{
    if(_endVerse != 0){
        
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
    }
    else    
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}");

}
}

