class Student
{
    private readonly int[] grades = new int[5];
    public string Name { get; init; }
    private int age;
    public int Age
    {
        get => age;
        init
        {
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Error ...!");
        }
    }

    
    public Student(string name, int age)
    {
      
        Name = name;
        Age = age;
    }
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Length)
            {
                return grades[index];
            }
            throw new IndexOutOfRangeException("Error: Grade index must be between 0 and 4.");
        }
        set
        {
            if (index >= 0 && index < grades.Length)
            {
                grades[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Error: Grade index must be between 0 and 4.");
            }
        }
    }

 
    public bool IsAdult()
    {
        return Age >= 18;
    }
    public int YearsUntilGraduation(int graduationAge = 22)
    {
        if (Age >= graduationAge)
        {
            return 0; 
        }
        return graduationAge - Age;
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age} (Adult: {IsAdult()})");
        Console.WriteLine($"Years until 22: {YearsUntilGraduation()}");
        
        Console.WriteLine($"Grade 1 (Index 0): {this[0]}");
        Console.WriteLine($"Grade 2 (Index 1): {this[1]}");
    }
}