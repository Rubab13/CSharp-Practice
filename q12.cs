// Write a program that takes an array of integers and finds the largest number in it.

int[] array = {1, 2, 3, 4, 5, 8};
int max = array[0]; // we'll suppose that the first digit is the largest digit

for (int i=0; i<array.Length; i++) {
  int element = array[i];
  if (element > max) {
    max = element;
  }
}

Console.WriteLine("The largest number is the given array is " + max + ".");