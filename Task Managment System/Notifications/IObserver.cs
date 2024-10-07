using System;
namespace Task_Managment_System.Notifications
{
	public interface IObserver
	{
		void Update(string message);
	}
}

