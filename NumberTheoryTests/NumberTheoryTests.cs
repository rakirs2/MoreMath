using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberTheoryTests;

[TestClass]
public class NumberTheoryTests
{
    [TestMethod]
    public void IsPrimeTest()
    {
        //TODO No DoubleNesting
        Assert.IsTrue(NumberTheory.NumberTheory.IsPrime(2));
    }
}