namespace StocksDomain.ValidatePrice
{
    public class ValidatePrice
    {
        public static bool IsPriceValid(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }

            var i = 0;
            if (s[i] == '+' || s[i] == '-')
            {
                ++i;

                var currentState = State.Start;
                while (i < s.Length)
                {
                    currentState = GetNextState(currentState, s[i]);

                    if (currentState == State.Unknown)
                    {
                        return false;
                    }

                    i += 1;
                }

                return currentState != State.Decimal;
            }

            return false;
        }

        private static State GetNextState(State currentState, char ch)
        {
            switch (currentState)
            {
                case State.Start:
                case State.Integer:
                    return ch switch
                    {
                        '.' => State.Decimal,
                        >= '0' and <= '9' => State.Integer,
                        _ => State.Unknown
                    };
                case State.Decimal:
                    return ch is >= '0' and <= '9' ? State.AfterDecimal : State.Unknown;
                case State.AfterDecimal:
                    return ch is >= '0' and <= '9' ? State.AfterDecimal : State.Unknown;
                case State.Unknown:
                    return State.Unknown;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currentState), currentState, null);
            }
        }
    }
}