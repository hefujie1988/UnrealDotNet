// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:996

namespace UnrealEngine
{
	public partial class FGetActionsBoundToKey : NativeStructWrapper
	{
		public FGetActionsBoundToKey(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FGetActionsBoundToKey() :
			base(E_CreateStruct_FGetActionsBoundToKey(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGetActionsBoundToKey();
		
		#endregion
		
		public static implicit operator IntPtr(FGetActionsBoundToKey self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FGetActionsBoundToKey(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FGetActionsBoundToKey(adress, false);
		}}}
