using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeMaxNumberOfBalloons
{
    public class Solution
    {
        /*
         https://leetcode.com/problems/maximum-number-of-balloons/
        */
        public int MaxNumberOfBalloons(string text)
        {
            if (String.IsNullOrEmpty(text))
                return 0;
            
            int numB = 0;
            int numA = 0;
            int numL = 0;
            int numN = 0;
            int numO = 0;

            foreach (char letter in text.ToCharArray())
            {

                switch (letter)
                {
                    case 'b':
                        numB++;
                        break;
                    case 'a':
                        numA++;
                        break;
                    case 'l':
                        numL++;
                        break;
                    case 'o':
                        numO++;
                        break;
                    case 'n':
                        numN++;
                        break;

                }
            }

            int lowestNum = LowestNumber(numB, numA,false);
            lowestNum = LowestNumber(lowestNum, numL,true);
            lowestNum = LowestNumber(lowestNum, numO, true);
            lowestNum = LowestNumber(lowestNum, numN, false);

            return lowestNum;

        }

        public int LowestNumber(int lowestNumber, int currentNum,bool doubleLetter)
        {
            if (doubleLetter)
            {
                if (lowestNumber * 2 > currentNum)
                    return currentNum / 2;

            }
            else
            {
                if (lowestNumber > currentNum)
                    return currentNum;
            }

            return lowestNumber;
        }



    }
}
