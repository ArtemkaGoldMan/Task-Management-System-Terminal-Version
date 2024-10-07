using System;
namespace Task_Managment_System.Commands
{
	public class CommandManager
	{
		private Stack<ICommand> _commandHistory = new Stack<ICommand>();

		public void ExecuteCommand(ICommand command)
		{
			command.Execute();
			_commandHistory.Push(command);
		}

		public void Undo()
		{
			if(_commandHistory.Count > 0)
			{
				var command = _commandHistory.Pop();
				command.Undo();
			}
			else
			{
				Console.WriteLine("No commands to undo.");
			}
		}
	}
}

