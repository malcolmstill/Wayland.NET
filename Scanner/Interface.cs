
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner {

    public class Interface {

	private string name;
	private List<Event> events = new List<Event>();
	// private List<Request> requests = new List<Requestsa>();
	
	public Interface(XmlNode node) {
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    int eventNo = 0;
	    foreach(XmlNode eventNode in node.SelectNodes("event")) {
		Event e = new Event(eventNode, eventNo);
		events.Add(e);
		eventNo++;
	    }
	}

	public override string ToString() {
	    return string.Format("\n\tpublic class {0} {{" +
	    	"\n\t\tprivate IntPtr resource;" +
				"\n\t\tpublic {0}(IntPtr resource) {{" +
				"this.resource = resource;" +
				"}}" +
	    	"\n{1}" +
	    	"\n\t}}", Scanner.TitleCase(name), String.Join("\n",events.Select(i => i.ToString())));

	}
	
    }
}
