// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:106

namespace UnrealEngine
{
	public partial class FInstancedStaticMeshMappingInfo : NativeStructWrapper
	{
		public FInstancedStaticMeshMappingInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInstancedStaticMeshMappingInfo() :
			base(E_CreateStruct_FInstancedStaticMeshMappingInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshMappingInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshMappingInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInstancedStaticMeshMappingInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInstancedStaticMeshMappingInfo(adress, false);
		}}}
