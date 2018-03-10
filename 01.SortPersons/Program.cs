using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		var n = int.Parse(Console.ReadLine());
		var people = new List<Person>();
		for (int i = 0; i < n; i++)
		{
			var personData = Console.ReadLine().Split();
			try
			{
				Person person = new Person(personData[0], personData[1], int.Parse(personData[2]), decimal.Parse(personData[3]));
				people.Add(person);
			}
			catch (ArgumentException ArgEx)
			{
				Console.WriteLine(ArgEx.Message);
			}

		}
		var bonus = decimal.Parse(Console.ReadLine());
		foreach (var person in people)
		{
			person.IncreaseSalary(bonus);
			Console.WriteLine(person.ToString());
		}
	}
}
