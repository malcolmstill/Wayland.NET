
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Display
    {
	const string lib = "libwayland-server.so";
	IntPtr display;

	public override string ToString() {
	    return string.Format("Wayland.Server.Display@0x{0:X8}", this.display.ToInt32());
	}
	
	[DllImport(lib)]
	private static extern IntPtr wl_display_create();
	public Display() {
	    display = wl_display_create();
	}

	[DllImport(lib)]
	private static extern IntPtr wl_display_get_event_loop(IntPtr display);
	public EventLoop GetEventLoop() {
	    return new EventLoop(wl_display_get_event_loop(this.display));
	}
	
	[DllImport(lib)]
	private static extern IntPtr wl_display_add_socket_auto(IntPtr display);
	public string AddSocketAuto() {
	    return Marshal.PtrToStringAnsi(wl_display_add_socket_auto(this.display));
	}

	[DllImport(lib)]
	private static extern void wl_display_run(IntPtr display);
	public void Run() {
	    wl_display_run(this.display);
	}

	[DllImport(lib)]
	private static extern void wl_display_terminate(IntPtr display);
	public void Terminate() {
	    wl_display_terminate(this.display);
	}

	[DllImport(lib)]
	private static extern void wl_display_flush_clients(IntPtr display);
	public void FlushClients() {
	    wl_display_flush_clients(this.display);
	}


	[DllImport(lib)]
	private static extern UInt32 wl_display_get_serial(IntPtr display);
	public UInt32 GetSerial() {
	    return wl_display_get_serial(this.display);
	}

	[DllImport(lib)]
	private static extern UInt32 wl_display_next_serial(IntPtr display);
	public UInt32 NextSerial() {
	    return wl_display_next_serial(this.display);
	}

	[DllImport(lib)]
	private static extern Int32 wl_display_init_shm(IntPtr display);
	public Int32 InitSHM() {
	    return wl_display_init_shm(this.display);
	}
	
	static void Main(string[] args)
	{
	    Console.WriteLine("WaylandServer test suite");
	    Console.WriteLine("------------------------");

	    // display.Run();
	}
    }
}
