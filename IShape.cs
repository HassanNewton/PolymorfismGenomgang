namespace PolymorfismGenomgang;

class Program
{
    public interface IShape
    {
        double Area();
    }

    public class Circle : IShape
    {
        //Egenskaper
        public double Radius { get; set; }

        //Konstruktor
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        //Metod
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }


    public static double TotalArea(List<IShape> lista)
    {
        double total = 0;

        foreach(IShape shape in lista)
        {
            total += shape.Area();
        }

        return total;
    }

    //static void Main(string[] args)
    //{
    //    IShape circle = new Circle(20);
    //    IShape rectangle = new Rectangle(10, 20);

    //    List<IShape> list = new List<IShape> { circle, rectangle };
    //    double total = TotalArea(list);

    //    Console.WriteLine($"Den totala arean för alla figurer är {total} a.e");
    //}
}

