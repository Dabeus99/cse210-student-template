class MathAssignment : Assignment
{
    protected string _textBook;
    protected string _problems;


    public MathAssignment(string studentName, string topic, string textBook, string problems) : base(studentName, topic)
    {
        _textBook = textBook;
        _problems = problems;
    }

 

    public string GetHomeworkList()
    {
        string GetHomeworkList = $"{_studentName} - {_topic}\n {_textBook} {_problems}";
            return GetHomeworkList;  
    }

}


