// Write a program that reverses a given string without using built-in string manipulation methods.

Console.Write("Enter a string: ");
string x = Console.ReadLine();
string reverse = "";

for (int i=0; i<x.Length; i++) {
  char ch = x[i];
  reverse = ch + reverse;
}

Console.WriteLine("The reverse of the given string is " + reverse + ".");