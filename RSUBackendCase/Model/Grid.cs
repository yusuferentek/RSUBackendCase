namespace RSUBackendCase.Model
{
	public class Grid
	{
		public int MaxX { get; set; }
		public int MaxY { get; set; }

		public Grid(int maxX, int maxY)
		{
			MaxX = maxX;
			MaxY = maxY;
		}

		public Position AreaControl(Position position)
		{
			position.X = Math.Min(position.X, MaxX);
			position.Y = Math.Min(position.Y, MaxY);
			position.X = Math.Max(position.X, 0);
			position.Y = Math.Max(position.Y, 0);
			return position;
		}
	}
}
