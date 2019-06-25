// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\HotSpots\AIHotSpotManager.h:10

namespace UnrealEngine
{
	public partial class UAIHotSpotManager : UObject
	{
		public UAIHotSpotManager(IntPtr adress)
			: base(adress)
		{
		}

		public UAIHotSpotManager(UObject Parent = null, string Name = "AIHotSpotManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIHotSpotManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIHotSpotManager(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UAIHotSpotManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIHotSpotManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIHotSpotManager>(PtrDesc);
		}}}
