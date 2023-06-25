/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Examples:   14212 -> нет
            23432 -> да
            12821 -> да
Palindrom is a number that remains the same when its digits are reversed (symetric, such 16461)
*/

Console.Write("Enter a five-digit number: ");
string input = Console.ReadLine();

if (input.Length != 5)
{
    Console.WriteLine("Invalid input. Please enter a five-digit number.");
    return;
}

bool isPalindrome = true;

for (int i = 0; i < 2; i++)
{
    if (input[i] != input[4 - i])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("The number is a palindrome.");
}
else
{
    Console.WriteLine("The number is not a palindrome.");
}
