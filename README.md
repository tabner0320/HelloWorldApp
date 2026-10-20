# HelloWorldApp

A C# console application that generates five pairs of random numbers and displays their addition and subtraction results.

## Features

- Generates numbers from 1 through 99.
- Displays five addition and five subtraction equations.
- Reuses one random number generator.
- Separates each pair of equations with a blank line.

## Technologies

- C#
- .NET
- Git and GitHub

## How to Run

Install the .NET SDK version required by `HelloWorldApp.csproj`, then run:

```bash
git clone https://github.com/tabner0320/HelloWorldApp.git
cd HelloWorldApp
dotnet run
```

## Example Output

```text
Generate equations for addition and subtraction:
7 + 29 = 36
7 - 29 = -22

88 + 80 = 168
88 - 80 = 8
```

The program displays five pairs of equations. Numbers will vary between runs.

## Concepts Practiced

- Variables and integers
- For loops
- Random number generation
- String interpolation
- Arithmetic operators
- Refactoring for readability