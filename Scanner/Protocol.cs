
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner
{
    public class Protocol
    {
	private string name;
	private List<Interface> interfaces = new List<Interface>();
	public static int offset = 1;
	
	public Protocol(XmlNode node)
	{
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    foreach(XmlNode interfaceNode in node.SelectNodes("interface"))
	    {
		Interface i = new Interface(interfaceNode, name);
		interfaces.Add(i);
	    }
	}

	private string MakeInitializeLoad()
	{
	    return string.Format("\tpublic class {0}Interfaces", Scanner.TitleCase(this.name)) +
		"\n\t{" +
		"\n\t\t[DllImport(\"libdl.so\")]" +
		"\n\t\tstatic extern IntPtr dlopen(string filename, int flags);" +
		"\n" +
		"\n\t\t[DllImport(\"libdl.so\")]" +
		"\n\t\tprotected static extern IntPtr dlsym(IntPtr handle, string symbol);\n\n" +
		String.Join("\n",interfaces.Select(i => i.ToInterfaceMember())) +
		"\n\n\t\tpublic static void Initialize()" +
		"\n\t\t{" +
		"\n\t\t\tIntPtr lib = dlopen(\"libwayland-server.so\", 2);\n" +
		String.Join("\n",interfaces.Select(i => i.ToLoadSym())) +
		"\n\t\t}" +
		"\n\t}";
	}

	private string MakeInitializeGen()
	{
	    List<string> types = new List<string>();
	    foreach (Interface i in interfaces)
	    {
		types.AddRange(i.ToTypesInit());
	    }
	    string marshalTypes = "";
	    int j = 1;
	    foreach (string type in types)
	    {
		marshalTypes += "\n\t\t\tMarshal.WriteIntPtr(" + Scanner.TitleCase(this.name) + "Types, Marshal.SizeOf(typeof(IntPtr)) * " + j + ", " + type + ");";
		j++;
	    }
	    
	    return string.Format("\tpublic class {0}Interfaces", Scanner.TitleCase(this.name)) +
		"\n\t{\n" +
		"\t\tpublic static IntPtr " + Scanner.TitleCase(this.name) + "Types;" +
		"\n" +String.Join("\n",interfaces.Select(i => i.ToInitInterface())) +
		"\n\n\t\tpublic static void Initialize()" +
		"\n\t\t{\n" +
		String.Join("\n",interfaces.Select(i => i.ToAddToDict())) +
		// "\n\t\t\tUtils.MakeTypes(IntPtr.Zero, " +
		"\n\t\t\t" + Scanner.TitleCase(this.name) + "Types = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * " + (types.Count()+1) + ");" +
		"\n\t\t\tMarshal.WriteIntPtr(" + Scanner.TitleCase(this.name) + "Types, 0, IntPtr.Zero);" + 
		//types.Aggregate((i, j) => i + ", " + j)
		marshalTypes + "\n" +
		String.Join("\n", interfaces.Select(i => i.ToSetROE(Scanner.TitleCase(this.name)+"Types"))) + "\n" + 
		"\t\t\t" + String.Join("\n\t\t\t", interfaces.Select(i => Scanner.ParameterCase(i.name) + "Interface.GetInterface();")) +
		"\n\t\t}" +
		"\n\t}";
	}
	
	public override string ToString()
	{
	    return string.Format("using System;\nusing System.Runtime.InteropServices;\nusing Wayland.Server;\n\nnamespace {0}.Server.Protocol \n{{\n{1}\n{2}\n}}", Scanner.TitleCase(name), this.MakeInitializeGen(), String.Join("\n",interfaces.Select(i => i.ToString())));
	}
	
    }
}
