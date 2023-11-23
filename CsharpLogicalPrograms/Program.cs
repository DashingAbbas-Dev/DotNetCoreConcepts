using CsharpLogicalPrograms;

LogicalPrograms tryItOut = new LogicalPrograms();


// Console.Write("Enter a string: ");
//var input = Console.ReadLine();

#region  IsPrimeNumber
// bool IsPrimeNumber = tryItOut.IsPrimeNumber(input);
// Console.WriteLine("IsPrimeNumber string: " + IsPrimeNumber);
#endregion

#region factorial
// long factorial = tryItOut.Factorial(Convert.ToInt32(input));
// Console.WriteLine($"Factorial of {input} is: {factorial}");
#endregion

#region IsPalindrome
// bool IsPalindrome = tryItOut.IsPalindrome(input);
// Console.WriteLine("IsPalindrome string: " + IsPalindrome);
#endregion

#region Reversed String
//string reversedString = tryItOut.ReverseString(input);
// Console.WriteLine("Reversed string: " + reversedString);
#endregion

#region Number Pattern
//tryItOut.NumberPattern();
#endregion

#region Bubble sort
int[] array = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("Original array: ");
tryItOut.PrintArray(array);

tryItOut.BubbleSort(array);

Console.WriteLine("\nSorted array: ");
tryItOut.PrintArray(array);
#endregion