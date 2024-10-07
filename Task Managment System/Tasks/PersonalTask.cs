using System;
namespace Task_Managment_System.Tasks
{
	public sealed class PersonalTask : Tasky
    {
        public override void Display()
        {
            Console.WriteLine($"[Personal Task] Title: {Title}, DeadLine: {DeadLine}");
        }
    }
}

