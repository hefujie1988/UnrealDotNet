// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:1253

namespace UnrealEngine
{
	public partial class FDirectAttachChildrenAccessor : NativeStructWrapper
	{
		public FDirectAttachChildrenAccessor(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FDirectAttachChildrenAccessor() :
			base(E_CreateStruct_FDirectAttachChildrenAccessor(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDirectAttachChildrenAccessor();
		
		#endregion
		
		public static implicit operator IntPtr(FDirectAttachChildrenAccessor self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDirectAttachChildrenAccessor(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDirectAttachChildrenAccessor(adress, false);
		}}}
