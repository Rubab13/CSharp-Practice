// Write a C# Sharp program that prints the multiplication table of a number as input

Console.Write("Enter a number: ");
string num = Console.ReadLine();
int number = int.Parse(num);

for (int i=1; i<=10; i++) {
  Console.WriteLine(number + " * " + i + " = " + number * i);
}