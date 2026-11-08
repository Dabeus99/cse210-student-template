class Program
{
    public static void Main(string[] args)
    {
       Person myPerson = new Person("John", "Doe", 30, 180.5);
         Console.WriteLine(myPerson.GetPersonInfo());

          Doctor myDoctor = new Doctor("Bob", "Doe", 30, 400, "knife");
        Console.WriteLine(myDoctor.GetPersonInfo());

        Console.WriteLine(myDoctor.GetDoctorInfo());

      Police myPolice = new Police("Gary", "GooMan", 61, 181, "Guns");
      Console.WriteLine(myPolice.GetPoliceInformation());



        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myPerson);
        myPeople.Add(myPerson);

        foreach(Person person in myPeople)
    {
      if (person )
      Console.WriteLine(person.GetPersonInformation());
    }

    }
}