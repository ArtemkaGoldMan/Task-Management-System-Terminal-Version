using System;
namespace Task_Managment_System.Tasks
{
	public sealed class WorkTask : Tasky
    {
        public override void Display()
        {
            Console.WriteLine($"[Work Task] Title: {Title}, DeadLine: {DeadLine}");
        }
    }
}

