using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageMeshComponent
	/// <para>MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles. </para>
	/// <para>@see UStaticMeshComponent </para>
	/// <para>@see USkeletalMeshComponent </para>
	/// </summary>
	public  partial class UMeshComponent : UPrimitiveComponent
	{
		public UMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_CacheMaterialParameterNameIndices(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UMeshComponent_GetScalarParameterDefaultValue(IntPtr Self, string ParameterName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_SetScalarParameterValueOnMaterials(IntPtr Self, string ParameterName, float ParameterValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_SetVectorParameterValueOnMaterials(IntPtr Self, string ParameterName, IntPtr ParameterValue);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Retrieves all the (scalar/vector-)parameters from within the used materials on the SkeletalMesh, and stores material index vs parameter names </para>
		/// </summary>
		protected void CacheMaterialParameterNameIndices()
			=> E_UMeshComponent_CacheMaterialParameterNameIndices(this);
		
		
		/// <summary>
		/// <para>Returns default value for the parameter input. </para>
		/// <para>NOTE: This is not reliable when cooking, as initializing the default value </para>
		/// <para>requires a render resource that only exists if the owning world is rendering. </para>
		/// </summary>
		public float GetScalarParameterDefaultValue(string ParameterName)
			=> E_UMeshComponent_GetScalarParameterDefaultValue(this, ParameterName);
		
		
		/// <summary>
		/// <para>Mark cache parameters map as dirty, cache will be rebuild once SetScalar/SetVector functions are called </para>
		/// </summary>
		protected void MarkCachedMaterialParameterNameIndicesDirty()
			=> E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(this);
		
		
		/// <summary>
		/// <para>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue </para>
		/// </summary>
		public void SetScalarParameterValueOnMaterials(string ParameterName, float ParameterValue)
			=> E_UMeshComponent_SetScalarParameterValueOnMaterials(this, ParameterName, ParameterValue);
		
		
		/// <summary>
		/// <para>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue </para>
		/// </summary>
		public void SetVectorParameterValueOnMaterials(string ParameterName, FVector ParameterValue)
			=> E_UMeshComponent_SetVectorParameterValueOnMaterials(this, ParameterName, ParameterValue);
		
		#endregion
		
		public static implicit operator IntPtr(UMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UMeshComponent ?? new UMeshComponent(Adress);
		}}}
