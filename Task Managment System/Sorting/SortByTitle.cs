using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Sorting
{
	public class SortByTitle : ISortStrategy
	{
		public void Sort(List<Tasky> tasks)
		{
			tasks.Sort((x, y) => x.Title!.CompareTo(y.Title));
			Console.WriteLine("$Tasks sorted by Title.");
		}
	}
}

