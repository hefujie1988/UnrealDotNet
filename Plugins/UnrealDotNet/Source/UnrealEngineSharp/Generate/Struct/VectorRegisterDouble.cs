// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\UnrealMathFPU.h:30

namespace UnrealEngine
{
	public  partial class VectorRegisterDouble : NativeStructWrapper
	{
		internal VectorRegisterDouble(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public VectorRegisterDouble() :
			base(E_CreateStruct_VectorRegisterDouble(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_VectorRegisterDouble();
		
		#endregion
		
		public static implicit operator IntPtr(VectorRegisterDouble self)
		{
			return self.NativePointer;
		}

		public static implicit operator VectorRegisterDouble(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new VectorRegisterDouble(Adress, false);
		}