using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            if (word == null) { return false; }
            if(ignoreCase == true)
            {
                List<string> wordsList = new List<string>();
                foreach(string x in words)
                {
                    if (x == null) { continue; }
                    wordsList.Add(x.ToLower());

                }
                word = word.ToLower();
                
                return wordsList.Contains(word);


            }
            else if (ignoreCase == false)
            {
                return words.Contains(word);
            }
            return true;
        }

        public bool IsPrimeNumber(int num)
        {
            List<int> prime = new List<int>();
            if(num <= 1)
            {
                return false;
            }
            for(int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    prime.Add(1);
                }
                else if (num % i != 0)
                {
                    prime.Add(0);
                }
            }
            if (prime.Contains(1))
            {
                return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            List<char> letters = new List<char>();
            foreach (char letter in str)
            {
                letters.Add(letter);
            }
            for(int i = letters.Count-1; i >= 0; i--)
            {
                int freq = str.Where(x => (x == letters[i])).Count();
                if(freq == 1)
                {
                    return str.LastIndexOf(letters[i]);
                }
                if (freq == str.Count())
                {
                    return -1;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j] && i != j)
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }

            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null|| n <= 0 || elements.Count == 0)
            {
                return Array.Empty<double>();
            }

            List<double> numbers = new List<double>();
            var num = n-1;
            while(num < elements.Count)
            {
                numbers.Add(elements[num]);
                num += n;
            }
            return numbers.ToArray();
        }
    }
}
