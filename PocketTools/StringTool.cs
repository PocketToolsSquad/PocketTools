using System;
using System.Linq;
using System.Text;

namespace PocketTools
{
    public static class StringTool
    {
        public static bool ContainsAny(this string value, params string[] compare)
        {
            foreach (string s in compare)
            {
                if (value.Contains(s))
                    return true;
            }
            return false;
        }

        public static bool In(this string s, params string[] values)
        {
            return values.Any(x => x.Equals(s));
        }

        public static bool IsEmpty(this string value)
        {
            // TODO: Probably include blank strings here
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool NotIn(this string s, params string[] values)
        {
            if (values.Contains(s))
                return false;
            else
                return true;
        }

        public static string ReplaceAll(this string s, string newValue, params string[] oldValues)
        {
            var newString = s;
            // TODO: replace with regex and/or more rework
            foreach (var oldValue in oldValues)
                newString = newString.Replace(oldValue, newValue);
            return newString;
        }

        public static string[] SplitAndTrim(this string value, params char[] separator)
        {
            return SplitAndTrim(value, separator, StringSplitOptions.None);
        }

        public static string[] SplitAndTrim(this string value, char[] separator, StringSplitOptions options)
        {
            return Array.ConvertAll(value.Split(separator, options), a => a.Trim());
        }

        public static bool StartsWithAny(this string value, params string[] compare)
        {
            foreach (string s in compare)
            {
                if (value.StartsWith(s))
                    return true;
            }
            return false;
        }

        public static bool StartsWithAny(this string value, StringComparison comparisonType, params string[] compare)
        {
            foreach (string s in compare)
            {
                if (value.StartsWith(s, comparisonType))
                    return true;
            }
            return false;
        }

        public static string ToCommaList(object[] objects)
        {
            if (objects == null || objects.Length == 0)
                return "";
            var sb = new StringBuilder();
            foreach (object o in objects)
            {
                sb.Append($"{o}, ");
            }
            sb.Length -= 2;
            return sb.ToString();
        }

        public static string TrimLower(this string s)
        {
            if (s == null)
                return null;
            else
                return s.ToLower().Replace(" ", "");
        }

        public static string TrimUpper(this string s)
        {
            if (s == null)
                return null;
            else
                return s.ToUpper().Replace(" ", "");
        }

        public static string Truncate(this string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && maxLength > 3 && value.Length > maxLength)
                return $"{value.Substring(0, maxLength - 3)}...";
            return value;
        }

    }
}
