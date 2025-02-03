// Check if a Number is Even or Odd: Write a program that takes a number and prints whether it is even or odd.

Console.Write("Enter a number: ");
string num = Console.ReadLine();
int number = int.Parse(num);

if (number % 2 == 0) {
    Console.WriteLine("The number is an even number.");
}
else {
    Console.WriteLine("The number is an odd number.");
}