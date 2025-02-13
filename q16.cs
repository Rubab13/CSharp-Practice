// Write a C# Sharp program that calculates the average of the numbers in an array.

int[] array = {10, 10, 10, 10, 20};
int sum = 0;

for (int i=0; i<array.Length; i++) {
  sum = sum + array[i];
}
double result = (double)sum/array.Length;

Console.WriteLine("The average of the numbers of the given array is " + result + '.');