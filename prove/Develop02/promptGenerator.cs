using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class PromptGenerator
{

    public Random _random = new Random();
    public List <string> _prompt = new List<string>([
        "What was the best part of my day?",

"Who was the most interesting person I interacted with today?",

"What was the strongest emotion I felt today, and what triggered it?",

"If I could re-do one moment from today, what would I do differently?",

"What is something small that made me smile or laugh today?"]);
    
    public string Prompt()
    {
        int random_int = _random.Next(_prompt.Count()); 

        return _prompt[random_int];
    }




    

}
