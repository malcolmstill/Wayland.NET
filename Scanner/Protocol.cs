
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
	
	public Protocol(XmlNode node)
	{
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    foreach(XmlNode interfaceNode in node.SelectNodes("interface"))
	    {
		Interface i = new Interface(interfaceNode, name);
		interfaces.Add(i);
	    }
	}

	private string MakeInitialize()
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

	public override string ToString()
	{
	    return string.Format("using System;\nusing System.Runtime.InteropServices;\nusing Wayland.Server;\n\nnamespace {0}.Server.Protocol \n{{\n{1}\n{2}\n}}", Scanner.TitleCase(name), this.MakeInitialize(), String.Join("\n",interfaces.Select(i => i.ToString())));
	}
	
    }
}
