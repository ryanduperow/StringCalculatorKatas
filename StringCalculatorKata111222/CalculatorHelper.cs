﻿
namespace StringCalculatorKata111222;

public static class CalculatorHelper
{
    private static List<string> _separatorsList = new List<string>() { ",", "\n" };

    public static List<string> FormatInput(string input)
    {
        if (input.Length > 1)
        {
            if (input.Substring(0, 2) == "//")
            {
                _separatorsList.Add(input[2].ToString());
                input = input.Substring(4);
            }
        }

        return input.Split(_separatorsList.ToArray(),
                            StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
    }

    public static List<int> CleanNumberList(List<string> inputList)
    {
        List<int> cleanedList = inputList.Select(input => int.Parse(input))
                        .ToList();

        List<int> negativesList = cleanedList.Where(num => num < 0)
                                             .ToList();

        if (negativesList.Count() > 0)
        {
            throw new ArgumentException(
                $"Negatives not allowed: {string.Join(" ", negativesList)}");
        }

        return cleanedList;
    }
}