using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false) ? true : false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }
            int sumOfOdds = 0;
            foreach(int num in numbers)
            {
                if (num % 2 != 0) { sumOfOdds += num; }
            }
            if (sumOfOdds % 2 != 0) { return true; }
            else { return false; }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string ans = "";
            foreach (char c in password)
            {
                if (char.IsUpper(c)) { ans += "1"; }
                if (char.IsLower(c)) { ans += "2"; }
                if (char.IsNumber(c)) { ans += "3"; }
            }
            if (ans.Contains("1") && ans.Contains("2") && ans.Contains("3")) { return true; }
            else { return false; }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] numsArray = Enumerable.Range(1, 100).ToArray();
            int[] odds = new int[50];
            int i = 0;
            foreach(int num in numsArray)
            {
                if (num % 2 != 0) { odds[i] = num; i++; }
            }
            return odds;   
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;
            foreach (string word in words)
            {
                words[i] = word.ToUpper();
                i++;
            }
            return words;
        }
    }
}
