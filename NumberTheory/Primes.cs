namespace NumberTheory;

public class NumberTheory
{
    public static bool IsPrime(int value)
    {
        if (value <= 1)
        {
            return false;
        }

        if (value == 2)
        {
            return true;

        }
        if (value % 2==0)
        {
            return false;

        }
        
        for (var i = 3; i < value; i+=2)
            if (value % i == 0)
                return false;
        return true;
    }
}