namespace NumberTheory;

public class PrimeSieve
{
    private int _end = 3;

    private HashSet<int> _primes;

    private List<int> _primesList;

    public PrimeSieve()
    {
        _primes = new HashSet<int> { 2, 3 };
        _primesList = new List<int> { 2, 3 };
    }

    private void ExtendRange(int num)
    {
        while (_end < num)
        {
            _end += 2;
            if (CalculatePrime(_end))
            {
                _primesList.Add(_end);
                _primes.Add(_end);
            }
        }
    }

    public int MaxPrime()
    {
        return _primesList[^1];
    }

    private bool CalculatePrime(int num)
    {
        foreach (var prime in _primesList)
            if (_end % prime == 0)
                return false;

        return true;
    }

    public bool IsPrime(int num)
    {
        if (_end < num) ExtendRange(num);
        return _primes.Contains(num);
    }
}