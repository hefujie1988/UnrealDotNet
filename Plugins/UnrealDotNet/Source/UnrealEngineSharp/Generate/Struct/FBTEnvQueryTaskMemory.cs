// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_RunEQSQuery.h:14

namespace UnrealEngine
{
	public partial class FBTEnvQueryTaskMemory : NativeStructWrapper
	{
		public FBTEnvQueryTaskMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTEnvQueryTaskMemory() :
			base(E_CreateStruct_FBTEnvQueryTaskMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBTEnvQueryTaskMemory_RequestID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTEnvQueryTaskMemory_RequestID_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTEnvQueryTaskMemory();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Query request ID
		/// </summary>
		public int RequestID
		{
			get => E_PROP_FBTEnvQueryTaskMemory_RequestID_GET(NativePointer);
			set => E_PROP_FBTEnvQueryTaskMemory_RequestID_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTEnvQueryTaskMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTEnvQueryTaskMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTEnvQueryTaskMemory(adress, false);
		}}}
