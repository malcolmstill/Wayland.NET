
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Resource
    {
		public IntPtr resource { get; set; } = IntPtr.Zero;
		//public IntPtr client { get; set; } = IntPtr.Zero;
		public Client client = null;
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
		private static extern UInt32 wl_resource_get_id(IntPtr resource);
		public UInt32 GetID()
		{
			return wl_resource_get_id(resource);
		}

		[DllImport(lib, EntryPoint="wl_resource_get_user_data")]
		public static extern IntPtr GetUserData(IntPtr resource);

		[DllImport(lib, EntryPoint="wl_resource_get_version")]
		public static extern UInt32 GetVersion(IntPtr resource);
		public UInt32 GetVersion()
		{
			return GetVersion(resource);
		}

		[DllImport(lib, EntryPoint="wl_resource_destroy")]
		private static extern void wl_resource_destroy(IntPtr resource);
		public void Remove()
		{
			//Client c = Display.GetClient(client);
			if (client != null)
			{
				client.RemoveResource(resource);	
				wl_resource_destroy(resource);
			}
		}
    }
}
