// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:109

namespace UnrealEngine
{
	[ManageType("ManageActor")]
	public partial class ManageActor : AActor
	{
		public ManageActor(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageActor self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageActor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageActor>(PtrDesc);
		}}}
