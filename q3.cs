// Find the Largest of Three Numbers: Write a program that takes three numbers and prints the largest one.

Console.Write("Enter first number: ");
string num1 = Console.ReadLine();
int number1 = int.Parse(num1);

Console.Write("Enter second number: ");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);

Console.Write("Enter third number: ");
string num3 = Console.ReadLine();
int number3 = int.Parse(num3);

if (number1 > number2 && number1 > number3) {
    Console.WriteLine("Number 1 is the greatest.");
}
else if (number2 > number1 && number2 > number3) {
    Console.WriteLine("Number 2 is the greatest.");
}
else {
    Console.WriteLine("Number 3 is the greatest.");
}