internal class Program
{
    private static void Main(string[] args)
    {
        // Array of string representing dates.
        string[] date_str = {
            "July 4, 1776",
            "12/25/2025",
            "April 1",
            "Not a date",
            "Feb 14, 2036",
            "1/2020",
            "Sat, 18 Aug 2018", 
            "1/6/2025",
            "3/2/1992",
            "3/29/2021",
            "9/9/1993",
            "11/29/1965"
        };

        foreach (string date in date_str){
            System.Console.WriteLine(CalcHowManyDays(date));
        }
    }

    public static int CalcHowManyDays(string date_str){

        DateTime parsedDate;
        DateTime today = DateTime.Now;

        if (DateTime.TryParse(date_str, out parsedDate)){
            
            TimeSpan interval = today - parsedDate;
            return interval.Days;
        }
        else{
            return int.MaxValue;
        }
    }
}