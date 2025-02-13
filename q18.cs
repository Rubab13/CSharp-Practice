// Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

Console.Write("Enter first number: ");
string num1 = Console.ReadLine();
int number1 = int.Parse(num1);

Console.Write("Enter second number: ");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);

if (number1 == 20 || number2 == 20 || number1 + number2 == 20) {
  Console.WriteLine("True");
}
else {
  Console.WriteLine("False");
}