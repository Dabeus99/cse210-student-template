class Police : Person
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, double weight, string tools)
    : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;

       
    }

    public string GetDoctorInfo()
    {
        return $"Weapons: {_weapons}: {GetPersonInfo()}";
    }
}