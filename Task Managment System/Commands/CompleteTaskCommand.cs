using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Commands
{
	public class CompleteTaskCommand : ICommand
	{
		private Tasky _task;
		private bool _IsComplited;

		public CompleteTaskCommand(Tasky task)
		{
			_task = task;
		}

		public void Execute()
		{
			_IsComplited = true;
			Console.WriteLine($"Task '{_task.Title}' marked as completed.");
		}

		public void Undo()
		{
			_IsComplited = false;
			Console.WriteLine($"Undo: Task '{_task.Title}' is no longer completed.");
		}
	}
}

