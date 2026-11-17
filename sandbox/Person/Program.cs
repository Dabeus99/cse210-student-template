class Program
{

    public static void DisplayPersonInformation(Person person)
  {
    // if (person is Doctor d)
    // {
    //   Console.WriteLine(d.GetDoctorInformation());
    // } 
    // else if (person is Police p)
    // {
    //   Console.WriteLine(p.GetPoliceInformation());
    // }
    // else
    // {
    Console.Write($"Sallary{person.GetSalary()}");
      Console.WriteLine(person.GetPersonInformation());
    }
  
    public static void Main()
    {
       Person myPerson = new Person("John", "Doe", 30, 180.5);

          Doctor myDoctor = new Doctor("Bob", "Doe", 30, 400, "knife");

      Police myPolice = new Police("Gary", "GooMan", 61, 181, "Guns");



        List<Person> myPeople = new List<Person>();

        //myPeople.Add(myPerson); you can no longer dreate a instance of a base class
        myPeople.Add(myPerson);
        myPeople.Add(myPerson);

        foreach(Person person in myPeople)
    {
      DisplayPersonInformation(person);
    }
    

    }
}