using StocksDomain;
using StocksDomain.ValidatePrice;

internal class ValidatePriceTest
{
    internal void Validate()
    {
        Console.WriteLine("Is the price valid +40.325? " + ValidatePrice.IsPriceValid("+40.325"));
        Console.WriteLine("Is the price valid -1.1.1? " + ValidatePrice.IsPriceValid("-1.1.1"));
        Console.WriteLine("Is the price valid -222? " + ValidatePrice.IsPriceValid("-222"));
        Console.WriteLine("Is the price valid ++22? " + ValidatePrice.IsPriceValid("++22"));
        Console.WriteLine("Is the price valid 10.1? " + ValidatePrice.IsPriceValid("10.1"));
        Console.WriteLine("Is the price valid +22.22.? " + ValidatePrice.IsPriceValid("22.22."));
        Console.WriteLine("Is the price valid .100? " + ValidatePrice.IsPriceValid(".100"));
    }
}