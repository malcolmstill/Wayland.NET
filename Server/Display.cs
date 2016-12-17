
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Wayland.Server
{   
    public class Display
    {
		const string lib = "libwayland-server.so";
		IntPtr display;
		public static List<Client> clients = new List<Client>();
		public static List<Global> globals = new List<Global>();

		public override string ToString()
		{
			return string.Format("Wayland.Server.Display@0x{0:X16}", this.display.ToInt64());
		}
		
		[DllImport(lib)]
		private static extern IntPtr wl_display_create();
		public Display()
		{
			display = wl_display_create();
		}

		[DllImport(lib)]
		private static extern IntPtr wl_display_get_event_loop(IntPtr display);
		public EventLoop GetEventLoop()
		{
			return new EventLoop(wl_display_get_event_loop(this.display));
		}
		
		[DllImport(lib)]
		private static extern IntPtr wl_display_add_socket_auto(IntPtr display);
		public string AddSocketAuto()
		{
			return Marshal.PtrToStringAnsi(wl_display_add_socket_auto(this.display));
		}

		[DllImport(lib)]
		private static extern void wl_display_run(IntPtr display);
		public void Run()
		{
			wl_display_run(this.display);
		}

		[DllImport(lib)]
		private static extern void wl_display_terminate(IntPtr display);
		public void Terminate()
		{
			wl_display_terminate(this.display);
		}

		~Display() {
			this.Terminate();
		}
		
		[DllImport(lib)]
		private static extern void wl_display_flush_clients(IntPtr display);
		public void FlushClients()
		{
			wl_display_flush_clients(this.display);
		}


		[DllImport(lib)]
		private static extern UInt32 wl_display_get_serial(IntPtr display);
		public UInt32 GetSerial()
		{
			return wl_display_get_serial(this.display);
		}

		[DllImport(lib)]
		private static extern UInt32 wl_display_next_serial(IntPtr display);
		public UInt32 NextSerial()
		{
			return wl_display_next_serial(this.display);
		}

		[DllImport(lib)]
		private static extern Int32 wl_display_init_shm(IntPtr display);
		public Int32 InitSHM()
		{
			return wl_display_init_shm(this.display);
		}

		//public delegate void GlobalBindFunction(IntPtr client, IntPtr data, UInt32 version, UInt32 id);
		[DllImport(lib)]
		private static extern IntPtr wl_global_create(IntPtr display, IntPtr iface, int version, IntPtr data, Global.GlobalBindFunction bind);
		/*public void GlobalCreate(IntPtr iface, int version, IntPtr data, GlobalBindFunction bind)
		{
			wl_global_create(this.display, iface, version, data, bind);
		}*/

		public void GlobalCreate(Global global, int version)
		{
			//GlobalBindFunction bind = new GlobalBindFunction(global.Bind);
			wl_global_create(this.display, global.InterfacePointer, version, IntPtr.Zero, global.bind);
			globals.Add(global);
		}

		public static Client GetClient(IntPtr clientPointer)
		{
			//Console.WriteLine("Client pointer: {0}", clientPointer);
			foreach(Client client in clients)
			{
				if (client.clientPtr == clientPointer)
				{
					//Console.WriteLine("Returning {0}", client);
					return client;
				}
			}
			Client newClient = new Client(clientPointer);
			Console.WriteLine("{0} connected.", newClient);
			Display.clients.Add(newClient);
			return newClient;
		}

		public static void RemoveClient(IntPtr clientPointer)
		{
			Client client = clients.Find(c => c.clientPtr == clientPointer);
			if (client.clientPtr == clientPointer)
			{
				clients.Remove(client);
			}
		}

		public static void RemoveClient(Client client)
		{
			clients.Remove(client);
		}
    }
}
