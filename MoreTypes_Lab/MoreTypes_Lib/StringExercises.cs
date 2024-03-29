﻿using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class StringExercises
    {   
            // ALL DONE
            // DONE

        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string firstManip = input.Trim().ToUpper();

            for (int i = 0; i < num; i++) 
            {
                var x = i.ToString();
                firstManip += x;
            }
            
            
            return firstManip;
        }

            // DONE

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {

            return $"{number} {street}, {city} {postcode}.";

        }

            // DONE

        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            
            var result = (((double)score / (double)outOf) * 100);
            string res = $"You got {score} out of {outOf}: {Math.Round(result, 1)}%";
            return res;
        }

            // DONE

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {

            try
            {
                var res = Convert.ToDouble(numString);
                return res;
            }
            catch
            {
                return -999;
            }

        }

            // DONE

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {

            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            foreach (var element in input)
            {
                if (element == 'A')
                {
                    A += 1;
                }
                else if (element == 'B')
                {
                    B += 1;
                }
                else if (element == 'C')
                {
                    C += 1;
                }
                else if (element == 'D')
                {
                    D += 1;
                }
            }

            return $"A:{A} B:{B} C:{C} D:{D}";

        }
    }
}
