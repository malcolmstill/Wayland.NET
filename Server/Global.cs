
using System;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Global
    {	
		public delegate void GlobalBindFunction(IntPtr client, IntPtr data, UInt32 version, UInt32 id);
		public IntPtr InterfacePointer { get; set; }
		public GlobalBindFunction bind;

		public Global()
		{
			bind = new GlobalBindFunction(this.Bind);
		}

		~Global()
		{
			Console.WriteLine("Global free");
		}

		public virtual void Bind(IntPtr client, IntPtr data, UInt32 version, UInt32 id)
		{
			Console.WriteLine("User should override Bind");
		}

		public void SetInterface(string name)
		{
			this.InterfacePointer = Utils.Interfaces[name];
		}

    }
}
