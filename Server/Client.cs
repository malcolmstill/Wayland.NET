
using System;
using System.Collections.Generic;
using Wayland.Server.Protocol;

namespace Wayland.Server
{
    public class Client : IEquatable<Client>
    {
		public readonly IntPtr clientPtr;
		public List<Resource> resources = new List<Resource>();
		public List<WlRegion> regions = new List<WlRegion>();
		public WlKeyboard keyboard;
		public WlPointer pointer;

		public Client(IntPtr clientPointer)
		{
			this.clientPtr = clientPointer;
		}

		public void RemoveResource(IntPtr resource)
		{
			Resource r = FindResource(resource);
			if (r != null) 
			{
				resources.Remove(r);
			}
		}

		public Resource FindResource(IntPtr pointer)
		{
			return resources.Find(r => r.resource == pointer);
		}

		public override string ToString() {
			return string.Format("<Client@{0:X8}>", clientPtr.ToInt32());
		}

		public bool Equals(Client other)
		{
			return this.clientPtr == other.clientPtr;
		}
		
		public override bool Equals(Object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return this.clientPtr.GetHashCode();
		}

		public static bool operator ==(Client client1, Client client2)
		{
			if ( ((object)client1) == null || ((object)client2) == null )
			{
				return Object.Equals(client1, client2);
			}
			return client1.Equals(client2);
		}
			
		public static bool operator !=(Client client1, Client client2)
		{
			if (((object)client1) == null || ((object)client2) == null)
			return ! Object.Equals(client1, client2);
			
			return ! (client1.Equals(client2));
		}
    }
}
