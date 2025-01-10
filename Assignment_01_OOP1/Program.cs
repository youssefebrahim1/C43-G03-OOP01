using System;
using Common;
class Program
{
    static void Main(string[] args)
    {
        
        #region Q1.
        foreach (var day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
        #endregion
        
        
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
        
        
        #region Q5.
        Console.WriteLine("Enter a color (Red, Green, Blue): ");
        string inputt = Console.ReadLine();

        if (Enum.TryParse(input, true, out Colors color))
        {
            Console.WriteLine($"{color} is a primary color.");
        }
        else
        {
            Console.WriteLine($"{inputt} is not a primary color.");
        }
    
    #endregion
        
        
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
        
        
        #region Q7. 
        Person[] personss = new Person[3];

        for (int i = 0; i < personss.Length; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            persons[i] = new Person { Name = name, Age = age };
        }

        Person oldest = personss[0];
        foreach (var person in personss)
        {
            if (person.Age > oldest.Age)
            {
                oldest = person;
            }
        }
            Console.WriteLine($"The oldest person is {oldest.Name}, aged {oldest.Age}.");
            #endregion
        
        
        #region LastQuestion
        Rectangle rect = new Rectangle();

        Console.WriteLine("Enter the width of the rectangle:");
        rect.Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle:");
        rect.Height = Convert.ToDouble(Console.ReadLine());

        rect.Info();

        #endregion
        




    }
}

