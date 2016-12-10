
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Wayland.Server
{
    public class Utils
    {
	public static Dictionary<string, IntPtr> Interfaces = new Dictionary<string, IntPtr>();

	/*
	public static IntPtr MakeTypes(params IntPtr[] types)
	{
	    int size = Marshal.SizeOf(typeof(IntPtr));
	    int i = 0;
	    IntPtr typesPtr = Marshal.AllocHGlobal(types.length * size);
	    foreach(IntPtr type in types)
	    {
		Marshal.WriteIntPtr(typesPtr, size * i, type);
		i++;
	    }
	    return typesPtr;
	}
	*/
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

    /*
    public class Utils
    {
	public static IntPtr MakeInterface(string name, int version, int methodCount, IntPtr methods, int eventCount, IntPtr events)
	{
	    InterfaceStruct iface = new IntefaceStruct();
	    iface.name = name;
	    iface.version = version;
	    iface.methodCount = methodCount;
	    iface.methods = methods;
	    iface.eventCount = eventCount;
	    iface.events = events;

	    IntPtr ifaceNative = Marshal.AllocHGlobal(Marshal.SizeOf(iface));
	    Marshal.StructureToPtr(iface, ifaceNative, false);
	    return ifaceNative;
	}
    }*/
    
    public class Interface
    {
	public InterfaceStruct iface = new InterfaceStruct();
	public IntPtr ifaceNative;
	
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
	    int i = 0;
	    foreach (Message request in requests)
	    {
		request.MarshalStruct(iface.methods + i * Marshal.SizeOf(typeof(MessageStruct)));
		i++;
	    }
	}

	public void SetEvents(params Message[] events)
	{
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
	    Console.WriteLine("Releasing message.");
	}
	
	public void MarshalStruct(IntPtr location)
	{
	    Marshal.StructureToPtr(this.message, location, false);
	}
    }
}
