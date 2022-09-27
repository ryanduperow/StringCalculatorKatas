
namespace StringCalculatorKata092722;

public class StringCalculator
{
    public int Add(string numbers)
    {
        int result = 0;

        if (numbers != string.Empty)
        {
            string[] numbersArray = numbers.Split(",");

            foreach (var num in numbersArray)
            {
                result += int.Parse(num);
            }
        }

        return result;
    }
}
