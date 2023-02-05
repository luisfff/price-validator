using PriceValidator.Domain;

namespace PriceValidatorRun;

internal class ValidatePriceTest
{
    internal void Validate()
    {
        Console.WriteLine("Is the price valid +40.325? " + Validator.IsPriceValid("+40.325"));
        Console.WriteLine("Is the price valid -1.1.1? " + Validator.IsPriceValid("-1.1.1"));
        Console.WriteLine("Is the price valid -222? " + Validator.IsPriceValid("-222"));
        Console.WriteLine("Is the price valid ++22? " + Validator.IsPriceValid("++22"));
        Console.WriteLine("Is the price valid 10.1? " + Validator.IsPriceValid("10.1"));
        Console.WriteLine("Is the price valid +22.22.? " + Validator.IsPriceValid("22.22."));
        Console.WriteLine("Is the price valid .100? " + Validator.IsPriceValid(".100"));
    }
}