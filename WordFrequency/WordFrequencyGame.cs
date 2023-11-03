using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 
namespace WordFrequency
{
    public class WordFrequencyGame
    {
        private const string Space = @"\s+";
 
        public string GetResult(string inputStr)
        {
            string[] words = Regex.Split(inputStr, Space);
            List<string> resultWordCounts = words.GroupBy(w => w)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key + " " + g.Count())
                .ToList();
 
            return string.Join("\n", resultWordCounts);
        }
    }
}
