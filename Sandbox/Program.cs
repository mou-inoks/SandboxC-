


//CodeWar Multiples of 3 or 5 =====================================================

Console.WriteLine(SolutionComplicated(10));

static int Solution(int value)
{
    var finalNumber = 0;

    for (int i = 0; i < value; i++)
    {
        Console.WriteLine("current number : " + i);
        Console.WriteLine("final number : " + finalNumber);
        Console.WriteLine("_______________________________");
        if ((i % 3 == 0) || (i % 5 == 0))
            finalNumber = finalNumber + i;
    };


    return finalNumber;
}

static int SolutionComplicated(int value)
{
    return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
}

// ===============================================================================