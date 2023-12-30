// Declare an integer array with 5 elements
int[] numbers = new int[5];

// Initialize values for the array
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// Access and print the value of the array element
Console.WriteLine("The value of the element at index 2 is: " + numbers[2]); // Outputs: The value of the element at index 2 is: 30

// Use a loop to iterate through all elements of the array
Console.WriteLine("The elements of the array are:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
