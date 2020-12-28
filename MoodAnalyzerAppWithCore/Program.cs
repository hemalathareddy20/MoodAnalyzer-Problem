using System;

namespace MoodAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyzer Program");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            Console.WriteLine(moodAnalyzer.AnalyzeMood());
        }
    }
}
