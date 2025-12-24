using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace QuickKartBL
{
    public class Validator
    {
        public static bool IsName(string value)
        {
            return !string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"^[A-Zz-z]+$");
        }
        public static bool IsEmailId(string value)
        {
            return !string.IsNullOrEmpty(value)&& Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public static bool HasLength(string value,int min ,int max)
        {
           return value != null && value.Length>=min && value.Length<=max;
        }
        public static bool HasCapitalLetter(string value)
        {
            return Regex.IsMatch(value, @"[A-Z]");
        }
        public static bool HasSmallLetter(string value)
        {
            return Regex.IsMatch(value, @"[a-z]");
        }
        public static bool HasDigit(string value)
        {
            return Regex.IsMatch(value, @"[0-9]");
        }
        public static bool HasSpecialCharacter(string value)
        {
            return Regex.IsMatch(value, @"[\W_]");
        }
        public static bool ValidateAge(DateTime dob ,int minAge)
        {
            int age = DateTime.Now.Year - dob.Year;
            return age >= minAge;
        }
    }
}
