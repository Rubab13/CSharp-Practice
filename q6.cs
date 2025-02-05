// Fibonacci Series: Write a program to print the first N numbers of the Fibonacci series.

// Example Input:
// N = 6

// Example Output:
// 0 1 1 2 3 5

Console.Write("Enter a number: ");
string x = Console.ReadLine();
int number = int.Parse(x);

int first = 0;
int second = 1;
Console.Write(first);
Console.Write(" ");
Console.Write(second);

for (int i=0; i<number-2; i++) {
  int newNumber = first + second;
  Console.Write(" ");
  Console.Write(newNumber);
  first = second;
  second = newNumber;
}