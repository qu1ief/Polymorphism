namespace Polymorphism;

internal class Square : Figure
{

    public Square(decimal side)
    {
        Side = side;
    }
    private decimal _side;
    public decimal Side
    {
        get => _side;
        set
        {
            if (value > 0)
            {
                _side = value;
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
        Console.WriteLine(Side * 4);
    }
}
