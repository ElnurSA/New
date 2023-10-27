using System;
using PracticeAll.Helpers.Extensions;

namespace PracticeAll
{
	public class Person
	{
		public int Id { get; set; }
		public string Email { get; set; }

		public Person(string email)
		{
            Email = email;
			Console.WriteLine(Email.CheckEmail(@"\W"));
		}
	}
}

