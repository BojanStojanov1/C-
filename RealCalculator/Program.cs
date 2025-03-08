

/*Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the Operation: +
Expected Output:
The result is: 25*/


Console.WriteLine("Enter your first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("Enter your second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int num2);
Console.WriteLine("Enter your operator from +, -, *, /");
bool thirdSuccess = char.TryParse(Console.ReadLine(), out char operation);
int result = 0;
if (firstSuccess && secondSuccess && thirdSuccess)
{
    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        default:
            Console.WriteLine("You have entered an invalid operator.");
            break;
    }
}
else
{
    Console.WriteLine("invalid input");
}
Console.WriteLine("The result is: " + result);