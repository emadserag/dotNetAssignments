/*Q1
Person[] friends = new[]
{
    new Person("Ali", 30),
    new Person("Sara", 25),
    new Person("Mohamed", 35)
};
foreach (var friend in friends)
{
    Console.WriteLine($"Name: {friend.Name}, Age: {friend.Age}");
} */

//Q2 // -------------------------------------------------------------------


/*
 using Struct_and_Encapsulation.mouduls;
Point p1;
Point p2;
Console.WriteLine("Enter coordinates for the first point (P1):");
Console.Write("Enter X1: ");
p1.X = double.Parse(Console.ReadLine());

Console.Write("Enter Y1: ");
p1.Y = double.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates for the second point (P2):");
Console.Write("Enter X2: ");
p2.X = double.Parse(Console.ReadLine());

Console.Write("Enter Y2: ");
p2.Y = double.Parse(Console.ReadLine());


// Calculate the differences

double squaredDistance = Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2);

double distance = Math.Sqrt(squaredDistance);

// 5. Print the distance to the console
// We use string formatting ("F3") to display three decimal places
Console.WriteLine($"\nDistance between points = {distance:F3}");
 */

//Q3 -------------------------------------------------------------------------------
/*
Person[] friends = new Person[3];

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine($"\nEnter details for Person {i + 1}:");

    // Get Name
    Console.Write("Name: ");
    friends[i].Name = Console.ReadLine();
    Console.Write("Age: ");
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        friends[i].Age = age;
    }
    else
    {
        Console.WriteLine("Invalid age entered. Setting age to 0.");
        friends[i].Age = 0;
    }
}


Person oldestPerson = friends[0];

for (int i = 1; i < friends.Length; i++)
{
    if (friends[i].Age > oldestPerson.Age)
    {
        oldestPerson = friends[i];
    }
}
// Print the result

Console.WriteLine($"Oldest person: {oldestPerson.Name}, Age: {oldestPerson.Age}");
*/

//Q4 -------------------------------------------------------------------------------
/* Rectangle rect = new Rectangle();
rect.Width = 10;
rect.Height = 5;

Console.WriteLine("--- Initial Dimensions ---");

rect.DisplayInfo();

Console.WriteLine("--- Attempting Invalid Set ---");
rect.Width = -3;


Console.Write("Current Dimensions: ");
rect.DisplayInfo(); 

Console.WriteLine("--- Changing Height ---");
rect.Height = 8;

//  display
rect.DisplayInfo();*/

// Q5 -------------------------------------------------------------------------------
/*
BankAccount userA = new BankAccount("A100", 1500.00);
BankAccount userB = new BankAccount("B200");

userA.DisplayAccount();
userB.DisplayAccount();

Console.WriteLine("================== Indexer Test ==================");
userA[1] = 2000.00; // EUR 
userA[2] = 5000.00; // Dolar

Console.WriteLine($"UserA's EUR Balance (Index 1): {userA[1]:N2}");
userA.DisplayAccount();

Console.WriteLine("\n================== Transaction Test ==================");
userA.Deposit(500);
userA.Withdraw(100);
userA.Withdraw(50000);


Console.WriteLine("\n================== Transfer Test ==================");
userA.TransferTo(userB, 700.00);
userA.TransferTo(userB, 5000.00);
*/

// Q6 -------------------------------------------------------------------------------
/*
Student s1 = new Student("Khaled", 19);

s1[0] = 90;
s1[1] = 85;
s1[2] = 78;

Console.WriteLine($"Testing Student: {s1.Name}");
Console.WriteLine($"Grade at index 0: {s1[0]}"); 

s1.DisplayStudent();

Student s2 = new Student("Noura", 15);
s2.DisplayStudent();
Console.WriteLine("--- Testing Invalid Initialization ---");
try
{
    Student s_invalid = new Student("ErrorTest", -5);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}*/
// Q7 -------------------------------------------------------------------------------
/*
Car modernCar = new Car(2025);
Car classicCar = new Car(1965, "Ford");

int thisYear = DateTime.Now.Year;
modernCar[thisYear] = 500.50;
modernCar[thisYear - 1] = 450.00;

Console.WriteLine($"Modern Car's cost for {thisYear}: {modernCar[thisYear]:C}"); 
Console.WriteLine($"Classic Car's cost for {2000}: {classicCar[2000]:C}"); 

modernCar.UpdateYear(1800); 
modernCar.UpdateYear(2025); 

modernCar.DisplayCar();
classicCar.DisplayCar();
*/
