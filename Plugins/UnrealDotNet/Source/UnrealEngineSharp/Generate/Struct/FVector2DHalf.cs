// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Vector2DHalf.h:13

namespace UnrealEngine
{
	public  partial class FVector2DHalf : NativeStructWrapper
	{
		internal FVector2DHalf(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default Constructor (no initialization). </para>
		/// </summary>
		public FVector2DHalf() :
			base(E_CreateStruct_FVector2DHalf(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <para>InX half float X value </para>
		/// <para>Iny half float Y value </para>
		/// </summary>
		public FVector2DHalf(FFloat16 inX, FFloat16 inY) :
			base(E_CreateStruct_FVector2DHalf_FFloat16_FFloat16(inX, inY), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <para>InX float X value </para>
		/// <para>Iny float Y value </para>
		/// </summary>
		public FVector2DHalf(float inX, float inY) :
			base(E_CreateStruct_FVector2DHalf_float_float(inX, inY), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <para>Vector2D float vector </para>
		/// </summary>
		public FVector2DHalf(FVector2D vector2D) :
			base(E_CreateStruct_FVector2DHalf_FVector2D(vector2D), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVector2DHalf_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2DHalf_X_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVector2DHalf_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2DHalf_Y_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2DHalf();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2DHalf_FFloat16_FFloat16(IntPtr inX, IntPtr inY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2DHalf_float_float(float inX, float inY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2DHalf_FVector2D(IntPtr vector2D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector2DHalf_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds the vector's X-component. </para>
		/// </summary>
		public FFloat16 X
		{
			get => E_PROP_FVector2DHalf_X_GET(NativePointer);
			set => E_PROP_FVector2DHalf_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the vector's Y-component. </para>
		/// </summary>
		public FFloat16 Y
		{
			get => E_PROP_FVector2DHalf_Y_GET(NativePointer);
			set => E_PROP_FVector2DHalf_Y_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector2DHalf_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector2DHalf self)
		{
			return self.NativePointer;
		}

		public static implicit operator FVector2DHalf(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector2DHalf(Adress, false);
		}