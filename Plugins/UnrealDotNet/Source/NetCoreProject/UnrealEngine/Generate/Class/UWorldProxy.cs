using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Proxy class that allows verification on GWorld accesses.
	/// </summary>
	public partial class UWorldProxy
	{
		protected readonly IntPtr NativePointer;
		
		public UWorldProxy(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		public static implicit operator IntPtr(UWorldProxy Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWorldProxy(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UWorldProxy(Adress);
		}