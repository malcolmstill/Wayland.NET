
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner {

    public class Interface {

	private string name;
	private string protocol;
	private List<Event> events = new List<Event>();
	private List<Request> requests = new List<Request>();
	
	public Interface(XmlNode node, string protocol) {
	    this.protocol = protocol;
	    this.name = node.Attributes.GetNamedItem("name").Value;
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

	public string ToInterfaceMember() {
	    return "\t\tpublic static IntPtr " + Scanner.ParameterCase(this.name) + "Interface { get; set; } = IntPtr.Zero;";
	}

	public string ToLoadSym() {
	    return "\t\t\t" + Scanner.ParameterCase(this.name) + "Interface =" + string.Format(" dlsym(lib, \"{0}\");", this.name + "_interface");
	}
	
	public override string ToString() {
	    return "\n\tpublic class " + Scanner.TitleCase(name) + " {" + 
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
		string.Format("\t\t\tthis.resource = Resource.Create(this.client, {0}, 1, id);\n\t\t\t", Scanner.TitleCase(this.protocol) + "Interfaces." + Scanner.ParameterCase(name) + "Interface") +
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
