using RSUBackendCase.Commands;
using RSUBackendCase.Model;
using System.Windows.Input;

namespace RSUBackendCase.Services
{
	public class RoverController
	{
		private readonly Rover _rover;

		public RoverController(Rover rover)
		{
			_rover = rover;
		}


		public void ExecuteCommands(string commands)
		{
			foreach (var command in commands)
			{
				switch(command)
				{
					case 'L':
						new TurnLeftCommand(_rover).Execute();
						break;
					case 'R':
						new TurnRightCommand(_rover).Execute();
						break;
					case 'M':
						new MoveCommand(_rover).Execute();
						break;
					default:
						throw new ArgumentException($"Tanımlanamayan Komut: {command}");
				}
			}	
		}
		
		public string GetCurrentPosition()
			{
				return _rover.ToString();
			}
	}
}
