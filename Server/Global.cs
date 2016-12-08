
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Global
    {
	public IntPtr InterfacePointer { get; set; }
	
	[DllImport("libdl.so")]
	static extern IntPtr dlopen(string filename, int flags);
	
	[DllImport("libdl.so")]
	protected static extern IntPtr dlsym(IntPtr handle, string symbol);

	public virtual void Bind(IntPtr client, IntPtr data, UInt32 version, UInt32 id)
	{
	    
	}

	public void SetInterface(string name)
	{
	    IntPtr Dll = dlopen("libwayland-server.so", 2);
	    this.InterfacePointer = dlsym(Dll, name);
	    Console.WriteLine("Global iface pointer: {0}", this.InterfacePointer);
	}

    }
}
