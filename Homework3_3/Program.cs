/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Example:    3 -> 1, 8, 27. 
            5 -> 1, 8, 27, 64, 125
*/

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Enter a whole positive number ");  // we declare an integer variable 'number' and assigns it the value returned by calling the ReadInt
int x = 1;  // declaring a variable X

while (x <= number)   // FIRST method: using WHILE loop 
{
    int result = x * x * x;  // The loop is used to calculate and display the square of each number from 1 to the entered number.
    Console.Write($"{result} ");
    x++;
}
Console.WriteLine();

for (int i = 1; i <= number; i++)  // SECOND method: using FOR loop 
{
    int result = i * i * i;
    Console.Write($"{result} ");
}