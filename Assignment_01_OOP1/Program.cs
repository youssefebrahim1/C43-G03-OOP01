using System;
//Q1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
enum WeekDays
{
    Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
}


 //Q2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
/*
struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
*/



//Q3. Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

enum Season
{
    Spring,Summer,Autumn,Winter
}


//Q5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
enum Colors
{
    Red,
    Green,
    Blue
}

//Q6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
struct Point
{   
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

//Q7.Create a struct called "Person" with properties "Name" and "Age". Write a C# prog.
struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
//Last Question (8)
struct Rectangle
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Width cannot be negative.");
            }
            else
            {
                width = value;
            }
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Height cannot be negative.");
            }
            else
            {
                height = value;
            }
        }
    }

    public double Area
    {
        get { return width * height; }
    }

    public void Info()
    {
        Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {Area}");
    }
}


  
  
  
    


class Program
{
    static void Main(string[] args)
    {
        /*
        #region Q1.
        foreach (var day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
        #endregion
        */
        /*
        #region Q2.
            Person[] persons = new Person[3];
            persons[0] = new Person { Name = "Youssef", Age = 24 };
            persons[1] = new Person { Name = "Karim", Age = 35 };
            persons[2] = new Person { Name = "Mohamed", Age = 40 };

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
    #endregion
        */
        /*
        #region Q3.
        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
        string input = Console.ReadLine();
        if (Enum.TryParse(input, true, out Season season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Incorrect Data");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    
    #endregion
        */
        /*
        #region Q5.
        Console.WriteLine("Enter a color (Red, Green, Blue): ");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Colors color))
        {
            Console.WriteLine($"{color} is a primary color.");
        }
        else
        {
            Console.WriteLine($"{input} is not a primary color.");
        }
    
    #endregion
        */
        /*
        #region Q6. 
        try
        {
            Console.WriteLine("Enter coordinates for Point 1 (X Y): ");
            var input1 = Console.ReadLine()?.Split();
            if (input1 == null || input1.Length != 2)
                throw new FormatException("Invalid input for Point 1. Please enter two numbers separated by a space.");

            var p1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

            Console.WriteLine("Enter coordinates for Point 2 (X Y): ");
            var input2 = Console.ReadLine()?.Split();
            if (input2 == null || input2.Length != 2)
                throw new FormatException("Invalid input for Point 2. Please enter two numbers separated by a space.");

            var p2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

            double distanceSquared = (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
            Console.WriteLine($"Square of the distance between the points: {distanceSquared:F2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Input error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        #endregion
        */
        /*
        #region Q7. 
        Person[] persons = new Person[3];

        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            persons[i] = new Person { Name = name, Age = age };
        }

        Person oldest = persons[0];
        foreach (var person in persons)
        {
            if (person.Age > oldest.Age)
            {
                oldest = person;
            }
        }
            Console.WriteLine($"The oldest person is {oldest.Name}, aged {oldest.Age}.");
            #endregion
        */
        /*
        #region LastQuestion
        Rectangle rect = new Rectangle();

        Console.WriteLine("Enter the width of the rectangle:");
        rect.Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle:");
        rect.Height = Convert.ToDouble(Console.ReadLine());

        rect.Info();

        #endregion
        */




    }
}

