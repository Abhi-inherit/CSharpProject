using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary1
{
    class Program
    {

        private static readonly string text = "Mary had a little lamp" + "little lamp, little lamp" + "Mary had a little lamp" + "whose flees were white as snow.";

        static void Main(string[] args)
        {
            IDictionary<string, int> wordOccurenceMap = GetWordOccuranceMap(text);
            PrintWordOccurenceCount(wordOccurenceMap);
        }

        private static IDictionary<string, int> GetWordOccuranceMap(string text)
        {
            string [] tokens = text.Split(' ','.',',','-','?','!');
            IDictionary<string,int> words = new SortedDictionary<String,int>();
            foreach(string word in tokens)
            {
                if(!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if(!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }

            return words;
        }

        private static void PrintWordOccurenceCount(IDictionary<string, int> wordOccurenceMap)
        {
            foreach (var wordEntry in wordOccurenceMap)
            {
                Console.WriteLine("Word '{0}'");
            }
        }
    }
}
