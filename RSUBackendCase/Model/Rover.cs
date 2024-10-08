namespace RSUBackendCase.Model
{
	public class Rover
	{
		public Position Position { get; set; }
		public DirectionEnum Direction { get; set; }
		private readonly Grid _gird;

		public Rover(int x, int y, DirectionEnum direction, Grid grid)
		{
			Position = new Position(x, y);
			Direction = direction;
			_gird = grid;
		}

		public void TurnLeft()
		{
			Direction = Direction.TurnLeft();
		}

		public void TurnRight()
		{
			Direction = Direction.TurnRight();
		}

		public void Move()
		{
			switch (Direction)
			{
				case DirectionEnum.N:
					Position.Move(0, 1);
					break;
				case DirectionEnum.E:
					Position.Move(1, 0);
					break;
				case DirectionEnum.S:
					Position.Move(0, -1);
					break;
				case DirectionEnum.W:
					Position.Move(-1, 0);
					break;
			}
			Position = _gird.AreaControl(Position);
		}

		public override string ToString() => $"{Position} {Direction}";
	}
}
