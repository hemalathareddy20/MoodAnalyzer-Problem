using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerApp
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionsType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_CLASS,NO_SUCH_METHOD,
        }
        public ExceptionsType type;
        public MoodAnalyzerCustomException(ExceptionsType Type,string message): base(message)
        {
            this.type = Type;
        }
    }
}
