// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.BusFlagsGType))]
	public enum BusFlags {

		Flushing = 16,
		FlagLast = 32,
	}

	internal class BusFlagsGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_bus_flags_get_type ());
			}
		}
	}
#endregion
}