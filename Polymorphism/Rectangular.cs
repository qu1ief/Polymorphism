namespace Polymorphism;

internal class Rectangular : Figure
{

    public Rectangular(decimal width,decimal length)
    {
        Width = width;
        Length = length;
    }
    private decimal _width;
    private decimal _length;
    public decimal Width
    {
        get => _width; set
        {
            if (value > 0)
            {
                _width = value;
            }
            else
            {
                Console.WriteLine("Duzgun deyer daxil edin");
                throw new Exception();
            }

        }
    }
    public decimal Length
    {

        get => _length; set
        {
            if (value > 0)
            {
                _length = value;
            }
            else
            {
                Console.WriteLine("Duzgun deyer daxil edin");
                throw new Exception();
            }
        }
    }
    public override void CalcArea()
    {
        Console.WriteLine(Width * Length);
    }
}