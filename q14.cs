// Write a C# Sharp program to swap two numbers.

// Test Data:
// Input the First Number : 5
// Input the Second Number : 6

// Expected Output:
// After Swapping :
// First Number : 6
// Second Number : 5

Console.Write("Input first number: ");
string num1 = Console.ReadLine();
int number1 = int.Parse(num1);

Console.Write("Input second number:");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);

int temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine("\nAfter swapping:");
Console.WriteLine("First Number: " + number1 + "\nSecond Number: " + number2);