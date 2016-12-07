
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    class SHMBuffer
    {
	const string lib = "libwayland-server.so";
	IntPtr buffer;

	public override string ToString() {
	    return "Wayland.Server.SHMBuffer@" + this.buffer;
	}

	[DllImport(lib)]
	private static extern IntPtr wl_shm_buffer_get(IntPtr resource);
	public SHMBuffer(IntPtr resource) {
	    this.buffer = wl_shm_buffer_get(resource);
	}
	
	[DllImport(lib)]
	private static extern void wl_shm_buffer_begin_access(IntPtr buffer);
	public void BeginAccess() {
	    wl_shm_buffer_begin_access(this.buffer);
	}
	
	[DllImport(lib)]
	private static extern void wl_shm_buffer_end_access(IntPtr buffer);
	public void EndAccess() {
	    wl_shm_buffer_end_access(this.buffer);
	}
	
	[DllImport(lib)]
	private static extern IntPtr wl_shm_buffer_get_data(IntPtr buffer);
	public IntPtr GetData() {
	    return wl_shm_buffer_get_data(this.buffer);
	}

	[DllImport(lib)]
	private static extern Int32 wl_shm_buffer_get_stride(IntPtr buffer);
	public Int32 GetStride() {
	    return wl_shm_buffer_get_stride(this.buffer);
	}

	[DllImport(lib)]
	private static extern UInt32 wl_shm_buffer_get_format(IntPtr buffer);
	public UInt32 GetFormat() {
	    return wl_shm_buffer_get_format(this.buffer);
	}

	[DllImport(lib)]
	private static extern Int32 wl_shm_buffer_get_width(IntPtr buffer);
	public Int32 GetWidth() {
	    return wl_shm_buffer_get_width(this.buffer);
	}

	[DllImport(lib)]
	private static extern Int32 wl_shm_buffer_get_height(IntPtr buffer);
	public Int32 GetHeight() {
	    return wl_shm_buffer_get_height(this.buffer);
	}	
    } 
}

