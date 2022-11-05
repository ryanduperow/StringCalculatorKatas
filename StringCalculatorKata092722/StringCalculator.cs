
namespace StringCalculatorKata092722;

public class StringCalculator
{
    private string _input = string.Empty;
    private List<char> separatorsList = new List<char> { ',', '\n' };

    public int Add(string input)
    {
        _input = input;

        if (string.IsNullOrEmpty(_input))
            return 0;

        var inputList = FormatList();
        var numbers = inputList.Select(item => ConvertToNum(item)).ToList();

        return numbers.Sum() ;
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
                separatorsList.Add(_input[2]);
                _input = _input.Substring(4);
            }      
        }
       
        list = _input.Split(separatorsList.ToArray()).ToList();

        return list;
    }

    private bool HasCustomIndicator()
    {
        return _input.Substring(0, 2) == "//";
    }
}
