// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:143

namespace UnrealEngine
{
	public partial class FInputActionKeyMapping : NativeStructWrapper
	{
		public FInputActionKeyMapping(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FInputActionKeyMapping(string inActionName) :
			base(E_CreateStruct_FInputActionKeyMapping_FName(inActionName), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FInputActionKeyMapping_ActionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionKeyMapping_ActionName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputActionKeyMapping_bAlt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionKeyMapping_bAlt_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputActionKeyMapping_bCmd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionKeyMapping_bCmd_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputActionKeyMapping_bCtrl_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionKeyMapping_bCtrl_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FInputActionKeyMapping_bShift_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInputActionKeyMapping_bShift_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInputActionKeyMapping_FName(string inActionName);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Friendly name of action, e.g "jump"
		/// </summary>
		public string ActionName
		{
			get => E_PROP_FInputActionKeyMapping_ActionName_GET(NativePointer);
			set => E_PROP_FInputActionKeyMapping_ActionName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// true if one of the Alt keys must be down when the KeyEvent is received to be acknowledged
		/// </summary>
		public byte bAlt
		{
			get => E_PROP_FInputActionKeyMapping_bAlt_GET(NativePointer);
			set => E_PROP_FInputActionKeyMapping_bAlt_SET(NativePointer, value);
		}

		
		/// <summary>
		/// true if one of the Cmd keys must be down when the KeyEvent is received to be acknowledged
		/// </summary>
		public byte bCmd
		{
			get => E_PROP_FInputActionKeyMapping_bCmd_GET(NativePointer);
			set => E_PROP_FInputActionKeyMapping_bCmd_SET(NativePointer, value);
		}

		
		/// <summary>
		/// true if one of the Ctrl keys must be down when the KeyEvent is received to be acknowledged
		/// </summary>
		public byte bCtrl
		{
			get => E_PROP_FInputActionKeyMapping_bCtrl_GET(NativePointer);
			set => E_PROP_FInputActionKeyMapping_bCtrl_SET(NativePointer, value);
		}

		
		/// <summary>
		/// true if one of the Shift keys must be down when the KeyEvent is received to be acknowledged
		/// </summary>
		public byte bShift
		{
			get => E_PROP_FInputActionKeyMapping_bShift_GET(NativePointer);
			set => E_PROP_FInputActionKeyMapping_bShift_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInputActionKeyMapping self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FInputActionKeyMapping(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FInputActionKeyMapping(adress, false);
		}}}
