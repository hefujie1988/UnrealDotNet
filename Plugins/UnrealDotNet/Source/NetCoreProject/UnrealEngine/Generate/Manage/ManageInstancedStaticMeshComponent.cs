using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageInstancedStaticMeshComponent : UInstancedStaticMeshComponent
	{
		public ManageInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInstancedStaticMeshComponent>(PtrDesc);
		}