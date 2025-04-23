/*Benji Stansfield, 04-20-25, Lab 12 "Palindromic Primes"*/
Console.Clear();

int nthNumber = 0;

/*Main Screen*/
Console.WriteLine("This program will find palindromic primes- prime numbers that are the same forward as they are backward.\n");
do
{
    try
    {
        Console.Write("Please choose which palindromic prime you would like me to find: ");
        nthNumber = Convert.ToInt32(Console.ReadLine());
        if (nthNumber < 1) nthNumber = 0; //ensures the number is 1 or above
    }
    catch (FormatException)
    {
        Console.WriteLine("Please input a number"); //ensures the user types a number
    }
}
while (nthNumber < 1);

