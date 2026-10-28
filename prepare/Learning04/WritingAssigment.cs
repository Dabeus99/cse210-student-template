class WritingAssignment : Assignment
{
    protected string _title;


    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }


   public string GetWritingInformation()
    {
         string GetWritingInformation = $"{_studentName} - {_topic} {_title} by: {_studentName}";
            return GetWritingInformation;  
    }
}