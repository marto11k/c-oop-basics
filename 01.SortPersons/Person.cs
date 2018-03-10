using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
	const decimal MIN_SALARY = 460;
	const int MIN_LENGTH = 3;

	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		private set
		{
			if (value?.Length < MIN_LENGTH)
			{
				throw new ArgumentException($"First name cannot contain fewer than {MIN_LENGTH} symbols");
			}
			firstName = value;
		}
	}

	private string lastName;

	public string LastName
	{
		get { return lastName; }
		private set
		{
			if (value?.Length < MIN_LENGTH)
			{
				throw new ArgumentException($"Last name cannot contain fewer than {MIN_LENGTH} symbols");
			}
			lastName = value;
		}
	}

	private int age;

	public int Age
	{
		get { return age; }
		private set
		{
			if (value < 0)
			{
				throw new ArgumentException("Age cannot be zero or negative integer!");
			}
			age = value;
		}
	}

	private decimal salary;

	public decimal Salary
	{
		get { return salary; }
		private set
		{
			if (value < MIN_SALARY)
			{
				throw new ArgumentException($"Salary cannnot be less than {MIN_SALARY} leva!");
			}
			salary = value;
		}
	}


	public Person(string firstName, string lastName, int age, decimal salary)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Age = age;
		this.Salary = salary;
	}

	public void IncreaseSalary(decimal percentage)
	{
		if (this.age > 30)
		{
			salary += salary * percentage / 100;
		}
		else
		{
			salary += salary * percentage / 200;
		}

	}

	public override string ToString()
	{
		return $"{firstName} {lastName} receives {salary:f2} leva.";
	}
}

