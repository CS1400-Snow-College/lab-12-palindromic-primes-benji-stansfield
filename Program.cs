/*Benji Stansfield, 04-20-25, Lab 12 "Palindromic Primes"*/
using System.Diagnostics;

Console.Clear();

/*Tests*/
//IsPrime tests
Debug.Assert(IsPrime(25005) == false);
Debug.Assert(IsPrime(171713) == true);
Debug.Assert(IsPrime(1) == false);

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

//long result = GetNthPalindromicPrime(nthNumber);
//Console.Write($"The {nthNumber} palindromic prime is {result}.");

/*Check for prime numbers*/
static bool IsPrime(int candidate)
{
    if (candidate == 2 || candidate == 3)
        return true;
    if (candidate < 2)
        return false;
    for (int i = 3; i <= Math.Sqrt(candidate); i += 2) //skips even numbers (always divisible by 2)
    {
        if (candidate % i == 0)
            return false;
    }

    return true;
}

/*static bool IsPalindromic(int candidate)
{

}

static long GetNthPalindromicPrime()*/

