using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwUifier
{
    internal class Uwuifier
    {
        public string Uwuify(string input)
        {
            List<string> outputs = QuickSplit(input);
            
            outputs = UwuifyLettersInStrList(outputs);
            outputs = AddRandomEmoticons(outputs);
            
            return ConnectStrList(outputs);
        }

        public string ConnectStrList(List<string> input)
        {
            string output = string.Empty;

            foreach(string str in input)
            {
                output += str + " ";
            }

            output = output.Trim();

            return output;
        }

        /// <summary>
        /// Quickly split text to use it with the uwuify methods
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> QuickSplit(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public List<string> AddRandomEmoticons(List<string> input)
        {
            Random random = new Random();

            string[] emoticons =
            {
                "OwO",
                "UwU",
                "QwQ",
                "^w^",
                ":3",
                "u3u",
                "(～￣▽￣)～",
                "ヾ(≧▽≦*)o",
                "(❁´◡`❁)"
            };

            List<string> output = input;

            output.Add(emoticons[random.Next(0, emoticons.Length)]);

            return output;
        }

        public List<string> UwuifyLettersInStrList(List<string> input)
        {
            List<string> output = new List<string>();

            foreach(string str in input)
            {
                output.Add(UwuifyLettersInStr(str));
            }

            return output;
        }

        public string UwuifyLettersInStr(string input)
        {
            return input.Replace('r', 'w').Replace('l', 'w').Replace('R', 'W').Replace('L', 'W');
        }
    }
}
