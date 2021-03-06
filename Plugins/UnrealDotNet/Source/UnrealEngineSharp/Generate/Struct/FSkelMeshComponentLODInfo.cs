// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:148

namespace UnrealEngine
{
	public partial class FSkelMeshComponentLODInfo : NativeStructWrapper
	{
		public FSkelMeshComponentLODInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FSkelMeshComponentLODInfo() :
			base(E_CreateStruct_FSkelMeshComponentLODInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSkelMeshComponentLODInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_BeginReleaseOverrideSkinWeights(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_BeginReleaseOverrideVertexColors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_ReleaseOverrideSkinWeightsAndBlock(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_ReleaseOverrideVertexColorsAndBlock(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public void BeginReleaseOverrideSkinWeights()
			=> E_FSkelMeshComponentLODInfo_BeginReleaseOverrideSkinWeights(this);
		
		public void BeginReleaseOverrideVertexColors()
			=> E_FSkelMeshComponentLODInfo_BeginReleaseOverrideVertexColors(this);
		
		public void ReleaseOverrideSkinWeightsAndBlock()
			=> E_FSkelMeshComponentLODInfo_ReleaseOverrideSkinWeightsAndBlock(this);
		
		public void ReleaseOverrideVertexColorsAndBlock()
			=> E_FSkelMeshComponentLODInfo_ReleaseOverrideVertexColorsAndBlock(this);
		
		#endregion
		
		public static implicit operator IntPtr(FSkelMeshComponentLODInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSkelMeshComponentLODInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSkelMeshComponentLODInfo(adress, false);
		}}}
