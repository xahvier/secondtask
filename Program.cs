using System;

public class NumberUtils
{
    public bool isOdd(int number)
    {
        
        if (number <= 0)
        {
            return false;
        }
        return number % 2 != 0;
    }
    public int sumOdd(int start, int end)
    {
        if (start <= 0 || end <= 0 || end < start)
        {
            return -1;
        }
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (isOdd(i))
            {
                sum += i;
            }
        }

        return sum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        NumberUtils utils = new NumberUtils();

        Console.WriteLine(utils.sumOdd(1, 100));   
        Console.WriteLine(utils.sumOdd(-1, 100));  
        Console.WriteLine(utils.sumOdd(100, 100));  
        Console.WriteLine(utils.sumOdd(13, 13));   
        Console.WriteLine(utils.sumOdd(100, -100)); 
        Console.WriteLine(utils.sumOdd(100, 1000)); 
    }
}

