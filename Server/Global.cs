
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Global
    {
	public IntPtr InterfacePointer { get; set; }

	public virtual void Bind(IntPtr client, IntPtr data, UInt32 version, UInt32 id)
	{
	    
	}

	public void SetInterface(string name)
	{
	    this.InterfacePointer = Utils.Interfaces[name];
	}

    }
}
