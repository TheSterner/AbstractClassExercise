using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
	public class Employee : Person
	{
		public override void SayName()
		{
			foreach (string name in FirstName)
			{
				foreach (string lname in LastName)
				{
					Console.WriteLine("Name: " + name + " " + lname);

				}


			}
		}
	}
}
