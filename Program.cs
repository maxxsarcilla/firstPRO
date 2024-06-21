namespace firstPRO

{
     class Program 
     {
        static void Main(string[] args)
        {
            string FirstName = "Macky";
            string MiddleName = "Candelaria";
            string LastName = "Sarcilla";
            int Age = 24;
            String Gender = "Female";

            string FullName = ($"{FirstName} {MiddleName} {LastName}");

            System.Console.WriteLine($"My Name is {FullName}. My Gender is {Gender}. My Age is {Age} years old.");
        } 
     }    
}