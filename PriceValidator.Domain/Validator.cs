namespace PriceValidator.Domain
{
    public class Validator
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
            return currentState switch
            {
                State.Start => ch switch
                {
                    '.' => State.Decimal,
                    >= '0' and <= '9' => State.Integer,
                    _ => State.Unknown
                },
                State.Integer => ch switch
                {
                    '.' => State.Decimal,
                    >= '0' and <= '9' => State.Integer,
                    _ => State.Unknown
                },
                State.Decimal => ch is >= '0' and <= '9' ? State.AfterDecimal : State.Unknown,
                State.AfterDecimal => ch is >= '0' and <= '9' ? State.AfterDecimal : State.Unknown,
                State.Unknown => State.Unknown,

                _ => throw new ArgumentOutOfRangeException(nameof(currentState), currentState, null)
            };
        }
    }
}