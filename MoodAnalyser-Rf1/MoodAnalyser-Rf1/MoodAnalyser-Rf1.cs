using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer_Rf1
{
    public class MoodAnalyse
    {
        private string message;

        
        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}