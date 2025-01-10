namespace Common { 
            //Q1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
       public enum WeekDays
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

    //Q2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //Q7.Create a struct called "Person" with properties "Name" and "Age". Write a C# prog.
   public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //Q3. Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    public enum Season
    {
        Spring, Summer, Autumn, Winter
    }


    //Q5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
  public  enum Colors
    {
        Red,
        Green,
        Blue
    }


    //Q6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
   public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }





    //Last Question (8)
   public struct Rectangle
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

}

