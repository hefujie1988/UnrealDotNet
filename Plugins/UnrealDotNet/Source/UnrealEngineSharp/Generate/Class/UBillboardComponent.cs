// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

namespace UnrealEngine
{
	public  partial class UBillboardComponent : UPrimitiveComponent
	{
		public UBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBillboardComponent(UObject Parent = null, string Name = "BillboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBillboardComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBillboardComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBillboardComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBillboardComponent>(PtrDesc);
		}}}
