# Price Validator
This solution is aimed at validating fictional stock prices. 
The input prices are provided in the form of a string and are expected to follow certain rules.
If a price does not follow the defined rules, it should be rejected.

## Getting Started

Clone the repository: git clone https://github.com/luisfff/price-validator

Restore dependencies: `dotnet restore`

Run the benchmarks: `dotnet run`

## Validation Criteria
The following criteria must be met for a price to be considered valid:

If a price is entered with a + sign, it means to buy the stocks worth that amount.

If a price is entered with a - sign, it means to sell the currently selected stock worth that amount.

If no sign is entered with the price, the entry should be disregarded.

Prices can be fractional as they are traded in different currencies.

## Approach
To validate the prices, we will use a state machine approach. The initial state is START, and we will process each character in the input string to identify the next state.

 The input string is considered not a valid price if we reach an UNKNOWN state or if it ends in a DECIMAL point.
 
The time complexity of this feature is O(n), where n is the length of the input string. This is because we need to process each character in the string once.

The space complexity of this feature is O(1), as we only need a few variables to keep track of the current state and the sign of the input price.
