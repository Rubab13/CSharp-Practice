// Write a program that takes an array of words and finds the length of the longest word in it.

string[] array = {"hello", "elephant", "ant", "I"};
string word = "";
int length = array[0].Length;

for (int i=0; i<array.Length; i++) {
  word = array[i];
  if (word.Length > length) {
    length = word.Length;
  }
}

Console.WriteLine("The length of the longest word in the given array is " + length + '.');