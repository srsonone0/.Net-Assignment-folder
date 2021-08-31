using System;

namespace Else_if_Ladder
{ 

	public class Sample
	{

		public static void Main(String[] args)
    {
		

			int day = 2;

			// if else if else ladder

			if (day == 1)
			{
				Console.WriteLine("Mondyay");

			}
			else if (day == 2)
			{

				Console.WriteLine("Tuesday");

			}
			else if (day == 3)
			{

				Console.WriteLine("Wednesday");

			}
			else if (day == 5)
			{

				Console.WriteLine("Friday");

			}
			else
			{

				Console.WriteLine("Day not found!!!");
			}

			Console.WriteLine("End");

		}
	}
}
