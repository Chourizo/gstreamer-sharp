// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ByteReader : GLib.Opaque {

		public uint Size {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					*raw_ptr = value;
				}
			}
		}

		public uint Byte {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("byte"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("byte"));
					*raw_ptr = value;
				}
			}
		}

		public ByteReader(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("data"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // data
							, null
							, "size"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("size"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // size
							, "data"
							, "byte"
							, (long) Marshal.OffsetOf(typeof(GstByteReader_sizeAlign), "size")
							, 0
							),
						new GLib.AbiField("byte"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // byte
							, "size"
							, "_gst_reserved"
							, (long) Marshal.OffsetOf(typeof(GstByteReader_byteAlign), "_byte")
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "byte"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstByteReader_sizeAlign
		{
			sbyte f1;
			private uint size;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstByteReader_byteAlign
		{
			sbyte f1;
			private uint _byte;
		}


		// End of the ABI representation.

#endregion
	}
}
