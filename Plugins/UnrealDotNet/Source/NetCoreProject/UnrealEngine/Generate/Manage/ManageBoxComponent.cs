using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\BoxComponent.h:17

namespace UnrealEngine
{
	public partial class ManageBoxComponent : UBoxComponent
	{
		public ManageBoxComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageBoxComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageBoxComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageBoxComponent>(PtrDesc);
		}}}
