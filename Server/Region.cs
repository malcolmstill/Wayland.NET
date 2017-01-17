
using System;
using System.Collections.Generic;

namespace Wayland.Server
{
	public class WlRect
	{
		public enum Operation
		{
			ADD,
	    	SUBTRACT
		};

		public WlRect(int x, int y, int width, int height, Operation op)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
			operation = op;
		}

		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public Operation operation { get; set; }
		
		public bool ContainsPoint(int x, int y)
		{
			return (x >= this.X && x <= (this.X + this.Width) && y >= this.Y && y <= (this.Y + this.Height));
		}
    }
}
