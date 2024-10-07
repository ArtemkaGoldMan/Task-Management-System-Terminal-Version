using System;
namespace Task_Managment_System.Tasks
{
	public abstract class Tasky
	{
		public string? Title { get; set; }
		public DateTime DeadLine { get; set; }

		public abstract void Display();
	}
}

