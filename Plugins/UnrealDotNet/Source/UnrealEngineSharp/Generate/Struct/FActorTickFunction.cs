// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:428

namespace UnrealEngine
{
	public partial class FActorTickFunction : FTickFunction
	{
		public FActorTickFunction(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FActorTickFunction() :
			base(E_CreateStruct_FActorTickFunction(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FActorTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorTickFunction();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// AActor  that is the target of this tick
		/// </summary>
		public AActor Target
		{
			get => E_PROP_FActorTickFunction_Target_GET(NativePointer);
			set => E_PROP_FActorTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActorTickFunction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FActorTickFunction(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FActorTickFunction(adress, false);
		}}}
