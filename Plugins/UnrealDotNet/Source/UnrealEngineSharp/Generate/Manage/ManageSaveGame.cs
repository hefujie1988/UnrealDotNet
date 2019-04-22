// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SaveGame.h:19

namespace UnrealEngine
{
	[ManageType("ManageSaveGame")]
	public partial class ManageSaveGame : USaveGame
	{
		public ManageSaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSaveGame self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSaveGame(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSaveGame>(PtrDesc);
		}}}
