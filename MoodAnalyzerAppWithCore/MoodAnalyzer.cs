using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerApp
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.EMPTY_MESSAGE, "Message should not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NULL_MESSAGE, "Message should not be Null");
            }
        }
    }
}