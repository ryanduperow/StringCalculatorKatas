
namespace StringCalculatorKata092722;

public class StringCalculator
{
    public int Add(string numbers)
    {
        int result = 0;

        if (numbers != string.Empty)
        {
            result = Int32.Parse(numbers);
        }

        return result;
    }
}
