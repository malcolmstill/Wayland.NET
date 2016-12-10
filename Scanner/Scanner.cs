
using System;
using System.Xml;

namespace Wayland.Scanner {

    public class Scanner {

	public static string TitleCase(string name) {
	    string[] words = name.Split('_');
	    string result = "";
	    foreach (string word in words) {
		result = result + Char.ToUpper(word[0]) + word.Substring(1);
	    }
	    return result;
	}

	public static string ParameterCase(string name) {
	    string[] words = name.Split('_');
	    string result = "";
	    foreach (string word in words) {
		result = result + Char.ToUpper(word[0]) + word.Substring(1);
	    }
	    return Char.ToLower(result[0]) + result.Substring(1);
	}
	
	static void Main(string[] args) {
	    XmlDocument doc = new XmlDocument();
	    doc.Load(args[0]);

	    XmlNode node = doc.SelectSingleNode("protocol");
	    Protocol protocol = new Protocol(node);

	    Console.WriteLine(protocol);
	}
    }
}
