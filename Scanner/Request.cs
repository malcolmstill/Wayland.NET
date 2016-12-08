
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner
{
    public class Request
    {
	// private int number;
	private string name;
	private List<Argument> arguments = new List<Argument>();
	// private List<Request> requests = new List<Requestsa>();
	
	public Request(XmlNode node)
	{
	    this.name = Scanner.TitleCase(node.Attributes.GetNamedItem("name").Value);
	    foreach(XmlNode argNode in node.SelectNodes("arg"))
	    {
		Argument a = new Argument(argNode);
		arguments.Add(a);
	    }
	}

	public string ToDelegate()
	{
	    return string.Format("\t\tpublic delegate void Callback{0}(IntPtr client, IntPtr resource{1});", this.name, String.Join("", arguments.Select(a => a.ToCSharpTypeName())));
	}

	public string ToStructMethod()
	{
	    return string.Format("\t\t\t[UnmanagedFunctionPointer(CallingConvention.Cdecl)]\n\t\t\tpublic delegate void Callback{0}(IntPtr client, IntPtr resource{1});", this.name, String.Join("", arguments.Select(a => a.ToCSharpTypeName()))) + string.Format("\n\t\t\t[MarshalAs(UnmanagedType.FunctionPtr)]\n\t\t\tpublic Callback{0} {1};", this.name, Char.ToLower(this.name[0]) + this.name.Substring(1)) + "\n";
	}

	public string ToInitializeImplementation()
	{
	    return "\t\t\timpl." + Char.ToLower(this.name[0]) + this.name.Substring(1) + " = this." + this.name + ";";
	}
	
	public string ToDefaultMethod()
	{
	    return string.Format("\t\tpublic void {0}(IntPtr client, IntPtr resource{1})\n\t\t{{\n\t\t\tConsole.WriteLine(\"{0}\");\n\t\t}}", this.name, String.Join("", arguments.Select(a => a.ToCSharpTypeName())));
	}
    }
}
