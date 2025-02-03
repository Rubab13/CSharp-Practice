// Print the First N Natural Numbers: Write a program that prints the first N natural numbers.

// Example Input:
// N = 5

// Example Output:
// 1 2 3 4 5

Console.Write("Enter a number: ");
string num = Console.ReadLine();
int number = int.Parse(num);

for (int i = 1; i <= number; i++) {
    Console.Write(i + " ");
}
