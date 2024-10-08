using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSUBackendCase.Model
{
	public class Position
	{
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        //katedilen mesafenin mevcut pozisyona eklenmesi
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

		public override string ToString() => $"{X} {Y}";		
	}
}
