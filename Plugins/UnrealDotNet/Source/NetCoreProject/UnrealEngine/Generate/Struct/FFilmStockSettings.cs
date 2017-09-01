using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FFilmStockSettings
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FFilmStockSettings()
		{
			NativePointer = E_CreateStruct_FFilmStockSettings();
			IsRef = false;
		}

		internal FFilmStockSettings(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FFilmStockSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FFilmStockSettings_Slope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFilmStockSettings_Slope_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FFilmStockSettings_Toe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFilmStockSettings_Toe_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FFilmStockSettings_Shoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFilmStockSettings_Shoulder_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FFilmStockSettings_BlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFilmStockSettings_BlackClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FFilmStockSettings_WhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFilmStockSettings_WhiteClip_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float Slope
		{
			get => E_PROP_FFilmStockSettings_Slope_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Slope_SET(NativePointer, value);
		}

		public float Toe
		{
			get => E_PROP_FFilmStockSettings_Toe_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Toe_SET(NativePointer, value);
		}

		public float Shoulder
		{
			get => E_PROP_FFilmStockSettings_Shoulder_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Shoulder_SET(NativePointer, value);
		}

		public float Blackclip
		{
			get => E_PROP_FFilmStockSettings_BlackClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_BlackClip_SET(NativePointer, value);
		}

		public float Whiteclip
		{
			get => E_PROP_FFilmStockSettings_WhiteClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_WhiteClip_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFilmStockSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFilmStockSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilmStockSettings(Adress, false);
		}