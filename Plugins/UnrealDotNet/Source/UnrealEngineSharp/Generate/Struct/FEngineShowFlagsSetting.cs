// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:30

namespace UnrealEngine
{
	public  partial class FEngineShowFlagsSetting : NativeStructWrapper
	{
		internal FEngineShowFlagsSetting(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FEngineShowFlagsSetting() :
			base(E_CreateStruct_FEngineShowFlagsSetting(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FEngineShowFlagsSetting_Enabled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEngineShowFlagsSetting_Enabled_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEngineShowFlagsSetting();
		
		#endregion
		
		#region Property
		public bool Enabled
		{
			get => E_PROP_FEngineShowFlagsSetting_Enabled_GET(NativePointer);
			set => E_PROP_FEngineShowFlagsSetting_Enabled_SET(NativePointer, value);
		}

		public string ShowFlagName
		{
			get => E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(NativePointer);
			set => E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEngineShowFlagsSetting self)
		{
			return self.NativePointer;
		}

		public static implicit operator FEngineShowFlagsSetting(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FEngineShowFlagsSetting(Adress, false);
		}}}
