﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var IsLower = false;
            var IsUpper = false;
            var IsNumber = false;
             
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    IsLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    IsUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    IsNumber = true;
                }
            }

            if (IsLower == true && IsUpper == true && IsNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public char GetFirstLetterOfString(string val)
        {
             return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }

        public char FindMissingLetter(char[] array)
        {
            char[] letters = "abcdefghijklmnopqrxtuvwxyz".ToCharArray();

            if (char.IsUpper(array[0]))
            {
                letters = "abcdefghijklmnopqrxtuvwxyz".ToUpper().ToCharArray();
            }

            var place = 0;


            for (int j = 0; j < letters.Length; j++)
            {
                if (array[0] == letters[j])
                {
                    place = j;
                    break;
                }
            }

            char missing = ' ';

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != letters[place])
                {
                    missing = letters[place];
                    break;
                }
                place++;
            }

            return missing;
        }
    }
}
