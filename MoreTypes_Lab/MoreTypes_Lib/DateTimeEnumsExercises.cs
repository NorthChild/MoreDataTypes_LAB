using System;
using System.Linq;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {   
            // 4/4 DONE
            // DONE

        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {

            if (date.Year != birthDate.Year && date.Month < birthDate.Month)
            {
                var res = (date.Year - birthDate.Year) - 1;
                return res;
            }
            else if (date.Year < birthDate.Year || date.Month < birthDate.Month || date.Day < birthDate.Day)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }

            var result = date.Year - birthDate.Year;
            return result;
        }

            // DONE

        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return $"{date:yy/dd/MMM}";
        }
            
            // DONE

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            var month = date.Month;
            return $"{date:MMMM}";
        }

            // DONE

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {

            switch (suit) 
            {
                case Suit.CLUBS:
                    return "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.HEARTS:
                    return "You've broken my heart";
                    break;
                case Suit.DIAMONDS:
                    return "Diamonds are a girls best friend";
                    break;
                case Suit.SPADES:
                    return "Bucket and spade";
                    break;

            }
            return string.Empty;
        }
    }
}
