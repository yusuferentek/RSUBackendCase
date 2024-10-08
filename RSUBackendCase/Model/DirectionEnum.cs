namespace RSUBackendCase.Model
{
	public enum DirectionEnum
	{
		N, E, S, W
	}

	public static class DirectionExtensions
	{
		// 4 adet enum olduğu için mod 4 düzeyinde iki yöne de 3(90 derece sola) veya 1(90 derece sağa) eklendi.
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
