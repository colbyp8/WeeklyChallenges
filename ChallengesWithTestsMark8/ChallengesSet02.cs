using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) { return 0; }
            else { return numbers.Count() == 0 ? 0 : numbers.Max() + numbers.Min(); }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length ;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            if (numbers == null) { return 0; }
            else
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0) { total += num; }
                }
                return total;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            return numbers.Sum() % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number / 2 : 0 ;

        }
    }
}
