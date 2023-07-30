namespace NumberTheory;

public class NumberTheory
{
    public static List<int> PrimesFrom(int? startingValue, int max)
    {
        var output = new List<int>();
        var start = Math.Max(startingValue ?? 2, 2);
        for (var i = 0; i < max; i++)
            if (IsPrime(i))
                output.Add(i);
        return output;
    }

    public static bool IsPrime(int value)
    {
        for (var i = 2; i < value; i++)
            if (value % i == 0)
                return false;
        return true;
    }
}