
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner {

    public class Event {

	private int number;
	private string name;
	private List<Argument> arguments = new List<Argument>();
	// private List<Request> requests = new List<Requestsa>();
	
	public Event(XmlNode node, int n) {
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    this.number = n;
	    foreach(XmlNode argNode in node.SelectNodes("arg")) {
		Argument a = new Argument(argNode);
		arguments.Add(a);
	    }
	}

	public override string ToString() {
			return string.Format("\n\t\t[DllImport(\"libwayland-server.so\")]" +
				"\n\t\tprivate static extern void wl_resource_post_event_{0}(IntPtr resource, Int32 number{1});" +
				"\n\t\tpublic void {3}({2}) {{" +
				"\n\t\t\twl_resource_post_event_{0}(this.resource, {4}{5});" +
					     "\n\t\t}}", this.name,
					     String.Join("", arguments.Select(a => a.ToCSharpTypeName())),
					     (String.Join("", arguments.Select(a => a.ToCSharpTypeName())) == "") ? "" : String.Join("", arguments.Select(a => a.ToCSharpTypeName())).Substring(2),
				Scanner.TitleCase(name), 
				this.number,
				String.Join("", arguments.Select(a => a.ToNameList())));

	}
	
    }
}
