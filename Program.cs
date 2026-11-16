using System.IO;



class Program
{
    static void Main()

    {
        string[] lines = new string[0];
        lines = File.ReadAllLines("marks.csv");
        int total = 0;
        int topmark = -1;
        string topstudent = "";


        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            int mark = int.Parse(fields[1]);

            if (mark > topmark)
            {
                topmark = mark;
                topstudent = fields[0];

            }
        }
        Console.WriteLine($"Average: {(double)total / lines.Length:F1}");
        Console.WriteLine($"Top: {topstudent} with {topmark}");

    }
}
