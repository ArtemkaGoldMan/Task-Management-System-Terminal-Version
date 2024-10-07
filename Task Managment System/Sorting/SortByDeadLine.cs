using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Sorting
{
	public class SortByDeadLine : ISortStrategy
	{
		public void Sort(List<Tasky> tasks)
		{
			tasks.Sort((x, y) => x.DeadLine.CompareTo(y.DeadLine));
            Console.WriteLine("Tasks sorted by Deadline.");
        }
	}
}

