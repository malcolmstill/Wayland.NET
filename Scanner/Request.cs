
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner
{
    public class Request
    {
	private string name;
	private List<Argument> arguments = new List<Argument>();
	
	public Request(XmlNode node)
	{
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    foreach(XmlNode argNode in node.SelectNodes("arg"))
	    {
		Argument a = new Argument(argNode);
		arguments.Add(a);
	    }
	}

	public List<string> ToTypesInit()
	{
	    List<string> res = new List<string>();
	    foreach(Argument a in arguments)
	    {
		res.Add(a.iface);
	    }
	    return res;
	}

	private string Signature()
	{
	    string signature = "";
	    foreach (Argument a in arguments)
	    {
		signature += a.Signature();
	    }
	    return signature;
	}
	
	public string ToSetROE(string types)
	{
	    string res =  "\n\t\t\t\tnew Message(\"" + this.name + "\", \"" + this.Signature() + "\", " + types + " + Marshal.SizeOf(typeof(IntPtr)) * " + (arguments.Count() == 0 ? 0 : Protocol.offset) + ")";
	    Protocol.offset += arguments.Count();
	    return res;
	}
	
	public string ToDelegate()
	{
	    return string.Format("\t\tpublic delegate void Callback{0}(IntPtr client, IntPtr resource{1});", Scanner.TitleCase(this.name), String.Join("", arguments.Select(a => a.ToCSharpTypeName())));
	}

	public string ToStructMethod()
	{
	    return string.Format("\t\t\t[UnmanagedFunctionPointer(CallingConvention.Cdecl)]\n\t\t\tpublic delegate void Callback{0}(IntPtr client, IntPtr resource{1});", Scanner.TitleCase(this.name), String.Join("", arguments.Select(a => a.ToCSharpTypeName()))) + string.Format("\n\t\t\t[MarshalAs(UnmanagedType.FunctionPtr)]\n\t\t\tpublic Callback{0} {1};", Scanner.TitleCase(this.name), Scanner.ParameterCase(this.name)) + "\n";
	}

	public string ToInitializeImplementation()
	{
	    return "\t\t\timpl." + Scanner.ParameterCase(this.name) + " = this." + Scanner.TitleCase(this.name) + ";";
	}
	
	public string ToDefaultMethod()
	{
	    return string.Format("\t\tpublic virtual void {0}(IntPtr client, IntPtr resource{1})\n\t\t{{\n\t\t\t//Console.WriteLine(\"{0}\");\n\t\t}}", Scanner.TitleCase(this.name), String.Join("", arguments.Select(a => a.ToCSharpTypeName())));
	}
    }
}
