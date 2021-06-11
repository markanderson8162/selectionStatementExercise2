using System;

namespace selectionStatementExercise2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your favorite subject?");
			Console.WriteLine("Select on of the following: Math, History, Science, Gym, or Language");
			var faveSubject = Console.ReadLine();

			
			switch (faveSubject)
			{
				case "Math":
					Console.WriteLine("I am a computer, so I'm basically 100% math.");
					break;

				case "History":
					Console.WriteLine("I haven't been around long but I know all about history.");
					break;

				case "Science":
					Console.WriteLine("I don't like science unless it's Computer Science.");
					break;

				case "Gym":
					Console.WriteLine("Where I'm from that's called \"Robotics\". ");
					break;

				case "Language":
					Console.WriteLine("I studied all the languages at the same time!");
					break;

				default:
					Console.WriteLine($"{faveSubject}? I don't know that one.");
					break;
			}
		}
	}
}
