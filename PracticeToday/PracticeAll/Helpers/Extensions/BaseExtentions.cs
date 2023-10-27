using System;
using System.Text.RegularExpressions;

namespace PracticeAll.Helpers.Extensions
{
	public static class BaseExtentions
	{
		public static void ShowNum(this int num, int num2)
		{
			Console.WriteLine(num + num2);
		}
        public static int SumOfNums(this int num1, int num2)
        {
            return num1 + num2;
        }
		public static string ShowText(this string text, string str)
		{
			return text + str; 
		}

		public static bool CheckDigitForStr(this string str)
		{
			return Regex.IsMatch(str, @"\d");
        }

        public static bool CheckEmail(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

		public static int FindFactorial(this int num)
		{
			var factorial = 1;
			for (int i = 1; i <= num; i++)
			{
				factorial *= i;
			}
			return factorial;
		}
		public static bool CheckEmailAndPassword(this string str, string pattern)
		{
			return Regex.IsMatch(str, pattern);
		}

		public static double PowOfNum(this double num)
		{
			return Math.Pow(num, 2);
		}

		public static bool IsConvertStringToNumber(this string str)
		{
			return int.TryParse(str, out int result);
        }
    }
}

