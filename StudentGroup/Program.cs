/*Make a new console application called StudentGroup
Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
Get a number from the console between 1 and 2 and print the students from that group in the console.
Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
Test Data:
Enter student group: (there are 1 and 2 )
1
Expected Output:
The Students in G1 are:
Zdravko
Petko
Stanko
Branko
Trajko*/

string[] studentsG6 = new string[] { "Bojan", "Viktor", "Sinisa", "Viktor", "Aleksandra" };
string[] studentsG1 = new string[] { "Kiril", "Stole", "Kole", "Vlatko", "Kristijan" };
Console.WriteLine("Enter a number from 1 and 2");
bool success = int.TryParse(Console.ReadLine(), out int number);
if(success)
{
    if (number == 1)
    {
        Console.WriteLine("The Students in G6 are:");
        foreach (string student in studentsG6)
        { 
            Console.WriteLine(student);
        }
    }
    else if (number==2)
    {
        Console.WriteLine("The Students in G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("Invalid Input!");
    }
}
else
{
    Console.WriteLine("Invalid Input!");
}