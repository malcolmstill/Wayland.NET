
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
		public DeleteFunction deleteFunction;

		public delegate void DeleteFunction(IntPtr resource); 

		public override string ToString()
		{
			return "Resource@" + resource;
		}

		
		~Resource()
		{
			if (implementation != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(this.implementation);
			}
			
			// We can't call wl_resource_destroy here because wl_client_destroy may
			// already have freed the resouce
			/*
			if (resource != IntPtr.Zero)
			{
				wl_resource_destroy(resource);
			}
			*/
		}
		

		const string lib = "libwayland-server.so";

		[DllImport(lib, EntryPoint="wl_resource_create")]
		public static extern IntPtr Create(IntPtr client, IntPtr _interface, Int32 version, UInt32 id);

		[DllImport(lib, EntryPoint="wl_resource_set_implementation")]
		public static extern void SetImplementation(IntPtr resource, IntPtr implementation, IntPtr data, DeleteFunction destroy); //DeleteFunction destroy);

		[DllImport(lib, EntryPoint="wl_resource_get_id")]
		private static extern UInt32 wl_resource_get_id(IntPtr resource);
		public UInt32 GetID()
		{
			return wl_resource_get_id(resource);
		}

		[DllImport(lib, EntryPoint="wl_resource_get_user_data")]
		public static extern IntPtr GetUserData(IntPtr resource);

		[DllImport(lib, EntryPoint="wl_resource_get_version")]
		public static extern Int32 GetVersion(IntPtr resource);
		public Int32 GetVersion()
		{
			return GetVersion(resource);
		}

		public virtual void Delete(IntPtr resource)
		{
			// Console.WriteLine("Delete function not overridden " + this);
		}

		[DllImport(lib, EntryPoint="wl_resource_destroy")]
		private static extern void wl_resource_destroy(IntPtr resource);
		public void Remove()
		{
			// Console.WriteLine("Calling Resource.Remove for " + this);
			if (client != null)
			{	
				client.RemoveResource(resource);
				wl_resource_destroy(resource);
			}
		}
    }
}
