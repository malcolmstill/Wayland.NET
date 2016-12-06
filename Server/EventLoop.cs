

using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    class EventLoop
    {
	const string lib = "libwayland-server.so";
	IntPtr eventLoop;

	public override string ToString() {
	    return "Wayland.Server.EventLoop@" + this.eventLoop;
	}
	
	public EventLoop(IntPtr eventLoop) {
	    this.eventLoop = eventLoop;
	}
	
	[DllImport(lib)]
	private static extern Int32 wl_event_loop_dispatch(IntPtr event_loop, Int32 timeout);
	public Int32 Dispatch(Int32 timeout) {
	    return wl_event_loop_dispatch(this.eventLoop, timeout);
	}

	[DllImport(lib)]
	private static extern IntPtr wl_event_loop_add_fd(IntPtr event_loop, Int32 fd, UInt32 mask, IntPtr func, IntPtr data);

    }
}

