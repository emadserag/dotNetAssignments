public class Car
{
    private Dictionary<int, double> maintenanceCosts = new Dictionary<int, double>();


    public string Brand { get; set; } = "Toyota";

    public int Year { get; private set; } 

   

    public Car(int year, string brand = "Toyota")
    {
        Brand = brand;
       
        UpdateYear(year);
    }

    public double this[int year]
    {
        get
        {
          
            return maintenanceCosts.GetValueOrDefault(year, 0.0);
        }
        set
        {
         
            maintenanceCosts[year] = value;
        }
    }
    public void UpdateYear(int year)
    {
        const int firstCarYear = 1886;
        if (year >= firstCarYear && year <= DateTime.Now.Year + 1) 
        {
            Year = year;
        }
        else
        {
            Console.WriteLine($"\nError: Invalid year ({year}). Year must be between {firstCarYear} and {DateTime.Now.Year + 1}.");
        }
    }
    public int CarAge()
    {
   
        return DateTime.Now.Year - Year;
    }

   
    public bool IsClassic()
    {
        return CarAge() > 25;
    }
    public void DisplayCar()
    {
        Console.WriteLine($"\n--- Car Details ---");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Age: {CarAge()} years");
        Console.WriteLine($"Status: {(IsClassic() ? "Classic " : "Modern")}");

        int currentYear = DateTime.Now.Year;
        Console.WriteLine($"Maintenance Cost for {currentYear}: {this[currentYear]:C}");
    }
}