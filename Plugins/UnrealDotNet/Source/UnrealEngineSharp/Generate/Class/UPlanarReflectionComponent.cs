// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PlanarReflectionComponent.h:16

namespace UnrealEngine
{
	public  partial class UPlanarReflectionComponent : USceneCaptureComponent
	{
		public UPlanarReflectionComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPlanarReflectionComponent(UObject Parent = null, string Name = "PlanarReflectionComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlanarReflectionComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UPlanarReflectionComponent_bShowPreviewPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_bShowPreviewPlane_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_ExtraFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_ExtraFOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_PrefilterRoughness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_PrefilterRoughness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPlanarReflectionComponent_ScreenPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlanarReflectionComponent_ScreenPercentage_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlanarReflectionComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPlanarReflectionComponent_GetPlanarReflectionId(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Receiving pixels whose normal is at this angle from the reflection plane will have completely faded out the planar reflection. </para>
		/// </summary>
		public float AngleFromPlaneFadeEnd
		{
			get => E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeEnd_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Receiving pixels whose normal is at this angle from the reflection plane will begin to fade out the planar reflection. </para>
		/// </summary>
		public float AngleFromPlaneFadeStart
		{
			get => E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_AngleFromPlaneFadeStart_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to render the scene as two-sided, which can be useful to hide artifacts where normal distortion would read 'under' an object that has been clipped by the reflection plane. </para>
		/// <para>With this setting enabled, the backfaces of a mesh would be displayed in the clipped region instead of the background which is potentially a bright sky. </para>
		/// <para>Be sure to add the water plane to HiddenActors if enabling this, as the water plane will now block the reflection. </para>
		/// </summary>
		public bool bRenderSceneTwoSided
		{
			get => E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_bRenderSceneTwoSided_SET(NativePointer, value);
		}

		public bool bShowPreviewPlane
		{
			get => E_PROP_UPlanarReflectionComponent_bShowPreviewPlane_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_bShowPreviewPlane_SET(NativePointer, value);
		}

		public float DistanceFromPlaneFadeEnd_DEPRECATED
		{
			get => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeEnd_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Receiving pixels at this distance from the reflection plane will have completely faded out the planar reflection. </para>
		/// </summary>
		public float DistanceFromPlaneFadeoutEnd
		{
			get => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutEnd_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Receiving pixels at this distance from the reflection plane will begin to fade out the planar reflection. </para>
		/// </summary>
		public float DistanceFromPlaneFadeoutStart
		{
			get => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeoutStart_SET(NativePointer, value);
		}

		public float DistanceFromPlaneFadeStart_DEPRECATED
		{
			get => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_DistanceFromPlaneFadeStart_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Additional FOV used when rendering to the reflection texture. </para>
		/// <para>This is useful when normal distortion is causing reads outside the reflection texture. </para>
		/// <para>Larger values increase rendering thread and GPU cost, as more objects and triangles have to be rendered into the planar reflection. </para>
		/// </summary>
		public float ExtraFOV
		{
			get => E_PROP_UPlanarReflectionComponent_ExtraFOV_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_ExtraFOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the strength of normals when distorting the planar reflection. </para>
		/// </summary>
		public float NormalDistortionStrength
		{
			get => E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_NormalDistortionStrength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The roughness value to prefilter the planar reflection texture with, useful for hiding low resolution.  Larger values have larger GPU cost. </para>
		/// </summary>
		public float PrefilterRoughness
		{
			get => E_PROP_UPlanarReflectionComponent_PrefilterRoughness_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_PrefilterRoughness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance at which the prefilter roughness value will be achieved. </para>
		/// </summary>
		public float PrefilterRoughnessDistance
		{
			get => E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_PrefilterRoughnessDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Downsample percent, can be used to reduce GPU time rendering the planar reflection. </para>
		/// </summary>
		public int ScreenPercentage
		{
			get => E_PROP_UPlanarReflectionComponent_ScreenPercentage_GET(NativePointer);
			set => E_PROP_UPlanarReflectionComponent_ScreenPercentage_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public int GetPlanarReflectionId()
			=> E_UPlanarReflectionComponent_GetPlanarReflectionId(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPlanarReflectionComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPlanarReflectionComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlanarReflectionComponent>(PtrDesc);
		}}}
