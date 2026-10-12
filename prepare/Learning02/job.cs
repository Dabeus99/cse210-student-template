
using System.Security.Cryptography.X509Certificates;

public class Job
    {
        //job title, start year, and end year
        //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
        public string _jobTitle = "";
        public string _company = "";
        public int _startYear;
        public int _endYear;
        
    

    public void Display()
    {
        Console.WriteLine($"Name: {_jobTitle}\n Jobs: {_company} {_startYear} {_endYear}");
    }
}  