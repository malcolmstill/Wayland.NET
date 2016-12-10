
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner {

    public class Interface {

	public string name;
	private string protocol;
	private string version;
	private List<Event> events = new List<Event>();
	private List<Request> requests = new List<Request>();
	
	public Interface(XmlNode node, string protocol) {
	    this.protocol = protocol;
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    this.version = node.Attributes.GetNamedItem("version").Value;
	    foreach(XmlNode requestNode in node.SelectNodes("request")) {
		Request r = new Request(requestNode);
		requests.Add(r);
	    }
	    int eventNo = 0;
	    foreach(XmlNode eventNode in node.SelectNodes("event")) {
		Event e = new Event(eventNode, eventNo);
		events.Add(e);
		eventNo++;
	    }
	}

	/*
	  Functions for loading interface pointers from libwayland
	 */
	public string ToInterfaceMember() {
	    return "\t\tpublic static IntPtr " + Scanner.ParameterCase(this.name) + "Interface { get; set; } = IntPtr.Zero;";
	}

	public string ToLoadSym() {
	    return "\t\t\t" + Scanner.ParameterCase(this.name) + "Interface =" + string.Format(" dlsym(lib, \"{0}\");", this.name + "_interface");
	}
	/*
	  End functions for loading interface pointers from libwayland
	 */

	/*
	  Functions for generating interfaces pointers
	*/
	public string ToInitInterface()
	{
	    return "\t\tpublic static Interface " + Scanner.ParameterCase(this.name) + "Interface = new Interface(\"" + this.name + "\", " + version  +", " + requests.Count() + ", " + events.Count() + ");";
	}

	public string ToAddToDict()
	{
	    return "\t\t\tUtils.Interfaces.Add(\"" + this.name + "_interface\", " + Scanner.ParameterCase(this.name) + "Interface.GetInterface());";
	}

	public List<string> ToTypesInit()
	{
	    List<string> res = new List<string>();
	    foreach (Request r in requests)
	    {
		res.AddRange(r.ToTypesInit());
	    }
	    foreach (Event e in events)
	    {
		res.AddRange(e.ToTypesInit());
	    }
	    return res;
	}

	public string ToSetROE(string types)
	{
	    return "\t\t\t" + Scanner.ParameterCase(name) + "Interface.SetRequests(" + String.Join(", ", requests.Select(r => r.ToSetROE(types))) +  ");\n"
		+ "\t\t\t" + Scanner.ParameterCase(name) + "Interface.SetEvents(" + String.Join(", ", events.Select(r => r.ToSetROE(types))) +  ");";
	}
	/*
	  End functions for generating interface pointers
	 */
	
	public override string ToString() {
	    return "\n\tpublic class " + Scanner.TitleCase(name) + " \n\t{" + 
		"\n\t\tprivate IntPtr resource;\n" +
		"\t\tprivate IntPtr client;\n" +
		"\t\tprivate IntPtr implementation;\n" +
		"\n\t\tpublic " + Scanner.TitleCase(name) + "Implementation InitializeImplementation()"+
		"\n\t\t{" +
		"\n\t\t\t" + Scanner.TitleCase(name) + "Implementation impl = new " + Scanner.TitleCase(name) + "Implementation();\n" +
		String.Join("\n", requests.Select(i => i.ToInitializeImplementation())) +
		"\n\t\t\treturn impl;" +
		"\n\t\t}\n" +
		"\n\t\tpublic " + Scanner.TitleCase(name) +  "(IntPtr client, UInt32 id) {\n" +
		"\t\t\tthis.client = client;\n" +
		string.Format("\t\t\tthis.resource = Resource.Create(this.client, {0}, 1, id);\n\t\t\t", Scanner.TitleCase(this.protocol) + "Interfaces." + Scanner.ParameterCase(name) + "Interface.ifaceNative") +
		Scanner.TitleCase(name) + "Implementation managedImplementation = this.InitializeImplementation();" +
		"\n\t\t\tthis.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));" +	    "\n\t\t\tMarshal.StructureToPtr(managedImplementation, this.implementation, false);" +
	    "\n\t\t\tResource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);" +
	    "\n\t\t\tClient c = Display.GetClient(client);" +
	    "\n\t\t\tc.resources.Add(this);\n" + 
		"\t\t}\n" +
//		"\n" + String.Join("\n", requests.Select(i => i.ToDelegate())) +
		"\n\n\t\t[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]\n\t\tpublic struct " + Scanner.TitleCase(name) + "Implementation\n\t\t{\n" +
		String.Join("\n", requests.Select(i => i.ToStructMethod())) +
		"\n\t\t}\n\n" +
		String.Join("\n\n", requests.Select(i => i.ToDefaultMethod())) +
		"\n" + String.Join("\n", events.Select(i => i.ToString())) +
		"\n\t}";
	}
	
    }
}
