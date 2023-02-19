using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer_UC2
{
    
    public class MoodAnalysisException : Exception
    {
        
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message
        }

        
        private readonly ExceptionType type;

        
        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}