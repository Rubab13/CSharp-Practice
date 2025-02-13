// Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.

// Sample Output:
// Input a string : The quick brown fox jumps over the lazy dog.
// TThe quick brown fox jumps over the lazy dog.T

Console.Write("Input a string: ");
string x = Console.ReadLine();
string newString = "";

if (x.Length >= 1) {
  char ch = x[0];
  newString = ch + x + ch;
}

Console.WriteLine(newString);