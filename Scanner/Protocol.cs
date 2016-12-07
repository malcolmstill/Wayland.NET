
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace Wayland.Scanner {

    public class Protocol {

	private string name;
	private List<Interface> interfaces = new List<Interface>();
	
	public Protocol(XmlNode node) {
	    this.name = node.Attributes.GetNamedItem("name").Value;
	    foreach(XmlNode interfaceNode in node.SelectNodes("interface")) {
		Interface i = new Interface(interfaceNode);
		interfaces.Add(i);
	    }
	}

	public override string ToString() {
		return string.Format("using System;\nusing System.Runtime.InteropServices;\n\nnamespace {0} {{\n{1}\n}}", Scanner.TitleCase(name), String.Join("\n",interfaces.Select(i => i.ToString())));

	}
	
    }
}
