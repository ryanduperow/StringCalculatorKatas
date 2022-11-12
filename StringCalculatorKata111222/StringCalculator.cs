

namespace StringCalculatorKata111222;

public static class StringCalculator
{
    private static string _input = string.Empty;

    public static int Add(string input)
    {
        _input = input;

        if(string.IsNullOrEmpty(_input))
            return 0;

        List<string> inputList = _input.Split(",")
                                       .ToList();

        List<int> numberList = inputList.Select(input => int.Parse(input))
                                        .ToList();

        return numberList.Sum();
    }
}
