using System;
public class CoinFlip
{
    public const int head = 0;
    public const int tail = 0;
    static void CheckCoin()
    {
        Random random = new Random();
        int coin = random.Next(0, 2);
        if (coin == head)
        {
            Console.WriteLine("the flip coin is head");
        }
        else
        {
            Console.WriteLine("the flip coin is tail");
        }
    }
}

