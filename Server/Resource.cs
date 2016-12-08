

using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Resource
    {
	const string lib = "libwayland-server.so";
	
	// [DllImport(lib, EntryPoint="wl_resouce_post_event", CallingConvention = CallingConvention.Cdecl)]
	// public static extern void PostEvent(IntPtr resource, UInt32 opcode, __arglist);

	[DllImport(lib, EntryPoint="wl_resource_create")]
	public static extern IntPtr Create(IntPtr client, IntPtr _interface, Int32 version, UInt32 id);

	[DllImport(lib, EntryPoint="wl_resource_set_implementation")]
	public static extern void SetImplementation(IntPtr resource, IntPtr implementation, IntPtr data, IntPtr destroy);

	[DllImport(lib, EntryPoint="wl_resource_get_id")]
	public static extern UInt32 GetID(IntPtr resource);
    }
}
