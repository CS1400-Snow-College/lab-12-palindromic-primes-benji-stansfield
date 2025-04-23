/*Benji Stansfield, 04-20-25, Lab 12 "Palindromic Primes"*/
using System.Diagnostics;

Console.Clear();

/*Tests*/
//IsPrime tests
Debug.Assert(IsPrime(25005) == false);
Debug.Assert(IsPrime(171713) == true);
Debug.Assert(IsPrime(1) == false);

//IsPalindromic tests
Debug.Assert(IsPalindromic(12321) == true);
Debug.Assert(IsPalindromic(231) == false);
Debug.Assert(IsPalindromic(8) == true);

//NthPalindromicPrime tests
Debug.Assert(GetNthPalindromicPrime(100) == 94049 == true);
Debug.Assert(GetNthPalindromicPrime(3) == 191 == false);
Debug.Assert(GetNthPalindromicPrime(3) == 5 == true);

int nthNumber = 0;

/*Main Screen*/
Console.WriteLine("This program will find palindromic primes- prime numbers that are the same forward as they are backward.\n");
do
{
    try
    {
        Console.Write("Please choose which palindromic prime you would like me to find: ");
        nthNumber = Convert.ToInt32(Console.ReadLine());
        if (nthNumber < 1) //ensures the number is 1 or above
        {
            nthNumber = 0;
            Console.WriteLine("Does not exist");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please input a number"); //ensures the user types a number
    }
}
while (nthNumber < 1);

long result = GetNthPalindromicPrime(nthNumber);
Console.Write($"The {nthNumber} palindromic prime is {result}.");

/*Check for prime numbers*/
static bool IsPrime(int candidate)
{
    if (candidate == 2 || candidate == 3)
        return true;
    if (candidate < 2 || candidate % 2 == 0)
        return false;
    for (int i = 3; i <= Math.Sqrt(candidate); i += 2) //skips even numbers (always divisible by 2)
    {
        if (candidate % i == 0)
            return false;
    }

    return true;
}

/*Check for palindromic numbers*/
static bool IsPalindromic(int candidate)
{
    string numString = Convert.ToString(candidate);
    char[] numbers = new char[numString.Length];
    for (int i = 0; i < numString.Length; i++) //copies the numbers into the array
    {
        numbers[i] = numString[i];
    }

    Array.Reverse(numbers);
    string reverseNumString = new string(numbers);

    if (reverseNumString != numString)
        return false; //returns false if the number is not the same forwards and backwards

    return true;
}

/*Find the palindromic prime*/
static long GetNthPalindromicPrime(int n)
{
    int count = 0;
    int number = 1;

    while (count < n)
    {
        number++;
        if (IsPrime(number) && IsPalindromic(number))
        {
            count++;
        }
    }

    return number;
}

/*The process is slow if the numbers are bigger (1000+) and I'm not sure how to optimize it, but it works*/

