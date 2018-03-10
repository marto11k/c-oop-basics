using System;


class Program
{
	static void Main(string[] args)
	{
		var n = int.Parse(Console.ReadLine());
		var players = new Team("nameless");
		for (int i = 0; i < n; i++)
		{
			var personArgs = Console.ReadLine().Split();
			Person person = new Person(personArgs[0], personArgs[1], int.Parse(personArgs[2]), decimal.Parse(personArgs[3]));
			players.AddPlayer(person);
		}
		Console.WriteLine($"First team has {players.FirstTeam.Count} players.");
		Console.WriteLine($"Reserve team has {players.ReserveTeam.Count} players.");
	}
}
