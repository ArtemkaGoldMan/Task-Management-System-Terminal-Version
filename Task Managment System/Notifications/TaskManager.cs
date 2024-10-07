using System;
using Task_Managment_System.Tasks;

namespace Task_Managment_System.Notifications
{
	public class TaskManager
	{
		private List<IObserver> _observers = new List<IObserver>();

		public void Subscribe(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Unsubscribe(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify(string message)
		{
			foreach(var observer in _observers)
			{
				observer.Update(message);
			}
		}

		public void CreateTask(Tasky task)
		{
			Logger.Instance.Log($"Task '{task.Title}' created.");
			Notify($"Task '{task.Title}' has been created");
		}
	}
}

