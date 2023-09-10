using System;
class MyClass
{
    private string code;
    public MyClass(uint n)
    {
        number = n;

    }
    public override string ToString()
    {
        return code;

    }
    public uint number
    {
        set
        {
            uint num = value;
            code = "";
            do
            {
                code = (num % 2) + code;
                num >>= 1;

            }while(num != 0);
        }
    }

}
class WithoutGetDemo
{
    static void Main()
    {
        MyClass obj = new MyClass(5);
        Console.WriteLine("Binarnii code chisla 5:\t" + obj);
        obj.number = 45;
        Console.WriteLine("Binarnii code chisla 45:\t" + obj);
    }
}