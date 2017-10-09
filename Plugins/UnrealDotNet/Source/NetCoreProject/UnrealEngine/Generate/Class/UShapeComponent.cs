using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:24

namespace UnrealEngine
{
	public  partial class UShapeComponent : UPrimitiveComponent
	{
		public UShapeComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UShapeComponent(UObject Parent = null, string Name = "ShapeComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UShapeComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UShapeComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UShapeComponent_UpdateBodySetup(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Update the body setup parameters based on shape information </para>
		/// </summary>
		public virtual void UpdateBodySetup()
			=> E_UShapeComponent_UpdateBodySetup(this);
		
		#endregion
		
		public static implicit operator IntPtr(UShapeComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UShapeComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UShapeComponent>(PtrDesc);
		}}}
