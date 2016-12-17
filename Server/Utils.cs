
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Utils
    {
		public static Dictionary<string, IntPtr> Interfaces = new Dictionary<string, IntPtr>();

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_release(IntPtr resource, Int32 number);
		public static void ReleaseBuffer(IntPtr buffer) {
			wl_resource_post_event_release(buffer, 0);
		}
    }
    
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public struct InterfaceStruct
    {
		public string name;
		public int version;
		public int methodCount;
		//[MarshalAs(UnmanagedType.LPArray)]
		//public MessageStruct[] methods;
		public IntPtr methods;
		public int eventCount;
		//[MarshalAs(UnmanagedType.LPArray)]
		//public MessageStruct[] events;
		public IntPtr events;
    }

    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public struct MessageStruct
    {
		public string name;
		public string signature;
		public IntPtr offset;
    }
    
    public class Interface
    {
		public InterfaceStruct iface = new InterfaceStruct();
		public IntPtr ifaceNative;
		public Message[] methods;
		public Message[] events;
	
		public Interface(string name, int version, int methodCount, int eventCount)
		{
		    iface.name = name;
		    iface.version = version;
	    	iface.methodCount = methodCount;
	    	iface.methods = Marshal.AllocHGlobal(methodCount * Marshal.SizeOf(typeof(MessageStruct)));
	    	iface.eventCount = eventCount;
	    	iface.events = Marshal.AllocHGlobal(eventCount * Marshal.SizeOf(typeof(MessageStruct)));

	    	ifaceNative = Marshal.AllocHGlobal(Marshal.SizeOf(iface));
	    	Marshal.StructureToPtr(iface, ifaceNative, false);
		}

		~Interface()
		{
			Console.WriteLine("Releasing interface");
			Marshal.FreeHGlobal(ifaceNative);
			Marshal.FreeHGlobal(iface.methods);
			Marshal.FreeHGlobal(iface.events);
		}
	
		public IntPtr GetInterface()
		{
			Marshal.StructureToPtr(iface, ifaceNative, false);
			return ifaceNative;
		}

		public void SetRequests(params Message[] requests)
		{
			this.methods = requests;
			int i = 0;
			foreach (Message request in requests)
			{
				request.MarshalStruct(iface.methods + i * Marshal.SizeOf(typeof(MessageStruct)));
				i++;
			}
		}

		public void SetEvents(params Message[] events)
		{
			this.events = events;
			int i = 0;
			foreach (Message ev in events)
			{
				ev.MarshalStruct(iface.events + i * Marshal.SizeOf(typeof(MessageStruct)));
				i++;
			}
		}
    }
    
    public class Message
    {
		private MessageStruct message = new MessageStruct();
		
		public Message(string name, string signature, IntPtr offset)
		{
			message.name = name;
			message.signature = signature;
			message.offset = offset;
		}

		~Message()
		{
			//Console.WriteLine("Releasing message.");
		}
		
		public void MarshalStruct(IntPtr location)
		{
			Marshal.StructureToPtr(this.message, location, false);
		}
    }

	// Could make this IDisposable?
	public class WlArray
	{
		public IntPtr array;

		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ArrayStruct
		{
			public UInt32 size;
			public UInt32 alloc;
			public IntPtr data;
		}

		[DllImport("libwayland-server.so")]
		private static extern void wl_array_init(IntPtr array);

		[DllImport("libwayland-server.so")]
		private static extern void wl_array_release(IntPtr array);

		[DllImport("libwayland-server.so")]
		private static extern IntPtr wl_array_add(IntPtr array, UInt32 size);

		public WlArray()
		{
			ArrayStruct astruct = new ArrayStruct();
			array = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ArrayStruct)));
			Marshal.StructureToPtr(astruct, array, false);
			wl_array_init(array);
		}

		~WlArray()
		{
			wl_array_release(array);
			Marshal.FreeHGlobal(array);
		}

		public IntPtr Add(UInt32 size)
		{
			return wl_array_add(array, size);
		}
	}
}
