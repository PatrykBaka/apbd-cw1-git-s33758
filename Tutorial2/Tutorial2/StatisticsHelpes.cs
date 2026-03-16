namespace Tutorial2;

public class StatisticsHelpes
{

    public static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }

}