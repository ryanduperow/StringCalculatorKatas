
namespace StringCalculatorKata092722;

public class StringCalculator
{
    private string _input = string.Empty;
    private List<string> separatorsList = new List<string> { ",", "\n", "//", "[", "]" };

    public int Add(string input)
    {
        _input = input;

        if (string.IsNullOrEmpty(_input))
            return 0;

        var inputList = FormatList();

        var numbers = CleanNumbers(inputList);

        return numbers.Sum() ;
    }

    private List<int> CleanNumbers(List<string> list)
    {
        var result = list.Select(item => ConvertToNum(item))
                         .Where(item => item < 1000)
                         .ToList();

        CheckForNegatives(result);

        return result;
    }

    private void CheckForNegatives(List<int> numberList)
    {
        List<int> negativeList = numberList.Where(num => num < 0).ToList();

        if (negativeList.Count > 0)
        {
            throw new ArgumentException(
                $"Negatives not allowed: {string.Join(" ", negativeList)}");
        }
    }

    private int ConvertToNum(string item)
    {
        return int.Parse(item);
    }

    private List<string> FormatList()
    {
        var list = new List<string>();

        if (_input.Length > 1)
        {
            if (HasCustomIndicator())
            {
                string customSection = _input.Split("\n").First();

                List<string> customSeparators = customSection.Split(
                    separatorsList.ToArray(), 
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                foreach (string separator in customSeparators)
                {
                    separatorsList.Add(separator);
                }

                _input = _input.Substring(
                    customSection.Length, 
                    _input.Length - customSection.Length);
            }      
        }
       
        list = _input.Split(
            separatorsList.ToArray(),
            StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        return list;
    }

    private bool HasCustomIndicator()
    {
        return _input.Substring(0, 2) == "//";
    }
}
