
using System;
using System.Collections.Generic;

namespace Wayland.Server
{
    public class Client : IEquatable<Client>
    {
	public IntPtr clientPtr { get; set; }
	public List<object> resources = new List<object>();

	public Client(IntPtr clientPointer)
	{
	    this.clientPtr = clientPointer;
	}

	public override string ToString() {
	    return string.Format("Client@{0}", clientPtr);
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
