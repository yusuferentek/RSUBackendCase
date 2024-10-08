using RSUBackendCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSUBackendCase.Commands
{
	public class TurnRightCommand : ICommand
	{
		private readonly Rover _rover;

		public TurnRightCommand(Rover rover)
		{
			_rover = rover;
		}
		public void Execute()
		{
			_rover.TurnRight();
		}
	}
}
