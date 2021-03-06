// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:79

namespace UnrealEngine
{
	public partial class FPreCulledStaticMeshSection : NativeStructWrapper
	{
		public FPreCulledStaticMeshSection(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPreCulledStaticMeshSection() :
			base(E_CreateStruct_FPreCulledStaticMeshSection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPreCulledStaticMeshSection();
		
		#endregion
		
		public static implicit operator IntPtr(FPreCulledStaticMeshSection self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPreCulledStaticMeshSection(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPreCulledStaticMeshSection(adress, false);
		}}}
