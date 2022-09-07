using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var totalAdd = numbers.Where(x => x %2 == 0).Sum();
            var totalSubtract = numbers.Where(x => x %2 != 0).Sum();
            return totalAdd - totalSubtract;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            List<string> strings = new List<string>();
            strings.Add(str1);
            strings.Add(str2);
            strings.Add(str3);
            strings.Add(str4);
            return strings.Min(x => x.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> nums = new List<int>();
            nums.Add(number1);
            nums.Add(number2);
            nums.Add(number3);
            nums.Add(number4);
            return nums.Min(x => x);

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
                return false;
            else if (sideLength1 + sideLength2 > sideLength3 && sideLength1 < sideLength2 + sideLength3 && sideLength1 + sideLength3 > sideLength3)
                return true;
            else if (sideLength1 == sideLength2 && sideLength1 == sideLength3)
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            double numValue;
            bool isNumber = double.TryParse(input, out numValue);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var length = objs.Length;
            var nullElements = objs.Where(x => x == null).ToList().Count;
            if (nullElements == 0)
                return false;
            else 
                return length / nullElements < 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            double evensTotal = numbers.Where(x => x % 2 == 0).Sum();

            if (numbers.Where(x => x % 2 == 0).Count() == 0) 
                return 0;
            else if (numbers.Where(x => x % 2 == 0).Sum() == 0)
                return 0;
            else
                return evensTotal / numbers.Where(x => x % 2 == 0).Count();
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("number");
            else
            {
                var total = 1;
                for (int i = number; i > 1; i--)
                    total *= i;
                return total;
            }

        }
    }
}
