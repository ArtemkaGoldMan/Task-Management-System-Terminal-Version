using System;
namespace Task_Managment_System.Commands
{
	public interface ICommand
    {
		void Execute();
        void Undo();
    }
}

