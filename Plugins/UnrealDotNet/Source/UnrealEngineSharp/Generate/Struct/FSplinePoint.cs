// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SplineComponent.h:113

namespace UnrealEngine
{
	public partial class FSplinePoint : NativeStructWrapper
	{
		public FSplinePoint(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor
		/// </summary>
		public FSplinePoint() :
			base(E_CreateStruct_FSplinePoint(), false)
		{
		}

		
		/// <summary>
		/// Constructor taking a point position
		/// </summary>
		public FSplinePoint(float inInputKey, FVector inPosition) :
			base(E_CreateStruct_FSplinePoint_float_FVector(inInputKey, inPosition), false)
		{
		}

		
		/// <summary>
		/// Constructor taking a point position and tangent, and optionally rotation and scale
		/// </summary>
		public FSplinePoint(float inInputKey, FVector inPosition, FVector inArriveTangent, FVector inLeaveTangent, FRotator inRotation, FVector inScale) :
			base(E_CreateStruct_FSplinePoint_float_FVector_FVector_FVector_FRotator_FVector(inInputKey, inPosition, inArriveTangent, inLeaveTangent, inRotation, inScale), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_ArriveTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_ArriveTangent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSplinePoint_InputKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_InputKey_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_LeaveTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_LeaveTangent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Position_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Scale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Scale_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint_float_FVector(float inInputKey, IntPtr inPosition);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint_float_FVector_FVector_FVector_FRotator_FVector(float inInputKey, IntPtr inPosition, IntPtr inArriveTangent, IntPtr inLeaveTangent, IntPtr inRotation, IntPtr inScale);
		
		#endregion
		
		#region Property
		public FVector ArriveTangent
		{
			get => E_PROP_FSplinePoint_ArriveTangent_GET(NativePointer);
			set => E_PROP_FSplinePoint_ArriveTangent_SET(NativePointer, value);
		}

		public float InputKey
		{
			get => E_PROP_FSplinePoint_InputKey_GET(NativePointer);
			set => E_PROP_FSplinePoint_InputKey_SET(NativePointer, value);
		}

		public FVector LeaveTangent
		{
			get => E_PROP_FSplinePoint_LeaveTangent_GET(NativePointer);
			set => E_PROP_FSplinePoint_LeaveTangent_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FSplinePoint_Position_GET(NativePointer);
			set => E_PROP_FSplinePoint_Position_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FSplinePoint_Rotation_GET(NativePointer);
			set => E_PROP_FSplinePoint_Rotation_SET(NativePointer, value);
		}

		public FVector Scale
		{
			get => E_PROP_FSplinePoint_Scale_GET(NativePointer);
			set => E_PROP_FSplinePoint_Scale_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSplinePoint self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSplinePoint(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSplinePoint(adress, false);
		}}}
