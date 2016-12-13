
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Resource
    {
		public IntPtr resource { get; set; } = IntPtr.Zero;
		public IntPtr client { get; set; } = IntPtr.Zero;
		public IntPtr implementation { get; set; } = IntPtr.Zero;

		public override string ToString()
		{
			return "Resource@" + resource;
		}

		//const string lib = "/usr/local/lib/libwayland-server.so";
		const string lib = "libwayland-server.so";
		
		// [DllImport(lib, EntryPoint="wl_resouce_post_event", CallingConvention = CallingConvention.Cdecl)]
		// public static extern void PostEvent(IntPtr resource, UInt32 opcode, __arglist);

		[DllImport(lib, EntryPoint="wl_resource_create")]
		public static extern IntPtr Create(IntPtr client, IntPtr _interface, Int32 version, UInt32 id);

		[DllImport(lib, EntryPoint="wl_resource_set_implementation")]
		public static extern void SetImplementation(IntPtr resource, IntPtr implementation, IntPtr data, IntPtr destroy);

		[DllImport(lib, EntryPoint="wl_resource_get_id")]
		public static extern UInt32 GetID(IntPtr resource);

		[DllImport(lib, EntryPoint="wl_resource_get_user_data")]
		public static extern IntPtr GetUserData(IntPtr resource);

		[DllImport(lib, EntryPoint="wl_resource_destroy")]
		private static extern void Destroy(IntPtr resource);
		public void Destroy()
		{
			Client c = Display.GetClient(client);
			if (c != null)
			{
				c.RemoveResource(resource);	
				Destroy(resource);
			}
		}
    }
}
