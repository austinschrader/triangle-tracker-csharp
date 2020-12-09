## C# & .NET Triangle Classifier with Testing

Fun C# & .NET program that allows the user to enter 3 inputs on the command line. The program will take those 3 inputs and say whether it's a triangle or not, as well as identify the triangle type!

By Austin Schrader & Tyler Sinks

## Description

This project was created by Austin Schrader and Tyler Sinks for week 1 of C# and uses C#/.NET to build a console triangle classifier application.

## Setup

_C# and .NET needs to be installed for this project to work. If you do not have it, please go to [here for Windows](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) and [here for MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer)._

1. Download this repository by clicking the "Clone or Download" button
2. Navigate to the folder where it downloaded
3. Now open your terminal and navigate to Triangle.Solution > Triangle.Tests
4. Type in `dotnet restore` to download necessary packages
5. Then type in `dotnet run` to run the application
6. Congratulations, this is the program!
7. To get an output, enter 3 values one-at-a-time

## Specs

Describe: IsTriangle()

Test: "should correctly identify that three user input side lengths cannot make a triangle"
Expect: (input(-10, 5, 3).toEqual(false))

Test: "should correctly identify that three side lengths can make a triangle"
Expect: (input(4, 4, 4).toEqual(true))

Describe: EvaluateTriangle()

Test: "should correctly identify an equilateral triangle"
Expect: (input(4, 4, 4).toEqual("equilateral"));

Test: "should correctly identify an isosceles triangle"
Expect: (input(4, 4, 5).toEqual("isosceles"));

Test: "should correctly identify a scalene triangle"
Expect(input(3, 4, 5).toEqual("scalene"));

## Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

## Technologies Used

- C#
- .NET
- Object Oriented Programming
- MSTest

## License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Austin Schrader and Tyler Sinks_
