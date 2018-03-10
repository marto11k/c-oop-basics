using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
	private string name;
	private List<Person> firstTeam;
	private List<Person> reserveTeam;

	public IReadOnlyCollection<Person> FirstTeam
	{
		get { return firstTeam; }
	}

	public IReadOnlyCollection<Person> ReserveTeam
	{
		get { return reserveTeam; }
	}

	public Team(string teamName)
	{
		this.firstTeam = new List<Person>();
		this.reserveTeam = new List<Person>();
		this.name = teamName;
	}

	public void AddPlayer(Person player)
	{
		if (player.Age < 40)
		{
			firstTeam.Add(player);
		}
		else
		{
			reserveTeam.Add(player);
		}
	}

}

