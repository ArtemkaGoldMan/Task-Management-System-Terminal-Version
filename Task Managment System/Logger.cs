using System;
namespace Task_Managment_System
{
	public sealed class Logger
	{
		private static Logger? _instance;
		private static readonly object _lock = new object();

		public Logger()
		{
		}

		public static Logger Instance
		{
			get
			{
				lock (_lock)
				{
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }

                    return _instance;
				}
			}
		}

		public void Log(string message)
		{
			Console.WriteLine($"[LOG]: {message}");
		}
	}
}

