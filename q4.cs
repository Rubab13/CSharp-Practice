// Palindrome Check: Write a program that checks whether a given string is a palindrome or not (a word that reads the same forwards and backwards).

// Example Input:
// "madam"

// Example Output:
// True

Console.Write("Enter a string: ");
string x = Console.ReadLine();
string y = "";

for (int i=x.Length-1; i>=0; i--) {
  y = y + x[i];
}

x = x.ToUpper();
y = y.ToUpper();

if (x.Equals(y)) {
  Console.WriteLine("The string is a palindrome.");
}
else {
  Console.WriteLine("The string is not a palindrome.");
}
