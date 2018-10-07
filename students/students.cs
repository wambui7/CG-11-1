using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace students
{
	public class students
	{
		public string Name { get; set; }

		public int Grades { get; set; }

		public students(int grades, string name)
		{
			Name = name;
			Grades = grades;
		}


	}
}
