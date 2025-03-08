
/*Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

Test Data:
Enter integer no.1:
4
Enter integer no.2:
3
Enter integer no.3:
7
Enter integer no.4:
3
Enter integer no.5:
2
Enter integer no.6:
8
Expected Output:
The result is: 14*/

int[] arrayOfInts = new int[6];
int sum = 0;

for (int i = 0; i < arrayOfInts.Length; i++)
{
    Console.WriteLine("Enter a number for " + i);
    bool success = int.TryParse(Console.ReadLine(), out int number);
    if (success)
    { 
        arrayOfInts[i] = number;
    }
    else
    {
        Console.WriteLine("wrong input!");
    }
}

foreach(int element in arrayOfInts)
{
    sum += element;
}
Console.WriteLine("The result is: " + sum);