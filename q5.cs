// Count Occurrences of a Character in a String: Write a program that counts how many times a specific character appears in a string.

// Example Input:
// String: "hello", Character: 'l'

// Example Output:
// 2

Console.Write("Enter a string: ");
string x = Console.ReadLine();

Console.Write("Enter a character: ");
char ch = Console.ReadKey().KeyChar;
Console.WriteLine(); 

int count = 0;
x = x.ToUpper();
ch = char.ToUpper(ch);

for (int i=0; i<x.Length; i++) {
  if (x[i] == ch) {
    count++;
  }
}

Console.WriteLine("The number of times the character "+ch+" appears in the given string is "+count+".")