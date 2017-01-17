using System;
using System.Runtime.InteropServices;
using Wayland.Server;

namespace XdgShellUnstableV6.Server.Protocol 
{
	public class XdgShellUnstableV6Interfaces
	{
		public static IntPtr XdgShellUnstableV6Types;
		public static Interface zxdgShellV6Interface = new Interface("zxdg_shell_v6", 1, 4, 1);
		public static Interface zxdgPositionerV6Interface = new Interface("zxdg_positioner_v6", 1, 7, 0);
		public static Interface zxdgSurfaceV6Interface = new Interface("zxdg_surface_v6", 1, 5, 1);
		public static Interface zxdgToplevelV6Interface = new Interface("zxdg_toplevel_v6", 1, 14, 2);
		public static Interface zxdgPopupV6Interface = new Interface("zxdg_popup_v6", 1, 2, 2);

		public static void Initialize()
		{
			Utils.Interfaces.Add("zxdg_shell_v6_interface", zxdgShellV6Interface.GetInterface());
			Utils.Interfaces.Add("zxdg_positioner_v6_interface", zxdgPositionerV6Interface.GetInterface());
			Utils.Interfaces.Add("zxdg_surface_v6_interface", zxdgSurfaceV6Interface.GetInterface());
			Utils.Interfaces.Add("zxdg_toplevel_v6_interface", zxdgToplevelV6Interface.GetInterface());
			Utils.Interfaces.Add("zxdg_popup_v6_interface", zxdgPopupV6Interface.GetInterface());
			XdgShellUnstableV6Types = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * 53);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, 0, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 1, Utils.Interfaces["zxdg_positioner_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 2, Utils.Interfaces["zxdg_surface_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 3, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 4, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 5, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 6, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 7, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 8, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 9, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 10, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 11, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 12, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 13, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 14, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 15, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 16, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 17, Utils.Interfaces["zxdg_toplevel_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 18, Utils.Interfaces["zxdg_popup_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 19, Utils.Interfaces["zxdg_surface_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 20, Utils.Interfaces["zxdg_positioner_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 21, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 22, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 23, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 24, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 25, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 26, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 27, Utils.Interfaces["zxdg_toplevel_v6_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 28, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 29, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 30, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 31, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 32, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 33, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 34, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 35, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 36, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 37, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 38, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 39, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 40, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 41, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 42, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 43, Utils.Interfaces["wl_output_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 44, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 45, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 46, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 47, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 48, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 49, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 50, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 51, IntPtr.Zero);
			Marshal.WriteIntPtr(XdgShellUnstableV6Types, Marshal.SizeOf(typeof(IntPtr)) * 52, IntPtr.Zero);
			zxdgShellV6Interface.SetRequests(
				new Message("destroy", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("create_positioner", "n", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 1), 
				new Message("get_xdg_surface", "no", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 2), 
				new Message("pong", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 4));
			zxdgShellV6Interface.SetEvents(
				new Message("ping", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 5));
			zxdgPositionerV6Interface.SetRequests(
				new Message("destroy", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_size", "ii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 6), 
				new Message("set_anchor_rect", "iiii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 8), 
				new Message("set_anchor", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 12), 
				new Message("set_gravity", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 13), 
				new Message("set_constraint_adjustment", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 14), 
				new Message("set_offset", "ii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 15));
			zxdgPositionerV6Interface.SetEvents();
			zxdgSurfaceV6Interface.SetRequests(
				new Message("destroy", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("get_toplevel", "n", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 17), 
				new Message("get_popup", "noo", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 18), 
				new Message("set_window_geometry", "iiii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 21), 
				new Message("ack_configure", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 25));
			zxdgSurfaceV6Interface.SetEvents(
				new Message("configure", "u", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 26));
			zxdgToplevelV6Interface.SetRequests(
				new Message("destroy", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_parent", "?o", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 27), 
				new Message("set_title", "s", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 28), 
				new Message("set_app_id", "s", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 29), 
				new Message("show_window_menu", "ouii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 30), 
				new Message("move", "ou", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 34), 
				new Message("resize", "ouu", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 36), 
				new Message("set_max_size", "ii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 39), 
				new Message("set_min_size", "ii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 41), 
				new Message("set_maximized", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("unset_maximized", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_fullscreen", "?o", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 43), 
				new Message("unset_fullscreen", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_minimized", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0));
			zxdgToplevelV6Interface.SetEvents(
				new Message("configure", "iia", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 44), 
				new Message("close", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0));
			zxdgPopupV6Interface.SetRequests(
				new Message("destroy", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("grab", "ou", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 47));
			zxdgPopupV6Interface.SetEvents(
				new Message("configure", "iiii", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 49), 
				new Message("popup_done", "", XdgShellUnstableV6Types + Marshal.SizeOf(typeof(IntPtr)) * 0));
			zxdgShellV6Interface.GetInterface();
			zxdgPositionerV6Interface.GetInterface();
			zxdgSurfaceV6Interface.GetInterface();
			zxdgToplevelV6Interface.GetInterface();
			zxdgPopupV6Interface.GetInterface();
		}
	}

	public class ZxdgShellV6Global : Global
	{
		public ZxdgShellV6Global()
		{
			 this.SetInterface("zxdg_shell_v6_interface");
		}
	}

	public class ZxdgShellV6 : Resource 
	{
		private ZxdgShellV6Implementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public ZxdgShellV6Implementation InitializeImplementation()
		{
			ZxdgShellV6Implementation impl = new ZxdgShellV6Implementation();
			impl.destroy = this.Destroy;
			impl.createPositioner = this.CreatePositioner;
			impl.getXdgSurface = this.GetXdgSurface;
			impl.pong = this.Pong;
			return impl;
		}

		public ZxdgShellV6(IntPtr clientPtr, Int32 version, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgShellV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public ZxdgShellV6(IntPtr clientPtr, Int32 version, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgShellV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public override string ToString() 
		{
			return "ZxdgShellV6@" + resource;
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ZxdgShellV6Implementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreatePositioner(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreatePositioner createPositioner;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetXdgSurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetXdgSurface getXdgSurface;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackPong(IntPtr client, IntPtr resource, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackPong pong;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgShellV6.Destroy@" + this);
		}

		public virtual void CreatePositioner(IntPtr client, IntPtr resource, UInt32 id)
		{
			Console.WriteLine("ZxdgShellV6.CreatePositioner@" + this);
		}

		public virtual void GetXdgSurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface)
		{
			Console.WriteLine("ZxdgShellV6.GetXdgSurface@" + this);
		}

		public virtual void Pong(IntPtr client, IntPtr resource, UInt32 serial)
		{
			Console.WriteLine("ZxdgShellV6.Pong@" + this);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_ping(IntPtr resource, Int32 number, UInt32 serial);
		public void SendPing(UInt32 serial) {
			//Console.WriteLine("ZxdgShellV6.SendPing@" + this);
			wl_resource_post_event_ping(this.resource, 0, serial);
		}
	}

	public class ZxdgPositionerV6Global : Global
	{
		public ZxdgPositionerV6Global()
		{
			 this.SetInterface("zxdg_positioner_v6_interface");
		}
	}

	public class ZxdgPositionerV6 : Resource 
	{
		private ZxdgPositionerV6Implementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public ZxdgPositionerV6Implementation InitializeImplementation()
		{
			ZxdgPositionerV6Implementation impl = new ZxdgPositionerV6Implementation();
			impl.destroy = this.Destroy;
			impl.setSize = this.SetSize;
			impl.setAnchorRect = this.SetAnchorRect;
			impl.setAnchor = this.SetAnchor;
			impl.setGravity = this.SetGravity;
			impl.setConstraintAdjustment = this.SetConstraintAdjustment;
			impl.setOffset = this.SetOffset;
			return impl;
		}

		public ZxdgPositionerV6(IntPtr clientPtr, Int32 version, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgPositionerV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public ZxdgPositionerV6(IntPtr clientPtr, Int32 version, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgPositionerV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public override string ToString() 
		{
			return "ZxdgPositionerV6@" + resource;
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ZxdgPositionerV6Implementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetSize(IntPtr client, IntPtr resource, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetSize setSize;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetAnchorRect(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetAnchorRect setAnchorRect;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetAnchor(IntPtr client, IntPtr resource, UInt32 anchor);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetAnchor setAnchor;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetGravity(IntPtr client, IntPtr resource, UInt32 gravity);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetGravity setGravity;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetConstraintAdjustment(IntPtr client, IntPtr resource, UInt32 constraint_adjustment);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetConstraintAdjustment setConstraintAdjustment;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetOffset(IntPtr client, IntPtr resource, Int32 x, Int32 y);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetOffset setOffset;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgPositionerV6.Destroy@" + this);
		}

		public virtual void SetSize(IntPtr client, IntPtr resource, Int32 width, Int32 height)
		{
			Console.WriteLine("ZxdgPositionerV6.SetSize@" + this);
		}

		public virtual void SetAnchorRect(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Console.WriteLine("ZxdgPositionerV6.SetAnchorRect@" + this);
		}

		public virtual void SetAnchor(IntPtr client, IntPtr resource, UInt32 anchor)
		{
			Console.WriteLine("ZxdgPositionerV6.SetAnchor@" + this);
		}

		public virtual void SetGravity(IntPtr client, IntPtr resource, UInt32 gravity)
		{
			Console.WriteLine("ZxdgPositionerV6.SetGravity@" + this);
		}

		public virtual void SetConstraintAdjustment(IntPtr client, IntPtr resource, UInt32 constraint_adjustment)
		{
			Console.WriteLine("ZxdgPositionerV6.SetConstraintAdjustment@" + this);
		}

		public virtual void SetOffset(IntPtr client, IntPtr resource, Int32 x, Int32 y)
		{
			Console.WriteLine("ZxdgPositionerV6.SetOffset@" + this);
		}

	}

	public class ZxdgSurfaceV6Global : Global
	{
		public ZxdgSurfaceV6Global()
		{
			 this.SetInterface("zxdg_surface_v6_interface");
		}
	}

	public class ZxdgSurfaceV6 : Resource 
	{
		private ZxdgSurfaceV6Implementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public ZxdgSurfaceV6Implementation InitializeImplementation()
		{
			ZxdgSurfaceV6Implementation impl = new ZxdgSurfaceV6Implementation();
			impl.destroy = this.Destroy;
			impl.getToplevel = this.GetToplevel;
			impl.getPopup = this.GetPopup;
			impl.setWindowGeometry = this.SetWindowGeometry;
			impl.ackConfigure = this.AckConfigure;
			return impl;
		}

		public ZxdgSurfaceV6(IntPtr clientPtr, Int32 version, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgSurfaceV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public ZxdgSurfaceV6(IntPtr clientPtr, Int32 version, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgSurfaceV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public override string ToString() 
		{
			return "ZxdgSurfaceV6@" + resource;
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ZxdgSurfaceV6Implementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetToplevel(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetToplevel getToplevel;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetPopup(IntPtr client, IntPtr resource, UInt32 id, IntPtr parent, IntPtr positioner);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetPopup getPopup;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetWindowGeometry(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetWindowGeometry setWindowGeometry;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackAckConfigure(IntPtr client, IntPtr resource, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackAckConfigure ackConfigure;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgSurfaceV6.Destroy@" + this);
		}

		public virtual void GetToplevel(IntPtr client, IntPtr resource, UInt32 id)
		{
			Console.WriteLine("ZxdgSurfaceV6.GetToplevel@" + this);
		}

		public virtual void GetPopup(IntPtr client, IntPtr resource, UInt32 id, IntPtr parent, IntPtr positioner)
		{
			Console.WriteLine("ZxdgSurfaceV6.GetPopup@" + this);
		}

		public virtual void SetWindowGeometry(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Console.WriteLine("ZxdgSurfaceV6.SetWindowGeometry@" + this);
		}

		public virtual void AckConfigure(IntPtr client, IntPtr resource, UInt32 serial)
		{
			Console.WriteLine("ZxdgSurfaceV6.AckConfigure@" + this);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_configure(IntPtr resource, Int32 number, UInt32 serial);
		public void SendConfigure(UInt32 serial) {
			//Console.WriteLine("ZxdgSurfaceV6.SendConfigure@" + this);
			wl_resource_post_event_configure(this.resource, 0, serial);
		}
	}

	public class ZxdgToplevelV6Global : Global
	{
		public ZxdgToplevelV6Global()
		{
			 this.SetInterface("zxdg_toplevel_v6_interface");
		}
	}

	public class ZxdgToplevelV6 : Resource 
	{
		private ZxdgToplevelV6Implementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public ZxdgToplevelV6Implementation InitializeImplementation()
		{
			ZxdgToplevelV6Implementation impl = new ZxdgToplevelV6Implementation();
			impl.destroy = this.Destroy;
			impl.setParent = this.SetParent;
			impl.setTitle = this.SetTitle;
			impl.setAppId = this.SetAppId;
			impl.showWindowMenu = this.ShowWindowMenu;
			impl.move = this.Move;
			impl.resize = this.Resize;
			impl.setMaxSize = this.SetMaxSize;
			impl.setMinSize = this.SetMinSize;
			impl.setMaximized = this.SetMaximized;
			impl.unsetMaximized = this.UnsetMaximized;
			impl.setFullscreen = this.SetFullscreen;
			impl.unsetFullscreen = this.UnsetFullscreen;
			impl.setMinimized = this.SetMinimized;
			return impl;
		}

		public ZxdgToplevelV6(IntPtr clientPtr, Int32 version, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgToplevelV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public ZxdgToplevelV6(IntPtr clientPtr, Int32 version, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgToplevelV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public override string ToString() 
		{
			return "ZxdgToplevelV6@" + resource;
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ZxdgToplevelV6Implementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetParent(IntPtr client, IntPtr resource, IntPtr parent);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetParent setParent;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetTitle(IntPtr client, IntPtr resource, string title);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetTitle setTitle;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetAppId(IntPtr client, IntPtr resource, string app_id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetAppId setAppId;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackShowWindowMenu(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, Int32 x, Int32 y);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackShowWindowMenu showWindowMenu;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackMove(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackMove move;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackResize(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, UInt32 edges);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackResize resize;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetMaxSize(IntPtr client, IntPtr resource, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetMaxSize setMaxSize;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetMinSize(IntPtr client, IntPtr resource, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetMinSize setMinSize;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetMaximized(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetMaximized setMaximized;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackUnsetMaximized(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackUnsetMaximized unsetMaximized;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetFullscreen(IntPtr client, IntPtr resource, IntPtr output);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetFullscreen setFullscreen;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackUnsetFullscreen(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackUnsetFullscreen unsetFullscreen;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetMinimized(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetMinimized setMinimized;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgToplevelV6.Destroy@" + this);
		}

		public virtual void SetParent(IntPtr client, IntPtr resource, IntPtr parent)
		{
			Console.WriteLine("ZxdgToplevelV6.SetParent@" + this);
		}

		public virtual void SetTitle(IntPtr client, IntPtr resource, string title)
		{
			Console.WriteLine("ZxdgToplevelV6.SetTitle@" + this);
		}

		public virtual void SetAppId(IntPtr client, IntPtr resource, string app_id)
		{
			Console.WriteLine("ZxdgToplevelV6.SetAppId@" + this);
		}

		public virtual void ShowWindowMenu(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, Int32 x, Int32 y)
		{
			Console.WriteLine("ZxdgToplevelV6.ShowWindowMenu@" + this);
		}

		public virtual void Move(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial)
		{
			Console.WriteLine("ZxdgToplevelV6.Move@" + this);
		}

		public virtual void Resize(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, UInt32 edges)
		{
			Console.WriteLine("ZxdgToplevelV6.Resize@" + this);
		}

		public virtual void SetMaxSize(IntPtr client, IntPtr resource, Int32 width, Int32 height)
		{
			Console.WriteLine("ZxdgToplevelV6.SetMaxSize@" + this);
		}

		public virtual void SetMinSize(IntPtr client, IntPtr resource, Int32 width, Int32 height)
		{
			Console.WriteLine("ZxdgToplevelV6.SetMinSize@" + this);
		}

		public virtual void SetMaximized(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgToplevelV6.SetMaximized@" + this);
		}

		public virtual void UnsetMaximized(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgToplevelV6.UnsetMaximized@" + this);
		}

		public virtual void SetFullscreen(IntPtr client, IntPtr resource, IntPtr output)
		{
			Console.WriteLine("ZxdgToplevelV6.SetFullscreen@" + this);
		}

		public virtual void UnsetFullscreen(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgToplevelV6.UnsetFullscreen@" + this);
		}

		public virtual void SetMinimized(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgToplevelV6.SetMinimized@" + this);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_configure(IntPtr resource, Int32 number, Int32 width, Int32 height, IntPtr states);
		public void SendConfigure(Int32 width, Int32 height, IntPtr states) {
			//Console.WriteLine("ZxdgToplevelV6.SendConfigure@" + this);
			wl_resource_post_event_configure(this.resource, 0, width, height, states);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_close(IntPtr resource, Int32 number);
		public void SendClose() {
			//Console.WriteLine("ZxdgToplevelV6.SendClose@" + this);
			wl_resource_post_event_close(this.resource, 1);
		}
	}

	public class ZxdgPopupV6Global : Global
	{
		public ZxdgPopupV6Global()
		{
			 this.SetInterface("zxdg_popup_v6_interface");
		}
	}

	public class ZxdgPopupV6 : Resource 
	{
		private ZxdgPopupV6Implementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public ZxdgPopupV6Implementation InitializeImplementation()
		{
			ZxdgPopupV6Implementation impl = new ZxdgPopupV6Implementation();
			impl.destroy = this.Destroy;
			impl.grab = this.Grab;
			return impl;
		}

		public ZxdgPopupV6(IntPtr clientPtr, Int32 version, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgPopupV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public ZxdgPopupV6(IntPtr clientPtr, Int32 version, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, XdgShellUnstableV6Interfaces.zxdgPopupV6Interface.ifaceNative, version, id);
			managedImplementation = this.InitializeImplementation();
			this.deleteFunction = new DeleteFunction(this.Delete);
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, this.deleteFunction);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public override string ToString() 
		{
			return "ZxdgPopupV6@" + resource;
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct ZxdgPopupV6Implementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGrab(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGrab grab;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			Console.WriteLine("ZxdgPopupV6.Destroy@" + this);
		}

		public virtual void Grab(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial)
		{
			Console.WriteLine("ZxdgPopupV6.Grab@" + this);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_configure(IntPtr resource, Int32 number, Int32 x, Int32 y, Int32 width, Int32 height);
		public void SendConfigure(Int32 x, Int32 y, Int32 width, Int32 height) {
			//Console.WriteLine("ZxdgPopupV6.SendConfigure@" + this);
			wl_resource_post_event_configure(this.resource, 0, x, y, width, height);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_popup_done(IntPtr resource, Int32 number);
		public void SendPopupDone() {
			//Console.WriteLine("ZxdgPopupV6.SendPopupDone@" + this);
			wl_resource_post_event_popup_done(this.resource, 1);
		}
	}
}
