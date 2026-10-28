class Person
{
    private string _firtName;
    private string _lastName;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _firtName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInfo()
    {
        return $"Your first name is:{_firtName} and your last name is:{_lastName}, Age: {_age}, years old and your weight is: {_weight} pounds";
    }
}