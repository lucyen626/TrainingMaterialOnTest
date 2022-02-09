
namespace xUnitTestProject;

public class BuggyCalculator
{
    /// <summary>
    /// Add function
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Add(int a, int b) => a + b;

    /// <summary>
    /// Subtract function
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Subtract(int a, int b)
    {
        return b > a ? 0 : a - b;
    } 

    /// <summary>
    /// Multiply function
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Multiply(int a, int b) => a * b;

    /// <summary>
    /// Divide function
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Divide(int a, int b) => a / b;
}

