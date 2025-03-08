
/*Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

Test Data:
Input the First Number: 5
Input the Second Number: 8
Expected Output:
After Swapping:
First Number: 8
Second Number: 5*/

Console.WriteLine("Enter your first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("Enter your second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int num2);
int test;

if (firstSuccess && secondSuccess)
{
    test = num1;
    num1 = num2;
    num2 = test; 
}
else
{
    Console.WriteLine("invalid input");
}
Console.WriteLine("the frist swaped number is: " + num1);
Console.WriteLine("the second swaped number is: " + num2);