using System;
using System.Text.RegularExpressions;
using Domain.Models;

namespace Service.Helpers
{
	public static class Extentions
	{
		public static bool CheckMailForAt(this string mail)
		{
			//bool isTrue;
			//if (mail.Contains("@"))
			//{
			//	isTrue = true;
			//}
			//else
			//{
			//	isTrue = false;
			//}
			//return isTrue;

			return Regex.IsMatch(mail, "@");
		}

	    public static bool CheckEmailforSpaces(this string mail)
		{
			return Regex.IsMatch(mail, @"\s");
		}

		public static string GetFullName(this Person name)
		{
			Person person = new()
            {
                id = 1,
                Name = "Elnur",
                Surname = "Safiyev"
            };
            return $"{person.Name} + {person.Surname}";
		}

		public static int Multiplier(this int[] ints)
		{
			int multiply = 1;
			foreach (int num in ints)
			{
				multiply *= num;
			}
			return multiply;
		}
	}
}

