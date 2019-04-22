// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\QuatRotationTranslationMatrix.h:33

namespace UnrealEngine
{
	public  partial class FQuatRotationMatrix : FQuatRotationTranslationMatrix
	{
		internal FQuatRotationMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="Q">rotation </param>
		/// </summary>
		public FQuatRotationMatrix(FQuat q) :
			base(E_CreateStruct_FQuatRotationMatrix_FQuat(q), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuatRotationMatrix_FQuat(IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuatRotationMatrix_Make(IntPtr self, IntPtr q);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions. </para>
		/// </summary>
		public FMatrix Make(FQuat q)
			=> E_FQuatRotationMatrix_Make(this, q);
		
		#endregion
		
		public static implicit operator IntPtr(FQuatRotationMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FQuatRotationMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuatRotationMatrix(Adress, false);
		}}}
