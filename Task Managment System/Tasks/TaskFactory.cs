using System;
namespace Task_Managment_System.Tasks
{
	public abstract class TaskFactory
	{
		public abstract Tasky CreateTask(string title, DateTime deadline);
	}

	public class WorkTaskFactory : TaskFactory
	{
        public override Tasky CreateTask(string title, DateTime deadline)
        {
			return new WorkTask { Title = title, DeadLine = deadline }; 
        }
    }

    public class PersonalTaskFactory : TaskFactory
    {
        public override Tasky CreateTask(string title, DateTime deadline)
        {
            return new PersonalTask { Title = title, DeadLine = deadline };
        }
    }
}

