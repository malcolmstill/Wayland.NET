
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
    
    public class WlRegion
    {
	public IntPtr regionPtr { get; set; }
	public List<WlRect> rects = new List<WlRect>();
    }
}
