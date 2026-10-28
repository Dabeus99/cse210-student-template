class Program
{
    public static void Main(string[] args)
    {
       Person myPerson = new Person("John", "Doe", 30, 180.5);
         Console.WriteLine(myPerson.GetPersonInfo());

          Doctor myDoctor = new Doctor("Bob", "Doe", 30, 400, "knife");
        Console.WriteLine(myDoctor.GetPersonInfo());

        Console.WriteLine(myDoctor.GetDoctorInfo());
    }
}