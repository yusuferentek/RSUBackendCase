using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSUBackendCase.Model
{
	public enum DirectionEnum
	{
		N, E, S, W
	}

	public static class DirectionExtensions
	{
		public static DirectionEnum TurnLeft(this DirectionEnum direction)
		{
			return (DirectionEnum)(((int)direction + 3) % 4);
		}

		public static DirectionEnum TurnRight(this DirectionEnum direction)
		{
			return (DirectionEnum)(((int)direction + 1) % 4);
		}
	}
}
