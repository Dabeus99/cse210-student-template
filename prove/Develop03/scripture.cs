using System.Runtime.CompilerServices;

class Scripture 
{
    //Attributes
    private List<Word> _words = new List<Word>();

    private scriptureReference _refference;

    //constructor

    public Scripture(scriptureReference refference, List<Word> words) {
        _refference = refference;
        _words = words;
        
    }

    public void HideRandomWords()
    {
        
    }



    public bool completelyHidden()
    {
        bool isBlank = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                break;
            }
            else
            {
                
            }
        
        }
    }

    
    private void Display()
    {
        Console.WriteLine($"{}");
    }
}