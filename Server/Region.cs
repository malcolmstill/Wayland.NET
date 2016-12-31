
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
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			operation = op;
		}

		public int x { get; set; }
		public int y { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public Operation operation { get; set; }
		
		public bool ContainsPoint(int x, int y)
		{
			return (x >= this.x && x <= (this.x + this.width) && y >= this.y && y <= (this.y + this.height));
		}
    }
}
