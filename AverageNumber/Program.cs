
/*Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30
Expected Output:
The average of 10, 15, 20 and 30 is: 18*/

Console.WriteLine("Enter your first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("Enter your second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int num2);
Console.WriteLine("Enter your third number:");
bool thirdSuccess = int.TryParse(Console.ReadLine(), out int num3);
Console.WriteLine("Enter your fourtht number:");
bool fourthSuccess = int.TryParse(Console.ReadLine(), out int num4);
int average = 0;
if (firstSuccess && secondSuccess && thirdSuccess && fourthSuccess)
{
    average = (num1 + num2 + num3 + num4) / 4;
}
else
{
    Console.WriteLine("invalid input!");
}

Console.WriteLine("the Average is: " + average);