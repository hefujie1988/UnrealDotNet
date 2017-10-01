using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USphereComponent : UShapeComponent
	{
		public USphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USphereComponent(UObject Parent = null, string Name = "SphereComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USphereComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USphereComponent_SphereRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USphereComponent_SphereRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetScaledSphereRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetShapeScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetUnscaledSphereRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USphereComponent_InitSphereRadius(IntPtr Self, float InSphereRadius);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USphereComponent_SetSphereRadius(IntPtr Self, float InSphereRadius, bool bUpdateOverlaps);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The radius of the sphere </para>
		/// </summary>
		protected float SphereRadius
		{
			get => E_PROP_USphereComponent_SphereRadius_GET(NativePointer);
			set => E_PROP_USphereComponent_SphereRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetScaledSphereRadius()
			=> E_USphereComponent_GetScaledSphereRadius(this);
		
		public float GetShapeScale()
			=> E_USphereComponent_GetShapeScale(this);
		
		public float GetUnscaledSphereRadius()
			=> E_USphereComponent_GetUnscaledSphereRadius(this);
		
		public void InitSphereRadius(float InSphereRadius)
			=> E_USphereComponent_InitSphereRadius(this, InSphereRadius);
		
		
		/// <summary>
		/// <para>Change the sphere radius. This is the unscaled radius, before component scale is applied. </para>
		/// <param name="InSphereRadius">the new sphere radius </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
			=> E_USphereComponent_SetSphereRadius(this, InSphereRadius, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(USphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USphereComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USphereComponent>(PtrDesc);
		}}}
