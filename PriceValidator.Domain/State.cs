namespace PriceValidator.Domain;

public enum State
{
    Start,
    Integer,
    Decimal,
    Unknown,
    AfterDecimal
};