
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    class Display
    {
	const string lib = "libwayland-server.so";
	IntPtr display;

	public override string ToString() {
	    return "Wayland.Server.Display@" + this.display;
	}
	
	[DllImport(lib)]
	private static extern IntPtr wl_display_create();
	public Display() {
	    display = wl_display_create();
	}

	[DllImport(lib)]
	private static extern IntPtr wl_display_get_event_loop(IntPtr display);
	public IntPtr GetEventLoop() {
	    return wl_display_get_event_loop(this.display);
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

	[DllImport(lib, EntryPoint="wl_resouce_post_event", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ResourcePostEvent(IntPtr resource, UInt32 opcode, __arglist);

	[DllImport(lib, EntryPoint="wl_resource_create")]
	public static extern IntPtr ResourceCreate(IntPtr client, IntPtr _interface, Int32 version, UInt32 id);

	[DllImport(lib, EntryPoint="wl_resource_set_implementation")]
	public static extern void ResourceSetImplementation(IntPtr resource, IntPtr implementation, IntPtr data, IntPtr destroy);

	[DllImport(lib, EntryPoint="wl_resource_get_id")]
	public static extern UInt32 ResourceGetID(IntPtr resource);

	// Event loop

	[DllImport(lib, EntryPoint="wl_event_loop_dispatch")]
	public static extern Int32 EventLoopDispatch(IntPtr event_loop, Int32 timeout);

	[DllImport(lib, EntryPoint="wl_event_loop_add_fd")]
	public static extern IntPtr EventLoopAddFD(IntPtr event_loop, Int32 fd, UInt32 mask, IntPtr func, IntPtr data);
	

	
	static void Main(string[] args)
	{
	    Console.WriteLine("WaylandServer test suite");
	    Console.WriteLine("------------------------");
	    
	    Display display = new Display();
	    Console.WriteLine("Display: {0}", display);

	    Console.WriteLine("Socket: {0}", display.AddSocketAuto());

	    Console.WriteLine("Get serial: {0}", display.GetSerial());
	    Console.WriteLine("Next serial: {0}", display.NextSerial());
	    Console.WriteLine("Next serial: {0}", display.NextSerial());

	    display.InitSHM();
	    display.Run();
	}
    }
}
