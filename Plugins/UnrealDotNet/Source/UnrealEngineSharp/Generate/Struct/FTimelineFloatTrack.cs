// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:113

namespace UnrealEngine
{
	public partial class FTimelineFloatTrack : NativeStructWrapper
	{
		public FTimelineFloatTrack(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTimelineFloatTrack() :
			base(E_CreateStruct_FTimelineFloatTrack(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineFloatTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineFloatTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineFloatTrack();
		
		#endregion
		
		#region Property
		public string FloatPropertyName
		{
			get => E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(NativePointer);
			set => E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(NativePointer, value);
		}

		public string TrackName
		{
			get => E_PROP_FTimelineFloatTrack_TrackName_GET(NativePointer);
			set => E_PROP_FTimelineFloatTrack_TrackName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineFloatTrack self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTimelineFloatTrack(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTimelineFloatTrack(adress, false);
		}}}
