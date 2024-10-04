namespace Polymorphism;

internal abstract class Figure
{
    public abstract void CalcArea();
}


internal class Student : Person
{
    public Student(string name, int age, int point) : base(name, age)
    {
        Point = point;
    }

    private int _point;
    public int Point
    {
        get => _point; set
        {
            if(value<0 ||  value > 100)
            {
                Console.WriteLine("Point 0-100 araliginda olmalidir");
                throw new Exception();
            }
            _point = value;


        }
    }
}