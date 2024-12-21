using System.Runtime.CompilerServices;

namespace IntegrationDependencies
{
	public class Registration : ILogger
	{
		string? Filename { get; set; }
		public Registration(string file) => this.Filename = file;//имя файла
		public IDisposable? BeginScope<TState>(TState state) where TState : notnull
		{
			throw new NotImplementedException();
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			throw new NotImplementedException();
		}

		public async void Log(string message)
		{
			using (StreamWriter writer = new StreamWriter(this.Filename!, true)) { await writer.WriteLineAsync(message + " " + DateTime.Now); }
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
		{
			throw new NotImplementedException();
		}
	}
}