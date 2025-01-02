internal class Program
{
    private static void Main(string[] args)
    {
        // Using FormatDateTime.
        DateTime dt = new DateTime(2030, 4, 1);
        System.Console.WriteLine($"{FormatDateTime(dt)}");

        // Using FormatJoinStrings.
        string[] test_strs = new string[] {"Join", "these", "strings", "together"};
        System.Console.WriteLine($"{FormatJoinStrings(test_strs)}");
    }

    public static string FormatDateTime(DateTime the_date){
        System.Console.WriteLine(the_date);
        return $"{the_date.Year}--{the_date.Month}--{the_date.Day}";
    }

    public static string FormatJoinStrings(string[] str_array){
        string str = String.Join(".", str_array).ToUpper();

        return str;
    }
}