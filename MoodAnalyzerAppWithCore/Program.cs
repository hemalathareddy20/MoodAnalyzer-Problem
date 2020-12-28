using System;

namespace MoodAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyzer Program");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            Console.WriteLine(moodAnalyzer.AnalyzeMood());
        }
    }
}
