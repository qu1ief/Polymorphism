namespace Polymorphism;

internal class Person
{
    private string _name;
    private string _surname;
    public string Name
    {
        get => _name; set
        {
            if (!char.IsUpper(value[0]))
            {
                Console.WriteLine("Ilk herf boyukle baslamalidir");
                throw new Exception();
            }
            if(value.Length<3 || value.Length > 30)
            {
                Console.WriteLine("Adin uzunlugu 3-30 araliginda olmalidir");
                throw new Exception();
            }
            _name = value;
        }
    }
    public string Surname
    {
        get => _surname; set
        {
            if (!char.IsUpper(value[0]))
            {
                Console.WriteLine("Ilk herf boyukle baslamalidir");
                throw new Exception();
            }
            if (value.Length < 3 || value.Length > 35)
            {
                Console.WriteLine("Soyadin uzunlugu 3-35 araliginda olmalidir");
                throw new Exception();
            }
            _surname = value;

        }
    }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;

    }

    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }



}