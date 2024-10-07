using System;
namespace Task_Managment_System.Notifications
{
	public class User : IObserver
	{
		public string? Name { get; set; }
		public User(string name) => Name = name;

		public void Update(string message)
		{
			Console.WriteLine($"Notification for {Name}: {message}");
		}
	}
}

