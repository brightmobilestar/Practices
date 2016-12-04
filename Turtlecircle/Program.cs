using System;
using Gtk;

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace turtletest
{
	class MainClass
	{
		public static AlexPloygon turtle;

		public static int numberCorner;
		public static int numberSkip;

		public static void Main(string[] args)
		{
			Console.WriteLine("Thanks for your practice! ");

			do
			{
				Console.WriteLine("Enter the number of task. there is 1, 2, 3.");
				if (!int.TryParse(Console.ReadLine(), out numberCorner))
				{
					Console.WriteLine("Must enter a number!");
				}
			} while (numberCorner == 0);

			if (numberCorner == 1)
			{
				task1();
			}
			else if (numberCorner == 2){
				task2(1);
			}
			else if (numberCorner == 3)
			{
				task2(2);
			}

		}

		private static void task1()
		{
			
			List<Person> people = new List<Person>();

			while (true)
			{
				Console.WriteLine("\nWhat is the name of the person you want to add?");
				string input = Console.ReadLine();
				if (input == "stop")
				{
					break;
				}

				int age;
				do
				{
					Console.WriteLine("Enter the age of the person.");
					if (!int.TryParse(Console.ReadLine(), out age))
					{
						Console.WriteLine("Must enter a number!");
					}
				} while (age == 0);

				Console.WriteLine("Enter a homestead for the person.");
				string homestead = Console.ReadLine();

				people.Add(new Person(input, age, homestead));

				bool? another = null;
				do
				{
					Console.WriteLine("Add another person? (y/n)");
					string next = Console.ReadLine();

					if (Regex.IsMatch(next, @"^[yYnN]$"))
					{
						another = (next == "Y" || next == "y");
					}
				} while (another == null);

				if (another == false)
				{
					break;
				}
			}

			foreach (Person p in people)
			{
				p.Introduce();
			}

			Console.ReadKey();
		}


		public static void task2(int skip)
		{
			Application.Init();

			do
			{
				Console.WriteLine("Enter the number of corners.");
				if (!int.TryParse(Console.ReadLine(), out numberCorner))
				{
					Console.WriteLine("Must enter a number!");
				}
			} while (numberCorner == 0);

			numberSkip = skip;

			turtle = new AlexPloygon();
			turtle.InitMitGroesse(400, 400);
			turtle.drawingArea.ExposeEvent += Draw;

			Application.Run();
		}

		public static void Draw(object o, Gtk.ExposeEventArgs a)
		{
			DrawStar(numberCorner, numberSkip, new Rectangle(0, 0, 400, 400));
		}
		//// <summary>
		///  Task2
		/// </summary>
		/// 
		// Generate the points for a star.

		private static void DrawStar( int num_points, int skip, Rectangle rect )
		{
			// Get the star's points.
			PointF[] star_points = 
				//new AlexCalPoints().MakeStarPoints(Math.PI / 2, num_points, skip, rect);

			AlexCalPoints.MakeStarPoints(-Math.PI / 2, num_points, skip, rect);

			turtle.DrawPolygon(star_points);
		}
	}
}
