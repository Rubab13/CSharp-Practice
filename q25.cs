// Write a C# program to compute the sum of all the elements of an array of integers.

// Test Data:
// Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
// Sample Output
// Sum: 69

int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
int sum = 0;

for (int i=0; i<array.Length; i++) {
  sum = sum + array[i];
}

Console.WriteLine("The sum of the numbers in the given array is " + sum + ".");