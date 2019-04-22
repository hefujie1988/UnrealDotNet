// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:79

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshInstanceData : NativeStructWrapper
	{
		internal FInstancedStaticMeshInstanceData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInstancedStaticMeshInstanceData() :
			base(E_CreateStruct_FInstancedStaticMeshInstanceData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData();
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshInstanceData self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshInstanceData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshInstanceData(Adress, false);
		}}}
