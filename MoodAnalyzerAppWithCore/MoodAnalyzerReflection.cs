using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerApp
{
    public class MoodAnalyzerReflection
    {
        public static object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }
        public static object CreateMooadAnalyzeUsingParameterizedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "Happy" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NO_SUCH_METHOD, "Constructor is Not Found");

                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NO_SUCH_CLASS, "Class Not Found");
            }

        }

    }

}
