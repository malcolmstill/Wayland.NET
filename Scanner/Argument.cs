
using System;
using System.Xml;
using System.Collections.Generic;

namespace Wayland.Scanner
{

	public enum Type
	{
		INT,
		UINT,
		FIXED,
		STRING,
		OBJECT,
		NEW_ID,
		ARRAY,
		FD
	}

	public class Argument
	{

		public string Name;
		private Type type;
		private bool nullable;

		public Argument (XmlNode node)
		{
			this.Name = this.ChangeKeywords(node.Attributes.GetNamedItem ("name").Value);
			this.type = this.StringToType (node.Attributes.GetNamedItem ("type").Value);
			this.nullable = (node.Attributes.GetNamedItem ("allow-null") != null) ? (node.Attributes.GetNamedItem ("allow-null").Value == "true") : false;
		}

		public string ChangeKeywords(string name) {
			string changed = "";
			if (name == "interface") {
				changed = "interfacePtr";
			} else {
				changed = name;
			}
			return changed;
		}

		public Type StringToType (string type)
		{
			switch (type) {
			case "int":
				return Type.INT;
			case "uint":
				return Type.UINT;
			case "fixed":
				return Type.FIXED;
			case "string":
				return Type.STRING;
			case "object":
				return Type.OBJECT;
			case "new_id":
				return Type.NEW_ID;
			case "array":
				return Type.ARRAY;
			case "fd":
				return Type.FD;
			default:
				return Type.INT;
			}
		}

		public string Signature ()
		{
			string prefix = this.nullable ? "?" : "";
			switch (this.type) {
			case Type.INT:
				return prefix + "i";
			case Type.UINT:
				return prefix + "u";
			case Type.FIXED:
				return prefix + "f";
			case Type.STRING:
				return prefix + "s";
			case Type.OBJECT:
				return prefix + "o";
			case Type.NEW_ID:
				return prefix + "n";
			case Type.ARRAY:
				return prefix + "a";
			case Type.FD:
				return prefix + "h";
			default:
				return "";
			}
		}

		public string ToCSharpTypeName ()
		{
			switch (this.type) {
			case Type.INT:
				return ", Int32 " + this.Name;
			case Type.UINT:
				return ", UInt32 " + this.Name;
			case Type.FIXED:
				return ", Int32 " + this.Name;
			case Type.STRING:
				return ", string " + this.Name;
			case Type.OBJECT:
				return ", IntPtr " + this.Name;
			case Type.NEW_ID:
				return ", IntPtr " + this.Name;
			case Type.ARRAY:
				return ", IntPtr " + this.Name;
			case Type.FD:
				return ", Int32 " + this.Name;
			default:
				return "";
			}
		}

		public string ToNameList ()
		{
			switch (this.type) {
			case Type.INT:
				return ", " + this.Name;
			case Type.UINT:
				return ", " + this.Name;
			case Type.FIXED:
				return ", " + this.Name;
			case Type.STRING:
				return ", " + this.Name;
			case Type.OBJECT:
				return ", " + this.Name;
			case Type.NEW_ID:
				return ", " + this.Name;
			case Type.ARRAY:
				return ", " + this.Name;
			case Type.FD:
				return ", " + this.Name;
			default:
				return "";
			}
		}
		
	}
}
