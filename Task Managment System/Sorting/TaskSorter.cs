using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Sorting
{
	public class TaskSorter
	{
		private ISortStrategy? _sortStrategy;

		public void SetSortStrategy(ISortStrategy sortStrategy)
		{
			_sortStrategy = sortStrategy;
		}

		public void SortTasks(List<Tasky> tasks)
		{
			_sortStrategy.Sort(tasks);
		}
	}
}

