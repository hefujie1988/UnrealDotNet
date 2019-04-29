// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:47

namespace UnrealEngine
{
	[ManageType("ManageExponentialHeightFogComponent")]
	public partial class ManageExponentialHeightFogComponent : UExponentialHeightFogComponent
	{
		public ManageExponentialHeightFogComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageExponentialHeightFogComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageExponentialHeightFogComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageExponentialHeightFogComponent>(PtrDesc);
		}}}
