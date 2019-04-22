// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\IntRect.h:17

namespace UnrealEngine
{
	public  partial class FIntRect : NativeStructWrapper
	{
		internal FIntRect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// </summary>
		public FIntRect() :
			base(E_CreateStruct_FIntRect(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="X0">Minimum X coordinate. </param>
		/// <param name="Y0">Minimum Y coordinate. </param>
		/// <param name="X1">Maximum X coordinate. </param>
		/// <param name="Y1">Maximum Y coordinate. </param>
		/// </summary>
		public FIntRect(int x0, int y0, int x1, int y1) :
			base(E_CreateStruct_FIntRect_int32_int32_int32_int32(x0, y0, x1, y1), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="InMin">Minimum Point </param>
		/// <param name="InMax">Maximum Point </param>
		/// </summary>
		public FIntRect(FIntPoint inMin, FIntPoint inMax) :
			base(E_CreateStruct_FIntRect_FIntPoint_FIntPoint(inMin, inMax), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FIntRect_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntRect_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FIntRect_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntRect_Min_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntRect();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntRect_int32_int32_int32_int32(int x0, int y0, int x1, int y1);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntRect_FIntPoint_FIntPoint(IntPtr inMin, IntPtr inMax);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds the last pixel line/row (like in Win32 RECT). </para>
		/// </summary>
		public FIntPoint Max
		{
			get => E_PROP_FIntRect_Max_GET(NativePointer);
			set => E_PROP_FIntRect_Max_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the first pixel line/row (like in Win32 RECT). </para>
		/// </summary>
		public FIntPoint Min
		{
			get => E_PROP_FIntRect_Min_GET(NativePointer);
			set => E_PROP_FIntRect_Min_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FIntRect self)
		{
			return self.NativePointer;
		}

		public static implicit operator FIntRect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FIntRect(Adress, false);
		}}}
