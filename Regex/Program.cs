using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] test_strs = {
            "12/25/2030",
            "1/1/2020",
            "Juneuary 6",
            "07/28/1980",
            "3/15/99"
        };

        // Try out the code by using each of the test_strs, or enter your own:
        string test_str = test_strs[0];
        string learnerResult = ReverseDate(test_str);

        System.Console.WriteLine(learnerResult);
    }

    public static string ReverseDate(string date_str)
    {
        // Regular expression to match the date in mm/dd/yyyy or m/d/yy format.
        string pattern = @"^(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$";
        var match = Regex.Match(date_str, pattern);

        if (match.Success)
        {
            string year = match.Groups["year"].Value;
            string month = match.Groups["month"].Value;
            string day = match.Groups["day"].Value;

            // Return the reformatted date string.
            return $"{year}-{month}-{day}";
        }

        // Return an empty string for invalid input.
        return string.Empty;
    }
}