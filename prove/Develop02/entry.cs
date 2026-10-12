class Entry
{
    public string _dateField;
    public string _promptField;
    public string _responseField;

    public string toFile() => _dateField +'#'+ _promptField +'#'+ _responseField;

    public void fromFile(string data)
    {
        string[] parts = data.Split("#");

        _dateField = parts[0];
        _promptField = parts[1];
        _responseField = parts[2];
    }
    public void Display()
    {
        Console.WriteLine($"{_dateField} {_promptField}: {_responseField}");
    }
}