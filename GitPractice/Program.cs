Console.WriteLine("Hello, World!");

NumMonster cookie = new NumMonster();

class Number
{
    public static int RandomNumber()
    {
        return new Random().Next(1, 101);
    }
}

class NumMonster
{
    public int num;
    public NumMonster()
    {
        num = Number.RandomNumber();
        Console.WriteLine(num);
    }
}