// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:37

namespace UnrealEngine
{
	public  partial class FRepRootMotionMontage : NativeStructWrapper
	{
		internal FRepRootMotionMontage(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepRootMotionMontage() :
			base(E_CreateStruct_FRepRootMotionMontage(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepRootMotionMontage_AuthoritativeRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_AuthoritativeRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bIsActive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bIsActive_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bRelativePosition_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FRepRootMotionMontage_MovementBase_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_MovementBase_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRepRootMotionMontage_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_Position_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepRootMotionMontage_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepRootMotionMontage();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepRootMotionMontage_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRepRootMotionMontage_HasRootMotion(IntPtr self);
		
		#endregion
		
		#region Property
		public FRootMotionSourceGroup AuthoritativeRootMotion
		{
			get => E_PROP_FRepRootMotionMontage_AuthoritativeRootMotion_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_AuthoritativeRootMotion_SET(NativePointer, value);
		}

		public bool bIsActive
		{
			get => E_PROP_FRepRootMotionMontage_bIsActive_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bIsActive_SET(NativePointer, value);
		}

		public bool bRelativePosition
		{
			get => E_PROP_FRepRootMotionMontage_bRelativePosition_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bRelativePosition_SET(NativePointer, value);
		}

		public bool bRelativeRotation
		{
			get => E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(NativePointer, value);
		}

		public UPrimitiveComponent MovementBase
		{
			get => E_PROP_FRepRootMotionMontage_MovementBase_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_MovementBase_SET(NativePointer, value);
		}

		public string MovementBaseBoneName
		{
			get => E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(NativePointer, value);
		}

		public float Position
		{
			get => E_PROP_FRepRootMotionMontage_Position_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_Position_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FRepRootMotionMontage_Rotation_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Clear root motion sources and root motion montage
		/// </summary>
		public void Clear()
			=> E_FRepRootMotionMontage_Clear(this);
		
		
		/// <summary>
		/// Is Valid - animation root motion only
		/// </summary>
		public bool HasRootMotion()
			=> E_FRepRootMotionMontage_HasRootMotion(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRepRootMotionMontage self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRepRootMotionMontage(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepRootMotionMontage(Adress, false);
		}}}
