using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3530

namespace UnrealEngine
{
	public  partial class FDirectoryPath : NativeStructWrapper
	{
		internal FDirectoryPath(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDirectoryPath() :
			base(E_CreateStruct_FDirectoryPath(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDirectoryPath();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FDirectoryPath_Path_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDirectoryPath_Path_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The path to the directory. </para>
		/// </summary>
		public string Path
		{
			get => E_PROP_FDirectoryPath_Path_GET(NativePointer);
			set => E_PROP_FDirectoryPath_Path_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDirectoryPath Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDirectoryPath(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDirectoryPath(Adress, false);
		}}}
