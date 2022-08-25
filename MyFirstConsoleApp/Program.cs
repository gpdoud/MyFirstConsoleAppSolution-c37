// See https://aka.ms/new-console-template for more information

/*
 * 
MAX.Console.Run("Greg");

Console.WriteLine("Hello, World!");

if (true) 
{
    Console.WriteLine("The if statement is true!");
    Console.WriteLine("We want to execute this statemnt also if true");
}

Console.WriteLine("This statement will always execute regardless of the if statement");

MAX.Student sam = new MAX.Student();
sam.Firstname = "Sam";
sam.Lastname = "PHence";
Console.WriteLine(sam.Firstname + " " + sam.Lastname);

MAX.Student caleb = new MAX.Student();
caleb.Firstname = "Caleb";
caleb.Lastname = "Phence";
Console.WriteLine(caleb.Fullname());

MAX.Major math = new MAX.Major();
math.Code = "MATH";
math.Description = "Mathematics";
math.MinSAT = 1200;
math.Print();
*/
MAX.Major bus = new MAX.Major();
bus.Code = "BUS";
bus.Description = "Business";
bus.MinSAT = 400;
bus.Print();
/*
var str = @"tim\tom"; // "tim\\tom"
*/

// variable

var i = 13m;
var j = 3;
var sum = i + j;
var diff = i - j;
var prod = i * j;
var div = i / (decimal)j;

Console.WriteLine($"{sum} | {diff} | {prod} | {div}");

/*
Decimal: 123
    1 x 10^2 + 2 * 10^1 + 3 * 10^0

Hexidecimal: x123
    1 * 16^2 + 2 * 16^1 + 3 * 16^0;
    256 + 32 + 3

*/