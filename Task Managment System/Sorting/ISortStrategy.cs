using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Sorting
{
	public interface ISortStrategy
	{
		void Sort(List<Tasky> tasks);
	}
}

