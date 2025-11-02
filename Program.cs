using System;

class Cart
{
    private static Cart instance;
    public int Count;

    private Cart() { }

    public static Cart GetInstance()
    {
        if (instance == null)
            instance = new Cart();
        return instance;
    }
}

class Program
{
    static void Main()
    {
        var cart1 = Cart.GetInstance();
        var cart2 = Cart.GetInstance();

        cart1.Count++;
        Console.WriteLine(cart2.Count); // той самий об’єкт
    }
}






