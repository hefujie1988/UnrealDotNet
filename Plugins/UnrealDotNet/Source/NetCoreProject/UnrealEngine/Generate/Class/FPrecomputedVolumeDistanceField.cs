using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Volume distance field generated by Lightmass, used by image based reflections for shadowing.
	/// </summary>
	public partial class FPrecomputedVolumeDistanceField
	{
		protected readonly IntPtr NativePointer;
		
		public FPrecomputedVolumeDistanceField(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		public static implicit operator IntPtr(FPrecomputedVolumeDistanceField Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrecomputedVolumeDistanceField(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrecomputedVolumeDistanceField(Adress);
		}