﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
	public class list
	{
		public void Run()
		{

			public void Run()

			{

				GetStudents();

				Console.ReadLine();

			}



			public void GetStudents()

			{



				List<Student> students = new List<Student>();

				string line;

				int numberOfGrades = 0;

				StreamReader file = new StreamReader(@"C:\Users\agatha\Source\Repos\students\StudentList.txt");

				while ((line = file.ReadLine()) != null)

				{

					string[] lines = line.Split(" ");

					numberOfGrades = lines.Length;

					string studentName = lines[0];

					Student newStudent = new Student(studentName, numberOfGrades);

					students.Add(newStudent);

				}

				foreach (Student newStudent in students)

				{

					if (newStudent.Grades >= 7)

						Console.WriteLine(newStudent.Name);

				}

			}

		}

	}
