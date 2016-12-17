using System;
using System.Runtime.InteropServices;
using Wayland.Server;

namespace Wayland.Server.Protocol 
{
	public class WaylandInterfaces
	{
		public static IntPtr WaylandTypes;
		public static Interface wlDisplayInterface = new Interface("wl_display", 1, 2, 2);
		public static Interface wlRegistryInterface = new Interface("wl_registry", 1, 1, 2);
		public static Interface wlCallbackInterface = new Interface("wl_callback", 1, 0, 1);
		public static Interface wlCompositorInterface = new Interface("wl_compositor", 4, 2, 0);
		public static Interface wlShmPoolInterface = new Interface("wl_shm_pool", 1, 3, 0);
		public static Interface wlShmInterface = new Interface("wl_shm", 1, 1, 1);
		public static Interface wlBufferInterface = new Interface("wl_buffer", 1, 1, 1);
		public static Interface wlDataOfferInterface = new Interface("wl_data_offer", 3, 5, 3);
		public static Interface wlDataSourceInterface = new Interface("wl_data_source", 3, 3, 6);
		public static Interface wlDataDeviceInterface = new Interface("wl_data_device", 3, 3, 6);
		public static Interface wlDataDeviceManagerInterface = new Interface("wl_data_device_manager", 3, 2, 0);
		public static Interface wlShellInterface = new Interface("wl_shell", 1, 1, 0);
		public static Interface wlShellSurfaceInterface = new Interface("wl_shell_surface", 1, 10, 3);
		public static Interface wlSurfaceInterface = new Interface("wl_surface", 4, 10, 2);
		public static Interface wlSeatInterface = new Interface("wl_seat", 5, 4, 2);
		public static Interface wlPointerInterface = new Interface("wl_pointer", 5, 2, 9);
		public static Interface wlKeyboardInterface = new Interface("wl_keyboard", 5, 1, 6);
		public static Interface wlTouchInterface = new Interface("wl_touch", 5, 1, 5);
		public static Interface wlOutputInterface = new Interface("wl_output", 3, 1, 4);
		public static Interface wlRegionInterface = new Interface("wl_region", 1, 3, 0);
		public static Interface wlSubcompositorInterface = new Interface("wl_subcompositor", 1, 2, 0);
		public static Interface wlSubsurfaceInterface = new Interface("wl_subsurface", 1, 6, 0);

		public static void Initialize()
		{
			Utils.Interfaces.Add("wl_display_interface", wlDisplayInterface.GetInterface());
			Utils.Interfaces.Add("wl_registry_interface", wlRegistryInterface.GetInterface());
			Utils.Interfaces.Add("wl_callback_interface", wlCallbackInterface.GetInterface());
			Utils.Interfaces.Add("wl_compositor_interface", wlCompositorInterface.GetInterface());
			Utils.Interfaces.Add("wl_shm_pool_interface", wlShmPoolInterface.GetInterface());
			Utils.Interfaces.Add("wl_shm_interface", wlShmInterface.GetInterface());
			Utils.Interfaces.Add("wl_buffer_interface", wlBufferInterface.GetInterface());
			Utils.Interfaces.Add("wl_data_offer_interface", wlDataOfferInterface.GetInterface());
			Utils.Interfaces.Add("wl_data_source_interface", wlDataSourceInterface.GetInterface());
			Utils.Interfaces.Add("wl_data_device_interface", wlDataDeviceInterface.GetInterface());
			Utils.Interfaces.Add("wl_data_device_manager_interface", wlDataDeviceManagerInterface.GetInterface());
			Utils.Interfaces.Add("wl_shell_interface", wlShellInterface.GetInterface());
			Utils.Interfaces.Add("wl_shell_surface_interface", wlShellSurfaceInterface.GetInterface());
			Utils.Interfaces.Add("wl_surface_interface", wlSurfaceInterface.GetInterface());
			Utils.Interfaces.Add("wl_seat_interface", wlSeatInterface.GetInterface());
			Utils.Interfaces.Add("wl_pointer_interface", wlPointerInterface.GetInterface());
			Utils.Interfaces.Add("wl_keyboard_interface", wlKeyboardInterface.GetInterface());
			Utils.Interfaces.Add("wl_touch_interface", wlTouchInterface.GetInterface());
			Utils.Interfaces.Add("wl_output_interface", wlOutputInterface.GetInterface());
			Utils.Interfaces.Add("wl_region_interface", wlRegionInterface.GetInterface());
			Utils.Interfaces.Add("wl_subcompositor_interface", wlSubcompositorInterface.GetInterface());
			Utils.Interfaces.Add("wl_subsurface_interface", wlSubsurfaceInterface.GetInterface());
			WaylandTypes = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * 197);
			Marshal.WriteIntPtr(WaylandTypes, 0, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 1, Utils.Interfaces["wl_callback_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 2, Utils.Interfaces["wl_registry_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 3, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 4, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 5, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 6, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 7, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 8, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 9, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 10, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 11, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 12, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 13, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 14, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 15, Utils.Interfaces["wl_region_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 16, Utils.Interfaces["wl_buffer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 17, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 18, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 19, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 20, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 21, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 22, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 23, Utils.Interfaces["wl_shm_pool_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 24, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 25, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 26, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 27, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 28, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 29, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 30, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 31, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 32, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 33, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 34, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 35, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 36, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 37, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 38, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 39, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 40, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 41, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 42, Utils.Interfaces["wl_data_source_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 43, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 44, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 45, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 46, Utils.Interfaces["wl_data_source_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 47, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 48, Utils.Interfaces["wl_data_offer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 49, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 50, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 51, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 52, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 53, Utils.Interfaces["wl_data_offer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 54, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 55, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 56, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 57, Utils.Interfaces["wl_data_offer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 58, Utils.Interfaces["wl_data_source_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 59, Utils.Interfaces["wl_data_device_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 60, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 61, Utils.Interfaces["wl_shell_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 62, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 63, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 64, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 65, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 66, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 67, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 68, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 69, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 70, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 71, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 72, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 73, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 74, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 75, Utils.Interfaces["wl_output_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 76, Utils.Interfaces["wl_seat_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 77, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 78, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 79, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 80, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 81, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 82, Utils.Interfaces["wl_output_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 83, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 84, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 85, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 86, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 87, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 88, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 89, Utils.Interfaces["wl_buffer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 90, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 91, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 92, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 93, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 94, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 95, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 96, Utils.Interfaces["wl_callback_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 97, Utils.Interfaces["wl_region_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 98, Utils.Interfaces["wl_region_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 99, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 100, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 101, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 102, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 103, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 104, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 105, Utils.Interfaces["wl_output_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 106, Utils.Interfaces["wl_output_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 107, Utils.Interfaces["wl_pointer_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 108, Utils.Interfaces["wl_keyboard_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 109, Utils.Interfaces["wl_touch_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 110, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 111, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 112, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 113, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 114, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 115, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 116, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 117, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 118, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 119, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 120, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 121, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 122, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 123, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 124, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 125, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 126, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 127, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 128, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 129, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 130, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 131, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 132, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 133, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 134, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 135, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 136, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 137, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 138, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 139, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 140, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 141, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 142, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 143, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 144, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 145, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 146, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 147, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 148, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 149, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 150, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 151, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 152, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 153, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 154, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 155, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 156, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 157, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 158, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 159, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 160, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 161, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 162, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 163, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 164, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 165, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 166, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 167, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 168, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 169, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 170, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 171, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 172, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 173, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 174, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 175, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 176, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 177, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 178, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 179, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 180, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 181, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 182, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 183, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 184, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 185, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 186, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 187, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 188, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 189, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 190, Utils.Interfaces["wl_subsurface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 191, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 192, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 193, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 194, IntPtr.Zero);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 195, Utils.Interfaces["wl_surface_interface"]);
			Marshal.WriteIntPtr(WaylandTypes, Marshal.SizeOf(typeof(IntPtr)) * 196, Utils.Interfaces["wl_surface_interface"]);
			wlDisplayInterface.SetRequests(
				new Message("sync", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 1), 
				new Message("get_registry", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 2));
			wlDisplayInterface.SetEvents(
				new Message("error", "ous", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 3), 
				new Message("delete_id", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 6));
			wlRegistryInterface.SetRequests(
				new Message("bind", "un", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 7));
			wlRegistryInterface.SetEvents(
				new Message("global", "usu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 9), 
				new Message("global_remove", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 12));
			wlCallbackInterface.SetRequests();
			wlCallbackInterface.SetEvents(
				new Message("done", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 13));
			wlCompositorInterface.SetRequests(
				new Message("create_surface", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 14), 
				new Message("create_region", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 15));
			wlCompositorInterface.SetEvents();
			wlShmPoolInterface.SetRequests(
				new Message("create_buffer", "niiiiu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 16), 
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("resize", "i", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 22));
			wlShmPoolInterface.SetEvents();
			wlShmInterface.SetRequests(
				new Message("create_pool", "nhi", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 23));
			wlShmInterface.SetEvents(
				new Message("format", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 26));
			wlBufferInterface.SetRequests(
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlBufferInterface.SetEvents(
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlDataOfferInterface.SetRequests(
				new Message("accept", "u?s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 27), 
				new Message("receive", "sh", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 29), 
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("finish", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_actions", "uu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 31));
			wlDataOfferInterface.SetEvents(
				new Message("offer", "s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 33), 
				new Message("source_actions", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 34), 
				new Message("action", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 35));
			wlDataSourceInterface.SetRequests(
				new Message("offer", "s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 36), 
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_actions", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 37));
			wlDataSourceInterface.SetEvents(
				new Message("target", "?s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 38), 
				new Message("send", "sh", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 39), 
				new Message("cancelled", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("dnd_drop_performed", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("dnd_finished", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("action", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 41));
			wlDataDeviceInterface.SetRequests(
				new Message("start_drag", "?oo?ou", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 42), 
				new Message("set_selection", "?ou", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 46), 
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlDataDeviceInterface.SetEvents(
				new Message("data_offer", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 48), 
				new Message("enter", "uoff?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 49), 
				new Message("leave", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("motion", "uff", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 54), 
				new Message("drop", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("selection", "?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 57));
			wlDataDeviceManagerInterface.SetRequests(
				new Message("create_data_source", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 58), 
				new Message("get_data_device", "no", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 59));
			wlDataDeviceManagerInterface.SetEvents();
			wlShellInterface.SetRequests(
				new Message("get_shell_surface", "no", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 61));
			wlShellInterface.SetEvents();
			wlShellSurfaceInterface.SetRequests(
				new Message("pong", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 63), 
				new Message("move", "ou", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 64), 
				new Message("resize", "ouu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 66), 
				new Message("set_toplevel", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_transient", "oiiu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 69), 
				new Message("set_fullscreen", "uu?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 73), 
				new Message("set_popup", "ouoiiu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 76), 
				new Message("set_maximized", "?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 82), 
				new Message("set_title", "s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 83), 
				new Message("set_class", "s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 84));
			wlShellSurfaceInterface.SetEvents(
				new Message("ping", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 85), 
				new Message("configure", "uii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 86), 
				new Message("popup_done", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlSurfaceInterface.SetRequests(
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("attach", "?oii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 89), 
				new Message("damage", "iiii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 92), 
				new Message("frame", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 96), 
				new Message("set_opaque_region", "?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 97), 
				new Message("set_input_region", "?o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 98), 
				new Message("commit", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_buffer_transform", "i", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 99), 
				new Message("set_buffer_scale", "i", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 100), 
				new Message("damage_buffer", "iiii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 101));
			wlSurfaceInterface.SetEvents(
				new Message("enter", "o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 105), 
				new Message("leave", "o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 106));
			wlSeatInterface.SetRequests(
				new Message("get_pointer", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 107), 
				new Message("get_keyboard", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 108), 
				new Message("get_touch", "n", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 109), 
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlSeatInterface.SetEvents(
				new Message("capabilities", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 110), 
				new Message("name", "s", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 111));
			wlPointerInterface.SetRequests(
				new Message("set_cursor", "u?oii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 112), 
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlPointerInterface.SetEvents(
				new Message("enter", "uoff", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 116), 
				new Message("leave", "uo", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 120), 
				new Message("motion", "uff", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 122), 
				new Message("button", "uuuu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 125), 
				new Message("axis", "uuf", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 129), 
				new Message("frame", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("axis_source", "u", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 132), 
				new Message("axis_stop", "uu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 133), 
				new Message("axis_discrete", "ui", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 135));
			wlKeyboardInterface.SetRequests(
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlKeyboardInterface.SetEvents(
				new Message("keymap", "uhu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 137), 
				new Message("enter", "uoa", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 140), 
				new Message("leave", "uo", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 143), 
				new Message("key", "uuuu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 145), 
				new Message("modifiers", "uuuuu", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 149), 
				new Message("repeat_info", "ii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 154));
			wlTouchInterface.SetRequests(
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlTouchInterface.SetEvents(
				new Message("down", "uuoiff", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 156), 
				new Message("up", "uui", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 162), 
				new Message("motion", "uiff", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 165), 
				new Message("frame", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("cancel", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlOutputInterface.SetRequests(
				new Message("release", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlOutputInterface.SetEvents(
				new Message("geometry", "iiiiissi", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 169), 
				new Message("mode", "uiii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 177), 
				new Message("done", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("scale", "i", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 181));
			wlRegionInterface.SetRequests(
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("add", "iiii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 182), 
				new Message("subtract", "iiii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 186));
			wlRegionInterface.SetEvents();
			wlSubcompositorInterface.SetRequests(
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("get_subsurface", "noo", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 190));
			wlSubcompositorInterface.SetEvents();
			wlSubsurfaceInterface.SetRequests(
				new Message("destroy", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_position", "ii", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 193), 
				new Message("place_above", "o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 195), 
				new Message("place_below", "o", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 196), 
				new Message("set_sync", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0), 
				new Message("set_desync", "", WaylandTypes + Marshal.SizeOf(typeof(IntPtr)) * 0));
			wlSubsurfaceInterface.SetEvents();
			wlDisplayInterface.GetInterface();
			wlRegistryInterface.GetInterface();
			wlCallbackInterface.GetInterface();
			wlCompositorInterface.GetInterface();
			wlShmPoolInterface.GetInterface();
			wlShmInterface.GetInterface();
			wlBufferInterface.GetInterface();
			wlDataOfferInterface.GetInterface();
			wlDataSourceInterface.GetInterface();
			wlDataDeviceInterface.GetInterface();
			wlDataDeviceManagerInterface.GetInterface();
			wlShellInterface.GetInterface();
			wlShellSurfaceInterface.GetInterface();
			wlSurfaceInterface.GetInterface();
			wlSeatInterface.GetInterface();
			wlPointerInterface.GetInterface();
			wlKeyboardInterface.GetInterface();
			wlTouchInterface.GetInterface();
			wlOutputInterface.GetInterface();
			wlRegionInterface.GetInterface();
			wlSubcompositorInterface.GetInterface();
			wlSubsurfaceInterface.GetInterface();
		}
	}

	public class WlDisplayGlobal : Global
	{
		public WlDisplayGlobal()
		{
			 this.SetInterface("wl_display_interface");
		}
	}

	public class WlDisplay : Resource 
	{
		private WlDisplayImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlDisplayImplementation InitializeImplementation()
		{
			WlDisplayImplementation impl = new WlDisplayImplementation();
			impl.sync = this.Sync;
			impl.getRegistry = this.GetRegistry;
			return impl;
		}

		public WlDisplay(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDisplayInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlDisplay(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDisplayInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlDisplay() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlDisplayImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSync(IntPtr client, IntPtr resource, UInt32 callback);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSync sync;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetRegistry(IntPtr client, IntPtr resource, UInt32 registry);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetRegistry getRegistry;

		}

		public virtual void Sync(IntPtr client, IntPtr resource, UInt32 callback)
		{
			//Console.WriteLine("Sync");
		}

		public virtual void GetRegistry(IntPtr client, IntPtr resource, UInt32 registry)
		{
			//Console.WriteLine("GetRegistry");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_error(IntPtr resource, Int32 number, IntPtr object_id, UInt32 code, string message);
		public void SendError(IntPtr object_id, UInt32 code, string message) {
			wl_resource_post_event_error(this.resource, 0, object_id, code, message);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_delete_id(IntPtr resource, Int32 number, UInt32 id);
		public void SendDeleteId(UInt32 id) {
			wl_resource_post_event_delete_id(this.resource, 1, id);
		}
	}

	public class WlRegistryGlobal : Global
	{
		public WlRegistryGlobal()
		{
			 this.SetInterface("wl_registry_interface");
		}
	}

	public class WlRegistry : Resource 
	{
		private WlRegistryImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlRegistryImplementation InitializeImplementation()
		{
			WlRegistryImplementation impl = new WlRegistryImplementation();
			impl.bind = this.Bind;
			return impl;
		}

		public WlRegistry(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlRegistryInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlRegistry(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlRegistryInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlRegistry() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlRegistryImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackBind(IntPtr client, IntPtr resource, UInt32 name, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackBind bind;

		}

		public virtual void Bind(IntPtr client, IntPtr resource, UInt32 name, UInt32 id)
		{
			//Console.WriteLine("Bind");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_global(IntPtr resource, Int32 number, UInt32 name, string interfacePtr, UInt32 version);
		public void SendGlobal(UInt32 name, string interfacePtr, UInt32 version) {
			wl_resource_post_event_global(this.resource, 0, name, interfacePtr, version);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_global_remove(IntPtr resource, Int32 number, UInt32 name);
		public void SendGlobalRemove(UInt32 name) {
			wl_resource_post_event_global_remove(this.resource, 1, name);
		}
	}

	public class WlCallbackGlobal : Global
	{
		public WlCallbackGlobal()
		{
			 this.SetInterface("wl_callback_interface");
		}
	}

	public class WlCallback : Resource 
	{
		private WlCallbackImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlCallbackImplementation InitializeImplementation()
		{
			WlCallbackImplementation impl = new WlCallbackImplementation();

			return impl;
		}

		public WlCallback(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlCallbackInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlCallback(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlCallbackInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlCallback() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlCallbackImplementation
		{

		}



		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_done(IntPtr resource, Int32 number, UInt32 callback_data);
		public void SendDone(UInt32 callback_data) {
			wl_resource_post_event_done(this.resource, 0, callback_data);
		}
	}

	public class WlCompositorGlobal : Global
	{
		public WlCompositorGlobal()
		{
			 this.SetInterface("wl_compositor_interface");
		}
	}

	public class WlCompositor : Resource 
	{
		private WlCompositorImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlCompositorImplementation InitializeImplementation()
		{
			WlCompositorImplementation impl = new WlCompositorImplementation();
			impl.createSurface = this.CreateSurface;
			impl.createRegion = this.CreateRegion;
			return impl;
		}

		public WlCompositor(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlCompositorInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlCompositor(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlCompositorInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlCompositor() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlCompositorImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreateSurface(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreateSurface createSurface;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreateRegion(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreateRegion createRegion;

		}

		public virtual void CreateSurface(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("CreateSurface");
		}

		public virtual void CreateRegion(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("CreateRegion");
		}

	}

	public class WlShmPoolGlobal : Global
	{
		public WlShmPoolGlobal()
		{
			 this.SetInterface("wl_shm_pool_interface");
		}
	}

	public class WlShmPool : Resource 
	{
		private WlShmPoolImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlShmPoolImplementation InitializeImplementation()
		{
			WlShmPoolImplementation impl = new WlShmPoolImplementation();
			impl.createBuffer = this.CreateBuffer;
			impl.destroy = this.Destroy;
			impl.resize = this.Resize;
			return impl;
		}

		public WlShmPool(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShmPoolInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlShmPool(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShmPoolInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlShmPool() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlShmPoolImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreateBuffer(IntPtr client, IntPtr resource, UInt32 id, Int32 offset, Int32 width, Int32 height, Int32 stride, UInt32 format);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreateBuffer createBuffer;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackResize(IntPtr client, IntPtr resource, Int32 size);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackResize resize;

		}

		public virtual void CreateBuffer(IntPtr client, IntPtr resource, UInt32 id, Int32 offset, Int32 width, Int32 height, Int32 stride, UInt32 format)
		{
			//Console.WriteLine("CreateBuffer");
		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void Resize(IntPtr client, IntPtr resource, Int32 size)
		{
			//Console.WriteLine("Resize");
		}

	}

	public class WlShmGlobal : Global
	{
		public WlShmGlobal()
		{
			 this.SetInterface("wl_shm_interface");
		}
	}

	public class WlShm : Resource 
	{
		private WlShmImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlShmImplementation InitializeImplementation()
		{
			WlShmImplementation impl = new WlShmImplementation();
			impl.createPool = this.CreatePool;
			return impl;
		}

		public WlShm(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShmInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlShm(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShmInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlShm() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlShmImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreatePool(IntPtr client, IntPtr resource, UInt32 id, Int32 fd, Int32 size);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreatePool createPool;

		}

		public virtual void CreatePool(IntPtr client, IntPtr resource, UInt32 id, Int32 fd, Int32 size)
		{
			//Console.WriteLine("CreatePool");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_format(IntPtr resource, Int32 number, UInt32 format);
		public void SendFormat(UInt32 format) {
			wl_resource_post_event_format(this.resource, 0, format);
		}
	}

	public class WlBufferGlobal : Global
	{
		public WlBufferGlobal()
		{
			 this.SetInterface("wl_buffer_interface");
		}
	}

	public class WlBuffer : Resource 
	{
		private WlBufferImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlBufferImplementation InitializeImplementation()
		{
			WlBufferImplementation impl = new WlBufferImplementation();
			impl.destroy = this.Destroy;
			return impl;
		}

		public WlBuffer(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlBufferInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlBuffer(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlBufferInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlBuffer() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlBufferImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_release(IntPtr resource, Int32 number);
		public void SendRelease() {
			wl_resource_post_event_release(this.resource, 0);
		}
	}

	public class WlDataOfferGlobal : Global
	{
		public WlDataOfferGlobal()
		{
			 this.SetInterface("wl_data_offer_interface");
		}
	}

	public class WlDataOffer : Resource 
	{
		private WlDataOfferImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlDataOfferImplementation InitializeImplementation()
		{
			WlDataOfferImplementation impl = new WlDataOfferImplementation();
			impl.accept = this.Accept;
			impl.receive = this.Receive;
			impl.destroy = this.Destroy;
			impl.finish = this.Finish;
			impl.setActions = this.SetActions;
			return impl;
		}

		public WlDataOffer(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataOfferInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlDataOffer(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataOfferInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlDataOffer() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlDataOfferImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackAccept(IntPtr client, IntPtr resource, UInt32 serial, string mime_type);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackAccept accept;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackReceive(IntPtr client, IntPtr resource, string mime_type, Int32 fd);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackReceive receive;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackFinish(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackFinish finish;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetActions(IntPtr client, IntPtr resource, UInt32 dnd_actions, UInt32 preferred_action);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetActions setActions;

		}

		public virtual void Accept(IntPtr client, IntPtr resource, UInt32 serial, string mime_type)
		{
			//Console.WriteLine("Accept");
		}

		public virtual void Receive(IntPtr client, IntPtr resource, string mime_type, Int32 fd)
		{
			//Console.WriteLine("Receive");
		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void Finish(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Finish");
		}

		public virtual void SetActions(IntPtr client, IntPtr resource, UInt32 dnd_actions, UInt32 preferred_action)
		{
			//Console.WriteLine("SetActions");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_offer(IntPtr resource, Int32 number, string mime_type);
		public void SendOffer(string mime_type) {
			wl_resource_post_event_offer(this.resource, 0, mime_type);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_source_actions(IntPtr resource, Int32 number, UInt32 source_actions);
		public void SendSourceActions(UInt32 source_actions) {
			wl_resource_post_event_source_actions(this.resource, 1, source_actions);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_action(IntPtr resource, Int32 number, UInt32 dnd_action);
		public void SendAction(UInt32 dnd_action) {
			wl_resource_post_event_action(this.resource, 2, dnd_action);
		}
	}

	public class WlDataSourceGlobal : Global
	{
		public WlDataSourceGlobal()
		{
			 this.SetInterface("wl_data_source_interface");
		}
	}

	public class WlDataSource : Resource 
	{
		private WlDataSourceImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlDataSourceImplementation InitializeImplementation()
		{
			WlDataSourceImplementation impl = new WlDataSourceImplementation();
			impl.offer = this.Offer;
			impl.destroy = this.Destroy;
			impl.setActions = this.SetActions;
			return impl;
		}

		public WlDataSource(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataSourceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlDataSource(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataSourceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlDataSource() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlDataSourceImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackOffer(IntPtr client, IntPtr resource, string mime_type);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackOffer offer;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetActions(IntPtr client, IntPtr resource, UInt32 dnd_actions);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetActions setActions;

		}

		public virtual void Offer(IntPtr client, IntPtr resource, string mime_type)
		{
			//Console.WriteLine("Offer");
		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void SetActions(IntPtr client, IntPtr resource, UInt32 dnd_actions)
		{
			//Console.WriteLine("SetActions");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_target(IntPtr resource, Int32 number, string mime_type);
		public void SendTarget(string mime_type) {
			wl_resource_post_event_target(this.resource, 0, mime_type);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_send(IntPtr resource, Int32 number, string mime_type, Int32 fd);
		public void SendSend(string mime_type, Int32 fd) {
			wl_resource_post_event_send(this.resource, 1, mime_type, fd);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_cancelled(IntPtr resource, Int32 number);
		public void SendCancelled() {
			wl_resource_post_event_cancelled(this.resource, 2);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_dnd_drop_performed(IntPtr resource, Int32 number);
		public void SendDndDropPerformed() {
			wl_resource_post_event_dnd_drop_performed(this.resource, 3);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_dnd_finished(IntPtr resource, Int32 number);
		public void SendDndFinished() {
			wl_resource_post_event_dnd_finished(this.resource, 4);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_action(IntPtr resource, Int32 number, UInt32 dnd_action);
		public void SendAction(UInt32 dnd_action) {
			wl_resource_post_event_action(this.resource, 5, dnd_action);
		}
	}

	public class WlDataDeviceGlobal : Global
	{
		public WlDataDeviceGlobal()
		{
			 this.SetInterface("wl_data_device_interface");
		}
	}

	public class WlDataDevice : Resource 
	{
		private WlDataDeviceImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlDataDeviceImplementation InitializeImplementation()
		{
			WlDataDeviceImplementation impl = new WlDataDeviceImplementation();
			impl.startDrag = this.StartDrag;
			impl.setSelection = this.SetSelection;
			impl.release = this.Release;
			return impl;
		}

		public WlDataDevice(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataDeviceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlDataDevice(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataDeviceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlDataDevice() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlDataDeviceImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackStartDrag(IntPtr client, IntPtr resource, IntPtr source, IntPtr origin, IntPtr icon, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackStartDrag startDrag;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetSelection(IntPtr client, IntPtr resource, IntPtr source, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetSelection setSelection;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void StartDrag(IntPtr client, IntPtr resource, IntPtr source, IntPtr origin, IntPtr icon, UInt32 serial)
		{
			//Console.WriteLine("StartDrag");
		}

		public virtual void SetSelection(IntPtr client, IntPtr resource, IntPtr source, UInt32 serial)
		{
			//Console.WriteLine("SetSelection");
		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_data_offer(IntPtr resource, Int32 number, UInt32 id);
		public void SendDataOffer(UInt32 id) {
			wl_resource_post_event_data_offer(this.resource, 0, id);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_enter(IntPtr resource, Int32 number, UInt32 serial, IntPtr surface, Int32 x, Int32 y, IntPtr id);
		public void SendEnter(UInt32 serial, IntPtr surface, Int32 x, Int32 y, IntPtr id) {
			wl_resource_post_event_enter(this.resource, 1, serial, surface, x, y, id);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_leave(IntPtr resource, Int32 number);
		public void SendLeave() {
			wl_resource_post_event_leave(this.resource, 2);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_motion(IntPtr resource, Int32 number, UInt32 time, Int32 x, Int32 y);
		public void SendMotion(UInt32 time, Int32 x, Int32 y) {
			wl_resource_post_event_motion(this.resource, 3, time, x, y);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_drop(IntPtr resource, Int32 number);
		public void SendDrop() {
			wl_resource_post_event_drop(this.resource, 4);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_selection(IntPtr resource, Int32 number, IntPtr id);
		public void SendSelection(IntPtr id) {
			wl_resource_post_event_selection(this.resource, 5, id);
		}
	}

	public class WlDataDeviceManagerGlobal : Global
	{
		public WlDataDeviceManagerGlobal()
		{
			 this.SetInterface("wl_data_device_manager_interface");
		}
	}

	public class WlDataDeviceManager : Resource 
	{
		private WlDataDeviceManagerImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlDataDeviceManagerImplementation InitializeImplementation()
		{
			WlDataDeviceManagerImplementation impl = new WlDataDeviceManagerImplementation();
			impl.createDataSource = this.CreateDataSource;
			impl.getDataDevice = this.GetDataDevice;
			return impl;
		}

		public WlDataDeviceManager(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataDeviceManagerInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlDataDeviceManager(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlDataDeviceManagerInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlDataDeviceManager() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlDataDeviceManagerImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCreateDataSource(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCreateDataSource createDataSource;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetDataDevice(IntPtr client, IntPtr resource, UInt32 id, IntPtr seat);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetDataDevice getDataDevice;

		}

		public virtual void CreateDataSource(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("CreateDataSource");
		}

		public virtual void GetDataDevice(IntPtr client, IntPtr resource, UInt32 id, IntPtr seat)
		{
			//Console.WriteLine("GetDataDevice");
		}

	}

	public class WlShellGlobal : Global
	{
		public WlShellGlobal()
		{
			 this.SetInterface("wl_shell_interface");
		}
	}

	public class WlShell : Resource 
	{
		private WlShellImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlShellImplementation InitializeImplementation()
		{
			WlShellImplementation impl = new WlShellImplementation();
			impl.getShellSurface = this.GetShellSurface;
			return impl;
		}

		public WlShell(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShellInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlShell(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShellInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlShell() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlShellImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetShellSurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetShellSurface getShellSurface;

		}

		public virtual void GetShellSurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface)
		{
			//Console.WriteLine("GetShellSurface");
		}

	}

	public class WlShellSurfaceGlobal : Global
	{
		public WlShellSurfaceGlobal()
		{
			 this.SetInterface("wl_shell_surface_interface");
		}
	}

	public class WlShellSurface : Resource 
	{
		private WlShellSurfaceImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlShellSurfaceImplementation InitializeImplementation()
		{
			WlShellSurfaceImplementation impl = new WlShellSurfaceImplementation();
			impl.pong = this.Pong;
			impl.move = this.Move;
			impl.resize = this.Resize;
			impl.setToplevel = this.SetToplevel;
			impl.setTransient = this.SetTransient;
			impl.setFullscreen = this.SetFullscreen;
			impl.setPopup = this.SetPopup;
			impl.setMaximized = this.SetMaximized;
			impl.setTitle = this.SetTitle;
			impl.setClass = this.SetClass;
			return impl;
		}

		public WlShellSurface(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShellSurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlShellSurface(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlShellSurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlShellSurface() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlShellSurfaceImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackPong(IntPtr client, IntPtr resource, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackPong pong;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackMove(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackMove move;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackResize(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, UInt32 edges);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackResize resize;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetToplevel(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetToplevel setToplevel;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetTransient(IntPtr client, IntPtr resource, IntPtr parent, Int32 x, Int32 y, UInt32 flags);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetTransient setTransient;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetFullscreen(IntPtr client, IntPtr resource, UInt32 method, UInt32 framerate, IntPtr output);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetFullscreen setFullscreen;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetPopup(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, IntPtr parent, Int32 x, Int32 y, UInt32 flags);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetPopup setPopup;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetMaximized(IntPtr client, IntPtr resource, IntPtr output);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetMaximized setMaximized;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetTitle(IntPtr client, IntPtr resource, string title);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetTitle setTitle;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetClass(IntPtr client, IntPtr resource, string class_);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetClass setClass;

		}

		public virtual void Pong(IntPtr client, IntPtr resource, UInt32 serial)
		{
			//Console.WriteLine("Pong");
		}

		public virtual void Move(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial)
		{
			//Console.WriteLine("Move");
		}

		public virtual void Resize(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, UInt32 edges)
		{
			//Console.WriteLine("Resize");
		}

		public virtual void SetToplevel(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("SetToplevel");
		}

		public virtual void SetTransient(IntPtr client, IntPtr resource, IntPtr parent, Int32 x, Int32 y, UInt32 flags)
		{
			//Console.WriteLine("SetTransient");
		}

		public virtual void SetFullscreen(IntPtr client, IntPtr resource, UInt32 method, UInt32 framerate, IntPtr output)
		{
			//Console.WriteLine("SetFullscreen");
		}

		public virtual void SetPopup(IntPtr client, IntPtr resource, IntPtr seat, UInt32 serial, IntPtr parent, Int32 x, Int32 y, UInt32 flags)
		{
			//Console.WriteLine("SetPopup");
		}

		public virtual void SetMaximized(IntPtr client, IntPtr resource, IntPtr output)
		{
			//Console.WriteLine("SetMaximized");
		}

		public virtual void SetTitle(IntPtr client, IntPtr resource, string title)
		{
			//Console.WriteLine("SetTitle");
		}

		public virtual void SetClass(IntPtr client, IntPtr resource, string class_)
		{
			//Console.WriteLine("SetClass");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_ping(IntPtr resource, Int32 number, UInt32 serial);
		public void SendPing(UInt32 serial) {
			wl_resource_post_event_ping(this.resource, 0, serial);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_configure(IntPtr resource, Int32 number, UInt32 edges, Int32 width, Int32 height);
		public void SendConfigure(UInt32 edges, Int32 width, Int32 height) {
			wl_resource_post_event_configure(this.resource, 1, edges, width, height);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_popup_done(IntPtr resource, Int32 number);
		public void SendPopupDone() {
			wl_resource_post_event_popup_done(this.resource, 2);
		}
	}

	public class WlSurfaceGlobal : Global
	{
		public WlSurfaceGlobal()
		{
			 this.SetInterface("wl_surface_interface");
		}
	}

	public class WlSurface : Resource 
	{
		private WlSurfaceImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlSurfaceImplementation InitializeImplementation()
		{
			WlSurfaceImplementation impl = new WlSurfaceImplementation();
			impl.destroy = this.Destroy;
			impl.attach = this.Attach;
			impl.damage = this.Damage;
			impl.frame = this.Frame;
			impl.setOpaqueRegion = this.SetOpaqueRegion;
			impl.setInputRegion = this.SetInputRegion;
			impl.commit = this.Commit;
			impl.setBufferTransform = this.SetBufferTransform;
			impl.setBufferScale = this.SetBufferScale;
			impl.damageBuffer = this.DamageBuffer;
			return impl;
		}

		public WlSurface(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlSurface(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlSurface() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlSurfaceImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackAttach(IntPtr client, IntPtr resource, IntPtr buffer, Int32 x, Int32 y);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackAttach attach;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDamage(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDamage damage;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackFrame(IntPtr client, IntPtr resource, UInt32 callback);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackFrame frame;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetOpaqueRegion(IntPtr client, IntPtr resource, IntPtr region);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetOpaqueRegion setOpaqueRegion;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetInputRegion(IntPtr client, IntPtr resource, IntPtr region);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetInputRegion setInputRegion;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackCommit(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackCommit commit;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetBufferTransform(IntPtr client, IntPtr resource, Int32 transform);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetBufferTransform setBufferTransform;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetBufferScale(IntPtr client, IntPtr resource, Int32 scale);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetBufferScale setBufferScale;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDamageBuffer(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDamageBuffer damageBuffer;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void Attach(IntPtr client, IntPtr resource, IntPtr buffer, Int32 x, Int32 y)
		{
			//Console.WriteLine("Attach");
		}

		public virtual void Damage(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			//Console.WriteLine("Damage");
		}

		public virtual void Frame(IntPtr client, IntPtr resource, UInt32 callback)
		{
			//Console.WriteLine("Frame");
		}

		public virtual void SetOpaqueRegion(IntPtr client, IntPtr resource, IntPtr region)
		{
			//Console.WriteLine("SetOpaqueRegion");
		}

		public virtual void SetInputRegion(IntPtr client, IntPtr resource, IntPtr region)
		{
			//Console.WriteLine("SetInputRegion");
		}

		public virtual void Commit(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Commit");
		}

		public virtual void SetBufferTransform(IntPtr client, IntPtr resource, Int32 transform)
		{
			//Console.WriteLine("SetBufferTransform");
		}

		public virtual void SetBufferScale(IntPtr client, IntPtr resource, Int32 scale)
		{
			//Console.WriteLine("SetBufferScale");
		}

		public virtual void DamageBuffer(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			//Console.WriteLine("DamageBuffer");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_enter(IntPtr resource, Int32 number, IntPtr output);
		public void SendEnter(IntPtr output) {
			wl_resource_post_event_enter(this.resource, 0, output);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_leave(IntPtr resource, Int32 number, IntPtr output);
		public void SendLeave(IntPtr output) {
			wl_resource_post_event_leave(this.resource, 1, output);
		}
	}

	public class WlSeatGlobal : Global
	{
		public WlSeatGlobal()
		{
			 this.SetInterface("wl_seat_interface");
		}
	}

	public class WlSeat : Resource 
	{
		private WlSeatImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlSeatImplementation InitializeImplementation()
		{
			WlSeatImplementation impl = new WlSeatImplementation();
			impl.getPointer = this.GetPointer;
			impl.getKeyboard = this.GetKeyboard;
			impl.getTouch = this.GetTouch;
			impl.release = this.Release;
			return impl;
		}

		public WlSeat(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSeatInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlSeat(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSeatInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlSeat() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlSeatImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetPointer(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetPointer getPointer;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetKeyboard(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetKeyboard getKeyboard;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetTouch(IntPtr client, IntPtr resource, UInt32 id);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetTouch getTouch;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void GetPointer(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("GetPointer");
		}

		public virtual void GetKeyboard(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("GetKeyboard");
		}

		public virtual void GetTouch(IntPtr client, IntPtr resource, UInt32 id)
		{
			//Console.WriteLine("GetTouch");
		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_capabilities(IntPtr resource, Int32 number, UInt32 capabilities);
		public void SendCapabilities(UInt32 capabilities) {
			wl_resource_post_event_capabilities(this.resource, 0, capabilities);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_name(IntPtr resource, Int32 number, string name);
		public void SendName(string name) {
			wl_resource_post_event_name(this.resource, 1, name);
		}
	}

	public class WlPointerGlobal : Global
	{
		public WlPointerGlobal()
		{
			 this.SetInterface("wl_pointer_interface");
		}
	}

	public class WlPointer : Resource 
	{
		private WlPointerImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlPointerImplementation InitializeImplementation()
		{
			WlPointerImplementation impl = new WlPointerImplementation();
			impl.setCursor = this.SetCursor;
			impl.release = this.Release;
			return impl;
		}

		public WlPointer(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlPointerInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlPointer(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlPointerInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlPointer() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlPointerImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetCursor(IntPtr client, IntPtr resource, UInt32 serial, IntPtr surface, Int32 hotspot_x, Int32 hotspot_y);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetCursor setCursor;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void SetCursor(IntPtr client, IntPtr resource, UInt32 serial, IntPtr surface, Int32 hotspot_x, Int32 hotspot_y)
		{
			//Console.WriteLine("SetCursor");
		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_enter(IntPtr resource, Int32 number, UInt32 serial, IntPtr surface, Int32 surface_x, Int32 surface_y);
		public void SendEnter(UInt32 serial, IntPtr surface, Int32 surface_x, Int32 surface_y) {
			wl_resource_post_event_enter(this.resource, 0, serial, surface, surface_x, surface_y);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_leave(IntPtr resource, Int32 number, UInt32 serial, IntPtr surface);
		public void SendLeave(UInt32 serial, IntPtr surface) {
			wl_resource_post_event_leave(this.resource, 1, serial, surface);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_motion(IntPtr resource, Int32 number, UInt32 time, Int32 surface_x, Int32 surface_y);
		public void SendMotion(UInt32 time, Int32 surface_x, Int32 surface_y) {
			wl_resource_post_event_motion(this.resource, 2, time, surface_x, surface_y);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_button(IntPtr resource, Int32 number, UInt32 serial, UInt32 time, UInt32 button, UInt32 state);
		public void SendButton(UInt32 serial, UInt32 time, UInt32 button, UInt32 state) {
			wl_resource_post_event_button(this.resource, 3, serial, time, button, state);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_axis(IntPtr resource, Int32 number, UInt32 time, UInt32 axis, Int32 value);
		public void SendAxis(UInt32 time, UInt32 axis, Int32 value) {
			wl_resource_post_event_axis(this.resource, 4, time, axis, value);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_frame(IntPtr resource, Int32 number);
		public void SendFrame() {
			wl_resource_post_event_frame(this.resource, 5);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_axis_source(IntPtr resource, Int32 number, UInt32 axis_source);
		public void SendAxisSource(UInt32 axis_source) {
			wl_resource_post_event_axis_source(this.resource, 6, axis_source);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_axis_stop(IntPtr resource, Int32 number, UInt32 time, UInt32 axis);
		public void SendAxisStop(UInt32 time, UInt32 axis) {
			wl_resource_post_event_axis_stop(this.resource, 7, time, axis);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_axis_discrete(IntPtr resource, Int32 number, UInt32 axis, Int32 discrete);
		public void SendAxisDiscrete(UInt32 axis, Int32 discrete) {
			wl_resource_post_event_axis_discrete(this.resource, 8, axis, discrete);
		}
	}

	public class WlKeyboardGlobal : Global
	{
		public WlKeyboardGlobal()
		{
			 this.SetInterface("wl_keyboard_interface");
		}
	}

	public class WlKeyboard : Resource 
	{
		private WlKeyboardImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlKeyboardImplementation InitializeImplementation()
		{
			WlKeyboardImplementation impl = new WlKeyboardImplementation();
			impl.release = this.Release;
			return impl;
		}

		public WlKeyboard(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlKeyboardInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlKeyboard(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlKeyboardInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlKeyboard() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlKeyboardImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_keymap(IntPtr resource, Int32 number, UInt32 format, Int32 fd, UInt32 size);
		public void SendKeymap(UInt32 format, Int32 fd, UInt32 size) {
			wl_resource_post_event_keymap(this.resource, 0, format, fd, size);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_enter(IntPtr resource, Int32 number, UInt32 serial, IntPtr surface, IntPtr keys);
		public void SendEnter(UInt32 serial, IntPtr surface, IntPtr keys) {
			wl_resource_post_event_enter(this.resource, 1, serial, surface, keys);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_leave(IntPtr resource, Int32 number, UInt32 serial, IntPtr surface);
		public void SendLeave(UInt32 serial, IntPtr surface) {
			wl_resource_post_event_leave(this.resource, 2, serial, surface);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_key(IntPtr resource, Int32 number, UInt32 serial, UInt32 time, UInt32 key, UInt32 state);
		public void SendKey(UInt32 serial, UInt32 time, UInt32 key, UInt32 state) {
			wl_resource_post_event_key(this.resource, 3, serial, time, key, state);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_modifiers(IntPtr resource, Int32 number, UInt32 serial, UInt32 mods_depressed, UInt32 mods_latched, UInt32 mods_locked, UInt32 group);
		public void SendModifiers(UInt32 serial, UInt32 mods_depressed, UInt32 mods_latched, UInt32 mods_locked, UInt32 group) {
			wl_resource_post_event_modifiers(this.resource, 4, serial, mods_depressed, mods_latched, mods_locked, group);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_repeat_info(IntPtr resource, Int32 number, Int32 rate, Int32 delay);
		public void SendRepeatInfo(Int32 rate, Int32 delay) {
			wl_resource_post_event_repeat_info(this.resource, 5, rate, delay);
		}
	}

	public class WlTouchGlobal : Global
	{
		public WlTouchGlobal()
		{
			 this.SetInterface("wl_touch_interface");
		}
	}

	public class WlTouch : Resource 
	{
		private WlTouchImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlTouchImplementation InitializeImplementation()
		{
			WlTouchImplementation impl = new WlTouchImplementation();
			impl.release = this.Release;
			return impl;
		}

		public WlTouch(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlTouchInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlTouch(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlTouchInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlTouch() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlTouchImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_down(IntPtr resource, Int32 number, UInt32 serial, UInt32 time, IntPtr surface, Int32 id, Int32 x, Int32 y);
		public void SendDown(UInt32 serial, UInt32 time, IntPtr surface, Int32 id, Int32 x, Int32 y) {
			wl_resource_post_event_down(this.resource, 0, serial, time, surface, id, x, y);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_up(IntPtr resource, Int32 number, UInt32 serial, UInt32 time, Int32 id);
		public void SendUp(UInt32 serial, UInt32 time, Int32 id) {
			wl_resource_post_event_up(this.resource, 1, serial, time, id);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_motion(IntPtr resource, Int32 number, UInt32 time, Int32 id, Int32 x, Int32 y);
		public void SendMotion(UInt32 time, Int32 id, Int32 x, Int32 y) {
			wl_resource_post_event_motion(this.resource, 2, time, id, x, y);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_frame(IntPtr resource, Int32 number);
		public void SendFrame() {
			wl_resource_post_event_frame(this.resource, 3);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_cancel(IntPtr resource, Int32 number);
		public void SendCancel() {
			wl_resource_post_event_cancel(this.resource, 4);
		}
	}

	public class WlOutputGlobal : Global
	{
		public WlOutputGlobal()
		{
			 this.SetInterface("wl_output_interface");
		}
	}

	public class WlOutput : Resource 
	{
		private WlOutputImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlOutputImplementation InitializeImplementation()
		{
			WlOutputImplementation impl = new WlOutputImplementation();
			impl.release = this.Release;
			return impl;
		}

		public WlOutput(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlOutputInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlOutput(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlOutputInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlOutput() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlOutputImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackRelease(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackRelease release;

		}

		public virtual void Release(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Release");
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_geometry(IntPtr resource, Int32 number, Int32 x, Int32 y, Int32 physical_width, Int32 physical_height, Int32 subpixel, string make, string model, Int32 transform);
		public void SendGeometry(Int32 x, Int32 y, Int32 physical_width, Int32 physical_height, Int32 subpixel, string make, string model, Int32 transform) {
			wl_resource_post_event_geometry(this.resource, 0, x, y, physical_width, physical_height, subpixel, make, model, transform);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_mode(IntPtr resource, Int32 number, UInt32 flags, Int32 width, Int32 height, Int32 refresh);
		public void SendMode(UInt32 flags, Int32 width, Int32 height, Int32 refresh) {
			wl_resource_post_event_mode(this.resource, 1, flags, width, height, refresh);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_done(IntPtr resource, Int32 number);
		public void SendDone() {
			wl_resource_post_event_done(this.resource, 2);
		}

		[DllImport("libwayland-server.so", EntryPoint="wl_resource_post_event")]
		private static extern void wl_resource_post_event_scale(IntPtr resource, Int32 number, Int32 factor);
		public void SendScale(Int32 factor) {
			wl_resource_post_event_scale(this.resource, 3, factor);
		}
	}

	public class WlRegionGlobal : Global
	{
		public WlRegionGlobal()
		{
			 this.SetInterface("wl_region_interface");
		}
	}

	public class WlRegion : Resource 
	{
		private WlRegionImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlRegionImplementation InitializeImplementation()
		{
			WlRegionImplementation impl = new WlRegionImplementation();
			impl.destroy = this.Destroy;
			impl.add = this.Add;
			impl.subtract = this.Subtract;
			return impl;
		}

		public WlRegion(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlRegionInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlRegion(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlRegionInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlRegion() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlRegionImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackAdd(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackAdd add;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSubtract(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSubtract subtract;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void Add(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			//Console.WriteLine("Add");
		}

		public virtual void Subtract(IntPtr client, IntPtr resource, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			//Console.WriteLine("Subtract");
		}

	}

	public class WlSubcompositorGlobal : Global
	{
		public WlSubcompositorGlobal()
		{
			 this.SetInterface("wl_subcompositor_interface");
		}
	}

	public class WlSubcompositor : Resource 
	{
		private WlSubcompositorImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlSubcompositorImplementation InitializeImplementation()
		{
			WlSubcompositorImplementation impl = new WlSubcompositorImplementation();
			impl.destroy = this.Destroy;
			impl.getSubsurface = this.GetSubsurface;
			return impl;
		}

		public WlSubcompositor(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSubcompositorInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlSubcompositor(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSubcompositorInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlSubcompositor() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlSubcompositorImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackGetSubsurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface, IntPtr parent);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackGetSubsurface getSubsurface;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void GetSubsurface(IntPtr client, IntPtr resource, UInt32 id, IntPtr surface, IntPtr parent)
		{
			//Console.WriteLine("GetSubsurface");
		}

	}

	public class WlSubsurfaceGlobal : Global
	{
		public WlSubsurfaceGlobal()
		{
			 this.SetInterface("wl_subsurface_interface");
		}
	}

	public class WlSubsurface : Resource 
	{
		private WlSubsurfaceImplementation managedImplementation; // Store managed copy of implementation so delegates are not GC'd

		public WlSubsurfaceImplementation InitializeImplementation()
		{
			WlSubsurfaceImplementation impl = new WlSubsurfaceImplementation();
			impl.destroy = this.Destroy;
			impl.setPosition = this.SetPosition;
			impl.placeAbove = this.PlaceAbove;
			impl.placeBelow = this.PlaceBelow;
			impl.setSync = this.SetSync;
			impl.setDesync = this.SetDesync;
			return impl;
		}

		public WlSubsurface(IntPtr clientPtr, UInt32 id, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSubsurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, resource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		public WlSubsurface(IntPtr clientPtr, UInt32 id, IntPtr otherResource, bool addToClient = true) 
		{
			this.client = Display.GetClient(clientPtr);
			this.resource = Resource.Create(clientPtr, WaylandInterfaces.wlSubsurfaceInterface.ifaceNative, 1, id);
			managedImplementation = this.InitializeImplementation();
			this.implementation = Marshal.AllocHGlobal(Marshal.SizeOf(managedImplementation));
			Marshal.StructureToPtr(managedImplementation, this.implementation, false);
			Resource.SetImplementation(resource, this.implementation, otherResource, IntPtr.Zero);
			if (addToClient)
			{
				client.resources.Add(this);
			}
		}

		~WlSubsurface() 
		{
			Marshal.FreeHGlobal(this.implementation);
		}


		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct WlSubsurfaceImplementation
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackDestroy(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackDestroy destroy;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetPosition(IntPtr client, IntPtr resource, Int32 x, Int32 y);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetPosition setPosition;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackPlaceAbove(IntPtr client, IntPtr resource, IntPtr sibling);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackPlaceAbove placeAbove;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackPlaceBelow(IntPtr client, IntPtr resource, IntPtr sibling);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackPlaceBelow placeBelow;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetSync(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetSync setSync;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void CallbackSetDesync(IntPtr client, IntPtr resource);
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public CallbackSetDesync setDesync;

		}

		public virtual void Destroy(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("Destroy");
		}

		public virtual void SetPosition(IntPtr client, IntPtr resource, Int32 x, Int32 y)
		{
			//Console.WriteLine("SetPosition");
		}

		public virtual void PlaceAbove(IntPtr client, IntPtr resource, IntPtr sibling)
		{
			//Console.WriteLine("PlaceAbove");
		}

		public virtual void PlaceBelow(IntPtr client, IntPtr resource, IntPtr sibling)
		{
			//Console.WriteLine("PlaceBelow");
		}

		public virtual void SetSync(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("SetSync");
		}

		public virtual void SetDesync(IntPtr client, IntPtr resource)
		{
			//Console.WriteLine("SetDesync");
		}

	}
}
