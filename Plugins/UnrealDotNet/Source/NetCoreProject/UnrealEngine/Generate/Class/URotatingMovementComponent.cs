using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public  partial class URotatingMovementComponent : UMovementComponent
	{
		public URotatingMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public URotatingMovementComponent(UObject Parent = null, string Name = "RotatingMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URotatingMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URotatingMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_URotatingMovementComponent_ComputeSlideVector(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_URotatingMovementComponent_ConstrainDirectionToPlane(IntPtr Self, IntPtr Direction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_URotatingMovementComponent_ConstrainLocationToPlane(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_URotatingMovementComponent_ConstrainNormalToPlane(IntPtr Self, IntPtr Normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_GetGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_GetMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_URotatingMovementComponent_GetPenetrationAdjustment(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_HandleImpact(IntPtr Self, IntPtr Hit, float TimeSlice, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsExceedingMaxSpeed(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsInWater(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_K2_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_K2_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_MoveUpdatedComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnTeleported(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_ResolvePenetrationImpl(IntPtr Self, IntPtr Adjustment, IntPtr Hit, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetPlaneConstraintAxisSetting(IntPtr Self, byte NewAxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetPlaneConstraintEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetPlaneConstraintFromVectors(IntPtr Self, IntPtr Forward, IntPtr Up);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetPlaneConstraintNormal(IntPtr Self, IntPtr PlaneNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetPlaneConstraintOrigin(IntPtr Self, IntPtr PlaneOrigin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetUpdatedComponent(IntPtr Self, IntPtr NewUpdatedComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_ShouldSkipUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_URotatingMovementComponent_SlideAlongSurface(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit, bool bHandleImpact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SnapUpdatedComponentToPlane(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_StopMovementImmediately(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_TwoWallAdjust(IntPtr Self, IntPtr Delta, IntPtr Hit, IntPtr OldHitNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_UpdateComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_UpdateTickRegistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_URotatingMovementComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_UpdateComponentToWorld(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_URotatingMovementComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_URotatingMovementComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_URotatingMovementComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URotatingMovementComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds force from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// </summary>
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
			=> E_URotatingMovementComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff);
		
		
		/// <summary>
		/// <para>Adds impulse from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_URotatingMovementComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Compute a vector to slide along a surface, given an attempted move, time, and normal. </para>
		/// <param name="Delta">Attempted move. </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal. </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// </summary>
		public override FVector ComputeSlideVector(FVector Delta, float Time, FVector Normal, FHitResult Hit)
			=> E_URotatingMovementComponent_ComputeSlideVector(this, Delta, Time, Normal, Hit);
		
		
		/// <summary>
		/// <para>Constrain a direction vector to the plane constraint, if enabled. </para>
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public override FVector ConstrainDirectionToPlane(FVector Direction)
			=> E_URotatingMovementComponent_ConstrainDirectionToPlane(this, Direction);
		
		
		/// <summary>
		/// <para>Constrain a position vector to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainLocationToPlane(FVector Location)
			=> E_URotatingMovementComponent_ConstrainLocationToPlane(this, Location);
		
		
		/// <summary>
		/// <para>Constrain a normal vector (of unit length) to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainNormalToPlane(FVector Normal)
			=> E_URotatingMovementComponent_ConstrainNormalToPlane(this, Normal);
		
		public override void Deactivate()
			=> E_URotatingMovementComponent_Deactivate(this);
		
		
		/// <summary>
		/// <return>gravity that affects this component </return>
		/// </summary>
		public override float GetGravityZ()
			=> E_URotatingMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// <return>Maximum speed of component in current movement mode. </return>
		/// </summary>
		public override float GetMaxSpeed()
			=> E_URotatingMovementComponent_GetMaxSpeed(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float GetMaxSpeedModifier()
			=> E_URotatingMovementComponent_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float GetModifiedMaxSpeed()
			=> E_URotatingMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Calculate a movement adjustment to try to move out of a penetration from a failed move. </para>
		/// <param name="Hit">the result of the failed move </param>
		/// <return>The adjustment to use after a failed move, or a zero vector if no attempt should be made. </return>
		/// </summary>
		public override FVector GetPenetrationAdjustment(FHitResult Hit)
			=> E_URotatingMovementComponent_GetPenetrationAdjustment(this, Hit);
		
		
		/// <summary>
		/// <para>Called for Blocking impact </para>
		/// <param name="Hit">Describes the collision. </param>
		/// <param name="TimeSlice">Time period for the simulation that produced this hit.  Useful for </param>
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// <para>be sure to handle that. </para>
		/// <param name="MoveDelta">Attempted move that resulted in the hit. </param>
		/// </summary>
		public override void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta)
			=> E_URotatingMovementComponent_HandleImpact(this, Hit, TimeSlice, MoveDelta);
		
		
		/// <summary>
		/// <para>Overridden to auto-register the updated component if it starts NULL, and we can find a root component on our owner. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_URotatingMovementComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance. </para>
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// <para>can cause the max speed to be violated. </para>
		/// </summary>
		public override bool IsExceedingMaxSpeed(float MaxSpeed)
			=> E_URotatingMovementComponent_IsExceedingMaxSpeed(this, MaxSpeed);
		
		
		/// <summary>
		/// <para>return true if it's in PhysicsVolume with water flag </para>
		/// </summary>
		public override bool IsInWater()
			=> E_URotatingMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float K2_GetMaxSpeedModifier()
			=> E_URotatingMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float K2_GetModifiedMaxSpeed()
			=> E_URotatingMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		protected override bool MoveUpdatedComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, ETeleportType Teleport)
			=> E_URotatingMovementComponent_MoveUpdatedComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Overridden to update component properties that should be updated while being edited. </para>
		/// </summary>
		public override void OnRegister()
			=> E_URotatingMovementComponent_OnRegister(this);
		
		
		/// <summary>
		/// <para>Called by owning Actor upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public override void OnTeleported()
			=> E_URotatingMovementComponent_OnTeleported(this);
		
		public override void PostLoad()
			=> E_URotatingMovementComponent_PostLoad(this);
		
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_URotatingMovementComponent_RegisterComponentTickFunctions(this, bRegister);
		
		protected override bool ResolvePenetrationImpl(FVector Adjustment, FHitResult Hit, FQuat NewRotation)
			=> E_URotatingMovementComponent_ResolvePenetrationImpl(this, Adjustment, Hit, NewRotation);
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public override void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
			=> E_URotatingMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)NewAxisSetting);
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_URotatingMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
			=> E_URotatingMovementComponent_SetPlaneConstraintFromVectors(this, Forward, Up);
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public override void SetPlaneConstraintNormal(FVector PlaneNormal)
			=> E_URotatingMovementComponent_SetPlaneConstraintNormal(this, PlaneNormal);
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintOrigin(FVector PlaneOrigin)
			=> E_URotatingMovementComponent_SetPlaneConstraintOrigin(this, PlaneOrigin);
		
		
		/// <summary>
		/// <para>Assign the component we move and update. </para>
		/// </summary>
		public override void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
			=> E_URotatingMovementComponent_SetUpdatedComponent(this, NewUpdatedComponent);
		
		
		/// <summary>
		/// <para>Possibly skip update if moved component is not rendered or can't move. </para>
		/// <param name="DeltaTime">todo this parameter is not used in the function. </param>
		/// <return>true if component movement update should be skipped </return>
		/// </summary>
		public override bool ShouldSkipUpdate(float DeltaTime)
			=> E_URotatingMovementComponent_ShouldSkipUpdate(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Slide smoothly along a surface, and slide away from multiple impacts using TwoWallAdjust if necessary. Calls HandleImpact for each surface hit, if requested. </para>
		/// <para>Uses SafeMoveUpdatedComponent() for movement, and ComputeSlideVector() to determine the slide direction. </para>
		/// <param name="Delta">Attempted movement vector. </param>
		/// <param name="Time">Percent of Delta to apply (between 0 and 1). Usually equal to the remaining time after a collision: (1.0 - Hit.Time). </param>
		/// <param name="Normal">Normal opposing movement, along which we will slide. </param>
		/// <param name="Hit">In] HitResult of the attempted move that resulted in the impact triggering the slide. [Out] HitResult of last attempted move. </param>
		/// <param name="bHandleImpact">Whether to call HandleImpact on each hit. </param>
		/// <return>The percentage of requested distance (Delta * Percent) actually applied (between 0 and 1). 0 if no movement occurred, non-zero if movement occurred. </return>
		/// </summary>
		public override float SlideAlongSurface(FVector Delta, float Time, FVector Normal, FHitResult Hit, bool bHandleImpact)
			=> E_URotatingMovementComponent_SlideAlongSurface(this, Delta, Time, Normal, Hit, bHandleImpact);
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public override void SnapUpdatedComponentToPlane()
			=> E_URotatingMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// <para>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration). </para>
		/// </summary>
		public override void StopMovementImmediately()
			=> E_URotatingMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// <para>Compute a movement direction when contacting two surfaces. </para>
		/// <param name="Delta">In] Amount of move attempted before impact. [Out] Computed adjustment based on impacts. </param>
		/// <param name="Hit">Impact from last attempted move </param>
		/// <param name="OldHitNormal">Normal of impact before last attempted move </param>
		/// <return>Result in Delta that is the direction to move when contacting two surfaces. </return>
		/// </summary>
		public override void TwoWallAdjust(FVector Delta, FHitResult Hit, FVector OldHitNormal)
			=> E_URotatingMovementComponent_TwoWallAdjust(this, Delta, Hit, OldHitNormal);
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public override void UpdateComponentVelocity()
			=> E_URotatingMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public override void UpdateTickRegistration()
			=> E_URotatingMovementComponent_UpdateTickRegistration(this);
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset)
			=> E_URotatingMovementComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_URotatingMovementComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_URotatingMovementComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_URotatingMovementComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_URotatingMovementComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_URotatingMovementComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void CreateRenderState_Concurrent()
			=> E_URotatingMovementComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_URotatingMovementComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent()
			=> E_URotatingMovementComponent_DestroyRenderState_Concurrent(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_URotatingMovementComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_URotatingMovementComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		public override bool HasValidPhysicsState()
			=> E_URotatingMovementComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_URotatingMovementComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_URotatingMovementComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is an editor-only object or not </para>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_URotatingMovementComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_URotatingMovementComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>override to supply actual logic </para>
		/// </summary>
		public override bool IsNavigationRelevant()
			=> E_URotatingMovementComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_URotatingMovementComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_URotatingMovementComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_URotatingMovementComponent_MarkAsEditorOnlySubobject(this);
		
		public override bool NeedsLoadForClient()
			=> E_URotatingMovementComponent_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_URotatingMovementComponent_NeedsLoadForEditorGame(this);
		
		public override bool NeedsLoadForServer()
			=> E_URotatingMovementComponent_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E_URotatingMovementComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_URotatingMovementComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_URotatingMovementComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E_URotatingMovementComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E_URotatingMovementComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public override void OnUnregister()
			=> E_URotatingMovementComponent_OnUnregister(this);
		
		public override void PostInitProperties()
			=> E_URotatingMovementComponent_PostInitProperties(this);
		
		public override void PostNetReceive()
			=> E_URotatingMovementComponent_PostNetReceive(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_URotatingMovementComponent_PostRename(this, OldOuter, OldName);
		
		public override void PreNetReceive()
			=> E_URotatingMovementComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_URotatingMovementComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_URotatingMovementComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_URotatingMovementComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_URotatingMovementComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E_URotatingMovementComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void SendRenderTransform_Concurrent()
			=> E_URotatingMovementComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_URotatingMovementComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_URotatingMovementComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_URotatingMovementComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_URotatingMovementComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_URotatingMovementComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		public override bool ShouldCreatePhysicsState()
			=> E_URotatingMovementComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_URotatingMovementComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_URotatingMovementComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_URotatingMovementComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public override void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_URotatingMovementComponent_UpdateComponentToWorld(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_URotatingMovementComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_URotatingMovementComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_URotatingMovementComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_URotatingMovementComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_URotatingMovementComponent_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_URotatingMovementComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_URotatingMovementComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_URotatingMovementComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_URotatingMovementComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_URotatingMovementComponent_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_URotatingMovementComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_URotatingMovementComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_URotatingMovementComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_URotatingMovementComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_URotatingMovementComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_URotatingMovementComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_URotatingMovementComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_URotatingMovementComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_URotatingMovementComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_URotatingMovementComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_URotatingMovementComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_URotatingMovementComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_URotatingMovementComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_URotatingMovementComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(URotatingMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator URotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URotatingMovementComponent>(PtrDesc);
		}}}
