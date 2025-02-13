// Write a program that takes a number and calculates the sum of its digits.
// I am not including checks in this. I'll believe that the user will enter a valid number.

Console.Write("Enter a number: ");
string number = Console.ReadLine();
int sum = 0;
int digit;

for (int i=0; i<number.Length; i++) {
  digit = number[i]  - '0';
  sum = sum + digit;
}

Console.WriteLine("The sum of the digits of the given number is " + sum);