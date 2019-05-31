// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	[ManageType("ManageProjectileMovementComponent")]
	public partial class ManageProjectileMovementComponent : UProjectileMovementComponent
	{
		public ManageProjectileMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageProjectileMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageProjectileMovementComponent>(PtrDesc);
		}}}
