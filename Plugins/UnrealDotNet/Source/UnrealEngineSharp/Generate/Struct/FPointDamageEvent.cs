// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2615

namespace UnrealEngine
{
	public partial class FPointDamageEvent : FDamageEvent
	{
		public FPointDamageEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPointDamageEvent() :
			base(E_CreateStruct_FPointDamageEvent(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPointDamageEvent_ClassID_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPointDamageEvent_Damage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_Damage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPointDamageEvent_HitInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_HitInfo_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPointDamageEvent_ShotDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPointDamageEvent_ShotDirection_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPointDamageEvent();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// ID for this class. NOTE this must be unique for all damage events.
		/// </summary>
		public static int ClassID
		{
			get => E_PROP_FPointDamageEvent_ClassID_GET();
		}

		public float Damage
		{
			get => E_PROP_FPointDamageEvent_Damage_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_Damage_SET(NativePointer, value);
		}

		public FHitResult HitInfo
		{
			get => E_PROP_FPointDamageEvent_HitInfo_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_HitInfo_SET(NativePointer, value);
		}

		public FVector_NetQuantizeNormal ShotDirection
		{
			get => E_PROP_FPointDamageEvent_ShotDirection_GET(NativePointer);
			set => E_PROP_FPointDamageEvent_ShotDirection_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPointDamageEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPointDamageEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPointDamageEvent(adress, false);
		}}}
