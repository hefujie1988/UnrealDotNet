using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Actor is the base class for an Object that can be placed or spawned in a level.
	/// Actors may contain a collection of ActorComponents, which can be used to control how actors move, how they are rendered, etc.
	/// The other main function of an Actor is the replication of properties and function calls across the network during play.
	/// @see https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors
	/// @see UActorComponent
	/// </summary>
	public partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_CustomTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_CustomTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bHidden_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bHidden_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bNetTemporary_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bNetTemporary_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bNetStartup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bNetStartup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bOnlyRelevantToOwner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bOnlyRelevantToOwner_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bAlwaysRelevant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bAlwaysRelevant_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bReplicateMovement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bReplicateMovement_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bTearOff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bTearOff_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bExchangedRoles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bExchangedRoles_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bPendingNetUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bPendingNetUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bNetLoadOnClient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bNetLoadOnClient_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bNetUseOwnerRelevancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bNetUseOwnerRelevancy_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bBlockInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bBlockInput_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bRunningUserConstructionScript_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bRunningUserConstructionScript_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bReplicates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bReplicates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_AActor_NetDriverName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetDriverName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_AActor_InputPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_InputPriority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_NetCullDistanceSquared_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetCullDistanceSquared_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_AActor_NetTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetTag_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_NetUpdateTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetUpdateTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_NetUpdateFrequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetUpdateFrequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_MinNetUpdateFrequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_MinNetUpdateFrequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_NetPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_NetPriority_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_LastNetUpdateTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_LastNetUpdateTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bAutoDestroyWhenFinished_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bAutoDestroyWhenFinished_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bCanBeDamaged_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bCanBeDamaged_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bCollideWhenPlacing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bCollideWhenPlacing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bRelevantForNetworkReplays_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bRelevantForNetworkReplays_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bCanBeInCluster_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bCanBeInCluster_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_CreationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_CreationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern APawn E_PROP_AActor_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_Instigator_SET(IntPtr Ptr, APawn Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern USceneComponent E_PROP_AActor_RootComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_RootComponent_SET(IntPtr Ptr, USceneComponent Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AActor_InitialLifeSpan_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_InitialLifeSpan_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bActorSeamlessTraveled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bActorSeamlessTraveled_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bIgnoresOriginShifting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bIgnoresOriginShifting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_AActor_bEnableAutoLODGeneration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AActor_bEnableAutoLODGeneration_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_OnRep_ReplicateMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_HasNetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SetReplicates(IntPtr Self, bool bInReplicates);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_CopyRemoteRoleFrom(IntPtr Self, IntPtr CopyFromActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SetNetDriverName(IntPtr Self, string NewNetDriverName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetNetDriverName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_OnSubobjectCreatedFromReplication(IntPtr Self, IntPtr NewSubobject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_AActor_GetInputAxisValue(IntPtr Self, string InputAxisName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_K2_GetActorLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_K2_GetActorRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, IntPtr Origin, IntPtr BoxExtent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_K2_GetRootComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_K2_SetActorRotation(IntPtr Self, IntPtr NewRotation, bool bTeleportPhysics);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SetActorScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_AActor_GetDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_AddComponent(IntPtr Self, string TemplateName, bool bManualAttachment, IntPtr RelativeTransform, IntPtr ComponentTemplateContext);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_K2_DestroyComponent(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SnapRootComponentTo(IntPtr Self, IntPtr InParentActor, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_DetachSceneComponentsFromParent(IntPtr Self, IntPtr InParentComponent, bool bMaintainWorldPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_ActorHasTag(IntPtr Self, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_AActor_GetActorTimeDilation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_SetTickPrerequisite(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_GetTickableWhenPaused(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_AActor_GetGameTimeSinceCreation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_MakeNoise(IntPtr Self, float Loudness, IntPtr NoiseInstigator, IntPtr NoiseLocation, float MaxRange, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_Destroy(IntPtr Self, bool bNetForce, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_IsOwnedBy(IntPtr Self, IntPtr TestOwner);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetRootPrimitiveComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_SetRootComponent(IntPtr Self, IntPtr NewRootComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetActorQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_PostNetReceiveVelocity(IntPtr Self, IntPtr NewVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_IsReplayRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation, float CullDistanceSquared);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_IsRelevancyOwnerFor(IntPtr Self, IntPtr ReplicatedActor, IntPtr ActorOwner, IntPtr ConnectionActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_PostSpawnInitialize(IntPtr Self, IntPtr SpawnTransform, IntPtr InOwner, IntPtr InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetNetOwningPlayer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetParentComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation, bool bIsATest, bool bNoCheck);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_K2_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AActor_IsInLevel(IntPtr Self, IntPtr TestLevel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AActor_GetLevel(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_DebugShowOneComponentHierarchy(IntPtr Self, IntPtr SceneComp, int NestLevel, bool bShowPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AActor_OnConstruction(IntPtr Self, IntPtr Transform);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.
		/// </summary>
		public float CustomTimeDilation
		{
			get => E_PROP_AActor_CustomTimeDilation_GET(NativePointer);
			set => E_PROP_AActor_CustomTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows us to only see this Actor in the Editor, and not in the actual game.
		/// @see SetActorHiddenInGame()
		/// </summary>
		public byte ActorHiddenInGame
		{
			get => E_PROP_AActor_bHidden_GET(NativePointer);
			set => E_PROP_AActor_bHidden_SET(NativePointer, value);
		}

		public byte bNetTemporary
		{
			get => E_PROP_AActor_bNetTemporary_GET(NativePointer);
			set => E_PROP_AActor_bNetTemporary_SET(NativePointer, value);
		}

		public byte bNetStartup
		{
			get => E_PROP_AActor_bNetStartup_GET(NativePointer);
			set => E_PROP_AActor_bNetStartup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed.
		/// </summary>
		public byte bOnlyRelevantToOwner
		{
			get => E_PROP_AActor_bOnlyRelevantToOwner_GET(NativePointer);
			set => E_PROP_AActor_bOnlyRelevantToOwner_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Always relevant for network (overrides bOnlyRelevantToOwner).
		/// </summary>
		public byte bAlwaysRelevant
		{
			get => E_PROP_AActor_bAlwaysRelevant_GET(NativePointer);
			set => E_PROP_AActor_bAlwaysRelevant_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, replicate movement/location related properties.
		/// Actor must also be set to replicate.
		/// @see SetReplicates()
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication
		/// </summary>
		public byte bReplicateMovement
		{
			get => E_PROP_AActor_bReplicateMovement_GET(NativePointer);
			set => E_PROP_AActor_bReplicateMovement_SET(NativePointer, value);
		}

		public byte bTearOff
		{
			get => E_PROP_AActor_bTearOff_GET(NativePointer);
			set => E_PROP_AActor_bTearOff_SET(NativePointer, value);
		}

		public byte bExchangedRoles
		{
			get => E_PROP_AActor_bExchangedRoles_GET(NativePointer);
			set => E_PROP_AActor_bExchangedRoles_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is this actor still pending a full net update due to clients that weren't able to replicate the actor at the time of LastNetUpdateTime
		/// </summary>
		public byte bPendingNetUpdate
		{
			get => E_PROP_AActor_bPendingNetUpdate_GET(NativePointer);
			set => E_PROP_AActor_bPendingNetUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// This actor will be loaded on network clients during map load
		/// </summary>
		public byte bNetLoadOnClient
		{
			get => E_PROP_AActor_bNetLoadOnClient_GET(NativePointer);
			set => E_PROP_AActor_bNetLoadOnClient_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If actor has valid Owner, call Owner's IsNetRelevantFor and GetNetPriority
		/// </summary>
		public byte bNetUseOwnerRelevancy
		{
			get => E_PROP_AActor_bNetUseOwnerRelevancy_GET(NativePointer);
			set => E_PROP_AActor_bNetUseOwnerRelevancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, all input on the stack below this actor will not be considered
		/// </summary>
		public byte bBlockInput
		{
			get => E_PROP_AActor_bBlockInput_GET(NativePointer);
			set => E_PROP_AActor_bBlockInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if this actor is currently running user construction script (used to defer component registration)
		/// </summary>
		public byte bRunningUserConstructionScript
		{
			get => E_PROP_AActor_bRunningUserConstructionScript_GET(NativePointer);
			set => E_PROP_AActor_bRunningUserConstructionScript_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we allow this Actor to tick before it receives the BeginPlay event.
		/// Normally we don't tick actors until after BeginPlay; this setting allows this behavior to be overridden.
		/// This Actor must be able to tick for this setting to be relevant.
		/// </summary>
		public byte bAllowTickBeforeBeginPlay
		{
			get => E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(NativePointer);
			set => E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this actor will replicate to remote machines
		/// @see SetReplicates()
		/// </summary>
		protected byte bReplicates
		{
			get => E_PROP_AActor_bReplicates_GET(NativePointer);
			set => E_PROP_AActor_bReplicates_SET(NativePointer, value);
		}

		protected string NetDriverName
		{
			get => E_PROP_AActor_NetDriverName_GET(NativePointer);
			set => E_PROP_AActor_NetDriverName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The priority of this input component when pushed in to the stack.
		/// </summary>
		public int InputPriority
		{
			get => E_PROP_AActor_InputPriority_GET(NativePointer);
			set => E_PROP_AActor_InputPriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated.
		/// </summary>
		public float NetCullDistanceSquared
		{
			get => E_PROP_AActor_NetCullDistanceSquared_GET(NativePointer);
			set => E_PROP_AActor_NetCullDistanceSquared_SET(NativePointer, value);
		}

		public int NetTag
		{
			get => E_PROP_AActor_NetTag_GET(NativePointer);
			set => E_PROP_AActor_NetTag_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Next time this actor will be considered for replication, set by SetNetUpdateTime()
		/// </summary>
		public float NetUpdateTime
		{
			get => E_PROP_AActor_NetUpdateTime_GET(NativePointer);
			set => E_PROP_AActor_NetUpdateTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How often (per second) this actor will be considered for replication, used to determine NetUpdateTime
		/// </summary>
		public float NetUpdateFrequency
		{
			get => E_PROP_AActor_NetUpdateFrequency_GET(NativePointer);
			set => E_PROP_AActor_NetUpdateFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Used to determine what rate to throttle down to when replicated properties are changing infrequently
		/// </summary>
		public float MinNetUpdateFrequency
		{
			get => E_PROP_AActor_MinNetUpdateFrequency_GET(NativePointer);
			set => E_PROP_AActor_MinNetUpdateFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate
		/// </summary>
		public float NetPriority
		{
			get => E_PROP_AActor_NetPriority_GET(NativePointer);
			set => E_PROP_AActor_NetPriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Last time this actor was updated for replication via NetUpdateTime
		/// @warning: internal net driver time, not related to WorldSettings.TimeSeconds
		/// </summary>
		public float LastNetUpdateTime
		{
			get => E_PROP_AActor_LastNetUpdateTime_GET(NativePointer);
			set => E_PROP_AActor_LastNetUpdateTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true then destroy self when "finished", meaning all relevant components report that they are done and no timelines or timers are in flight.
		/// </summary>
		public byte bAutoDestroyWhenFinished
		{
			get => E_PROP_AActor_bAutoDestroyWhenFinished_GET(NativePointer);
			set => E_PROP_AActor_bAutoDestroyWhenFinished_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called.
		/// @see https://www.unrealengine.com/blog/damage-in-ue4
		/// @see TakeDamage(), ReceiveDamage()
		/// </summary>
		public byte bCanBeDamaged
		{
			get => E_PROP_AActor_bCanBeDamaged_GET(NativePointer);
			set => E_PROP_AActor_bCanBeDamaged_SET(NativePointer, value);
		}

		public byte bCollideWhenPlacing
		{
			get => E_PROP_AActor_bCollideWhenPlacing_GET(NativePointer);
			set => E_PROP_AActor_bCollideWhenPlacing_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this actor should search for an owned camera component to view through when used as a view target.
		/// </summary>
		public byte bFindCameraComponentWhenViewTarget
		{
			get => E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(NativePointer);
			set => E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(NativePointer, value);
		}

		public byte bRelevantForNetworkReplays
		{
			get => E_PROP_AActor_bRelevantForNetworkReplays_GET(NativePointer);
			set => E_PROP_AActor_bRelevantForNetworkReplays_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this actor will generate overlap events when spawned as part of level streaming. You might enable this is in the case where a streaming level loads around an actor and you want overlaps to trigger.
		/// </summary>
		public byte bGenerateOverlapEventsDuringLevelStreaming
		{
			get => E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(NativePointer);
			set => E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this actor can be put inside of a GC Cluster to improve Garbage Collection performance
		/// </summary>
		protected byte bCanBeInCluster
		{
			get => E_PROP_AActor_bCanBeInCluster_GET(NativePointer);
			set => E_PROP_AActor_bCanBeInCluster_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The time this actor was created, relative to World->GetTimeSeconds().
		/// @see UWorld::GetTimeSeconds()
		/// </summary>
		public float CreationTime
		{
			get => E_PROP_AActor_CreationTime_GET(NativePointer);
			set => E_PROP_AActor_CreationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Pawn responsible for damage caused by this actor.
		/// </summary>
		public APawn Instigator
		{
			get => E_PROP_AActor_Instigator_GET(NativePointer);
			set => E_PROP_AActor_Instigator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Collision primitive that defines the transform (location, rotation, scale) of this Actor.
		/// </summary>
		protected USceneComponent RootComponent
		{
			get => E_PROP_AActor_RootComponent_GET(NativePointer);
			set => E_PROP_AActor_RootComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun.
		/// </summary>
		protected float InitialLifeSpan
		{
			get => E_PROP_AActor_InitialLifeSpan_GET(NativePointer);
			set => E_PROP_AActor_InitialLifeSpan_SET(NativePointer, value);
		}

		protected byte bAllowReceiveTickEventOnDedicatedServer
		{
			get => E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_GET(NativePointer);
			set => E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_SET(NativePointer, value);
		}

		public byte bActorSeamlessTraveled
		{
			get => E_PROP_AActor_bActorSeamlessTraveled_GET(NativePointer);
			set => E_PROP_AActor_bActorSeamlessTraveled_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this actor should not be affected by world origin shifting.
		/// </summary>
		public byte bIgnoresOriginShifting
		{
			get => E_PROP_AActor_bIgnoresOriginShifting_GET(NativePointer);
			set => E_PROP_AActor_bIgnoresOriginShifting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, and if World setting has bEnableHierarchicalLOD equal to true, then it will generate LODActor from groups of clustered Actor
		/// </summary>
		public byte bEnableAutoLODGeneration
		{
			get => E_PROP_AActor_bEnableAutoLODGeneration_GET(NativePointer);
			set => E_PROP_AActor_bEnableAutoLODGeneration_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void OnRep_ReplicateMovement()
			=> E_AActor_OnRep_ReplicateMovement(NativePointer);
		
		
		/// <summary>
		/// Does this actor have an owner responsible for replication? (APlayerController typically)
		/// @return true if this actor can call RPCs or false if no such owner chain exists
		/// </summary>
		protected bool HasNetOwner()
			=> E_AActor_HasNetOwner(NativePointer);
		
		
		/// <summary>
		/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
		/// Properties flagged for replication will update on clients if they change on the server.
		/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
		/// @param bInReplicates Whether this Actor replicates to network clients.
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication
		/// </summary>
		public void SetReplicates(bool bInReplicates)
			=> E_AActor_SetReplicates(NativePointer, bInReplicates);
		
		
		/// <summary>
		/// Sets whether or not this Actor is an autonomous proxy, which is an actor on a network client that is controlled by a user on that client.
		/// </summary>
		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare = true)
			=> E_AActor_SetAutonomousProxy(NativePointer, bInAutonomousProxy, bAllowForcePropertyCompare);
		
		
		/// <summary>
		/// Copies RemoteRole from another Actor and adds this actor to the list of network actors if necessary.
		/// </summary>
		public void CopyRemoteRoleFrom(AActor CopyFromActor)
			=> E_AActor_CopyRemoteRoleFrom(NativePointer, CopyFromActor);
		
		
		/// <summary>
		/// Set the name of the net driver associated with this actor.  Will move the actor out of the list of network actors from the old net driver and add it to the new list
		/// @param NewNetDriverName name of the new net driver association
		/// </summary>
		public void SetNetDriverName(string NewNetDriverName)
			=> E_AActor_SetNetDriverName(NativePointer, NewNetDriverName);
		
		
		/// <summary>
		/// @return name of the net driver associated with this actor (all RPCs will go out via this connection)
		/// </summary>
		public string GetNetDriverName()
			=> Marshal.PtrToStringUTF8(E_AActor_GetNetDriverName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Called on the actor when a new subobject is dynamically created via replication
		/// </summary>
		public void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_AActor_OnSubobjectCreatedFromReplication(NativePointer, NewSubobject);
		
		
		/// <summary>
		/// Gets the value of the input axis if input is enabled for this actor.
		/// </summary>
		public float GetInputAxisValue(string InputAxisName)
			=> E_AActor_GetInputAxisValue(NativePointer, InputAxisName);
		
		
		/// <summary>
		/// Get the actor-to-world transform.
		/// @return The transform that transforms from actor space to world space.
		/// </summary>
		public FTransform GetActorTransform()
			=> E_AActor_GetTransform(NativePointer);
		
		
		/// <summary>
		/// Returns the location of the RootComponent of this Actor
		/// </summary>
		public FVector GetActorLocation()
			=> E_AActor_K2_GetActorLocation(NativePointer);
		
		
		/// <summary>
		/// Returns rotation of the RootComponent of this Actor.
		/// </summary>
		public FRotator GetActorRotation()
			=> E_AActor_K2_GetActorRotation(NativePointer);
		
		
		/// <summary>
		/// Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents).
		/// @param	bOnlyCollidingComponents	If true, will only return the bounding box for components with collision enabled.
		/// </summary>
		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
			=> E_AActor_GetActorBounds(NativePointer, bOnlyCollidingComponents, Origin, BoxExtent);
		
		public USceneComponent K2_GetRootComponent()
			=> E_AActor_K2_GetRootComponent(NativePointer);
		
		
		/// <summary>
		/// Set the Actor's rotation instantly to the specified rotation.
		/// @param	NewRotation	The new rotation for the Actor.
		/// @param	bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// @return	Whether the rotation was successfully set.
		/// </summary>
		public bool SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
			=> E_AActor_K2_SetActorRotation(NativePointer, NewRotation, bTeleportPhysics);
		
		
		/// <summary>
		/// Set the Actor's world-space scale.
		/// </summary>
		public void SetActorScale3D(FVector NewScale3D)
			=> E_AActor_SetActorScale3D(NativePointer, NewScale3D);
		
		
		/// <summary>
		/// Returns the distance from this Actor to OtherActor.
		/// </summary>
		public float GetDistanceTo(AActor OtherActor)
			=> E_AActor_GetDistanceTo(NativePointer, OtherActor);
		
		
		/// <summary>
		/// Creates a new component and assigns ownership to the Actor this is
		/// called for. Automatic attachment causes the first component created to
		/// become the root, and all subsequent components to be attached under that
		/// root. When bManualAttachment is set, automatic attachment is
		/// skipped and it is up to the user to attach the resulting component (or
		/// set it up as the root) themselves.
		/// @see UK2Node_AddComponent	DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
		/// @param TemplateName					The name of the Component Template to use.
		/// @param bManualAttachment				Whether manual or automatic attachment is to be used
		/// @param RelativeTransform				The relative transform between the new component and its attach parent (automatic only)
		/// @param ComponentTemplateContext		Optional UBlueprintGeneratedClass reference to use to find the template in. If null (or not a BPGC), component is sought in this Actor's class
		/// </summary>
		public UActorComponent AddComponent(string TemplateName, bool bManualAttachment, FTransform RelativeTransform, UObject ComponentTemplateContext)
			=> E_AActor_AddComponent(NativePointer, TemplateName, bManualAttachment, RelativeTransform, ComponentTemplateContext);
		
		
		/// <summary>
		/// DEPRECATED - Use Component::DestroyComponent
		/// </summary>
		public void DestroyComponent(UActorComponent Component)
			=> E_AActor_K2_DestroyComponent(NativePointer, Component);
		
		
		/// <summary>
		/// Snap the RootComponent of this Actor to the supplied Actor's root component, optionally at a named socket. It is not valid to call this on components that are not Registered.
		/// If InSocketName == NAME_None, it will attach to origin of the InParentActor.
		/// </summary>
		public void SnapActorTo(AActor InParentActor, string InSocketName)
			=> E_AActor_SnapRootComponentTo(NativePointer, InParentActor, InSocketName);
		
		
		/// <summary>
		/// DEPRECATED: Detaches all SceneComponents in this Actor from the supplied parent SceneComponent.
		/// @param InParentComponent		SceneComponent to detach this actor's components from
		/// @param bMaintainWorldTransform	If true, update the relative location/rotation of this component to keep its world position the same
		/// </summary>
		public void DetachSceneComponentsFromParent(USceneComponent InParentComponent, bool bMaintainWorldPosition = true)
			=> E_AActor_DetachSceneComponentsFromParent(NativePointer, InParentComponent, bMaintainWorldPosition);
		
		
		/// <summary>
		/// See if this actor contains the supplied tag
		/// </summary>
		public bool ActorHasTag(string Tag)
			=> E_AActor_ActorHasTag(NativePointer, Tag);
		
		
		/// <summary>
		/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
		/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
		/// </summary>
		public float GetActorTimeDilation()
			=> E_AActor_GetActorTimeDilation(NativePointer);
		
		public void SetTickPrerequisite(AActor PrerequisiteActor)
			=> E_AActor_SetTickPrerequisite(NativePointer, PrerequisiteActor);
		
		
		/// <summary>
		/// Gets whether this actor can tick when paused.
		/// </summary>
		public bool GetTickableWhenPaused()
			=> E_AActor_GetTickableWhenPaused(NativePointer);
		
		
		/// <summary>
		/// The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.
		/// </summary>
		public float GetGameTimeSinceCreation()
			=> E_AActor_GetGameTimeSinceCreation(NativePointer);
		
		
		/// <summary>
		/// Trigger a noise caused by a given Pawn, at a given location.
		/// Note that the NoiseInstigator Pawn MUST have a PawnNoiseEmitterComponent for the noise to be detected by a PawnSensingComponent.
		/// Senders of MakeNoise should have an Instigator if they are not pawns, or pass a NoiseInstigator.
		/// @param Loudness The relative loudness of this noise. Usual range is 0 (no noise) to 1 (full volume). If MaxRange is used, this scales the max range, otherwise it affects the hearing range specified by the sensor.
		/// @param NoiseInstigator Pawn responsible for this noise.  Uses the actor's Instigator if NoiseInstigator=NULL
		/// @param NoiseLocation Position of noise source.  If zero vector, use the actor's location.
		/// @param MaxRange Max range at which the sound may be heard. A value of 0 indicates no max range (though perception may have its own range). Loudness scales the range. (Note: not supported for legacy PawnSensingComponent, only for AIPerception)
		/// @param Tag Identifier for the noise.
		/// </summary>
		public void MakeNoise(float Loudness, APawn NoiseInstigator, FVector NoiseLocation, float MaxRange, string Tag)
			=> E_AActor_MakeNoise(NativePointer, Loudness, NoiseInstigator, NoiseLocation, MaxRange, Tag);
		
		
		/// <summary>
		/// Event called every frame
		/// </summary>
		public void Tick(float DeltaSeconds)
			=> E_AActor_ReceiveTick(NativePointer, DeltaSeconds);
		
		
		/// <summary>
		/// Destroy this actor. Returns true the actor is destroyed or already marked for destruction, false if indestructible.
		/// Destruction is latent. It occurs at the end of the tick.
		/// @param	bNetForce				[opt] Ignored unless called during play.  Default is false.
		/// @param	bShouldModifyLevel		[opt] If true, Modify() the level before removing the actor.  Default is true.
		/// returns	true if destroyed or already marked for destruction, false if indestructible.
		/// </summary>
		public bool Destroy(bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_AActor_Destroy(NativePointer, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// See if this actor is owned by TestOwner.
		/// </summary>
		public bool IsOwnedBy(AActor TestOwner)
			=> E_AActor_IsOwnedBy(NativePointer, TestOwner);
		
		
		/// <summary>
		/// Returns this actor's root component cast to a primitive component
		/// </summary>
		public UPrimitiveComponent GetRootPrimitiveComponent()
			=> E_AActor_GetRootPrimitiveComponent(NativePointer);
		
		
		/// <summary>
		/// Sets root component to be the specified component.  NewRootComponent's owner should be this actor.
		/// @return true if successful
		/// </summary>
		public bool SetRootComponent(USceneComponent NewRootComponent)
			=> E_AActor_SetRootComponent(NativePointer, NewRootComponent);
		
		
		/// <summary>
		/// Returns the quaternion of the RootComponent of this Actor
		/// </summary>
		public FQuat GetActorQuat()
			=> E_AActor_GetActorQuat(NativePointer);
		
		
		/// <summary>
		/// Called by owning level to shift an actor location and all relevant data structures by specified delta
		/// @param InWorldOffset	 Offset vector to shift actor location
		/// @param bWorldShift	 Whether this call is part of whole world shifting
		/// </summary>
		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_AActor_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		
		
		/// <summary>
		/// When called, will call the virtual call chain to register all of the tick functions for both the actor and optionally all components
		/// Do not override this function or make it virtual
		/// @param bRegister - true to register, false, to unregister
		/// @param bDoComponents - true to also apply the change to all components
		/// </summary>
		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
			=> E_AActor_RegisterAllActorTickFunctions(NativePointer, bRegister, bDoComponents);
		
		
		/// <summary>
		/// Update velocity - typically from ReplicatedMovement, not called for simulated physics!
		/// </summary>
		public void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_AActor_PostNetReceiveVelocity(NativePointer, NewVelocity);
		
		
		/// <summary>
		/// Get the owner of this Actor, used primarily for network replication.
		/// @return Actor that owns this Actor
		/// </summary>
		public AActor GetOwner()
			=> E_AActor_GetOwner(NativePointer);
		
		
		/// <summary>
		/// @param RealViewer - is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller)
		/// @param ViewTarget - is the Actor being used as the point of view for the RealViewer
		/// @param SrcLocation - is the viewing location
		/// @return bool - true if this actor is replay relevant to the client associated with RealViewer
		/// </summary>
		public bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_AActor_IsReplayRelevantFor(NativePointer, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner
		/// @param ReplicatedActor - the actor we're doing a relevancy test on
		/// @param ActorOwner - the owner of ReplicatedActor
		/// @param ConnectionActor - the controller of the connection that we're doing relevancy checks for
		/// @return bool - true if this actor should be considered the owner
		/// </summary>
		public bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_AActor_IsRelevancyOwnerFor(NativePointer, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// Called after the actor is spawned in the world.  Responsible for setting up actor for play.
		/// </summary>
		public void PostSpawnInitialize(FTransform SpawnTransform, AActor InOwner, APawn InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction)
			=> E_AActor_PostSpawnInitialize(NativePointer, SpawnTransform, InOwner, InInstigator, bRemoteOwned, bNoFail, bDeferConstruction);
		
		
		/// <summary>
		/// @return the owning UPlayer (if any) of this actor. This will be a local player, a net connection, or NULL.
		/// </summary>
		public UPlayer GetNetOwningPlayer()
			=> E_AActor_GetNetOwningPlayer(NativePointer);
		
		
		/// <summary>
		/// If this Actor was created by a Child Actor Component returns that Child Actor Component
		/// </summary>
		public UChildActorComponent GetParentComponent()
			=> E_AActor_GetParentComponent(NativePointer);
		
		
		/// <summary>
		/// Incrementally registers components associated with this actor
		/// @param NumComponentsToRegister  Number of components to register in this run, 0 for all
		/// @return true when all components were registered for this actor
		/// </summary>
		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
			=> E_AActor_IncrementalRegisterComponents(NativePointer, NumComponentsToRegister);
		
		
		/// <summary>
		/// Used for adding actors to levels or teleporting them to a new location.
		/// The result of this function is independent of the actor's current location and rotation.
		/// If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false.
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @param bIsATest is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example)
		/// @param bNoCheck is true if we should skip checking for encroachment in the world or other actors
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// </summary>
		public bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest = false, bool bNoCheck = false)
			=> E_AActor_TeleportTo(NativePointer, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// </summary>
		public bool Teleport(FVector DestLocation, FRotator DestRotation)
			=> E_AActor_K2_TeleportTo(NativePointer, DestLocation, DestRotation);
		
		
		/// <summary>
		/// Returns true if this actor is contained by TestLevel.
		/// @todo seamless: update once Actor->Outer != Level
		/// </summary>
		public bool IsInLevel(ULevel TestLevel)
			=> E_AActor_IsInLevel(NativePointer, TestLevel);
		
		
		/// <summary>
		/// Return the ULevel that this Actor is part of.
		/// </summary>
		public ULevel GetLevel()
			=> E_AActor_GetLevel(NativePointer);
		
		
		/// <summary>
		/// Debug helper for showing the component hierarchy of one component
		/// @param Info	Optional String to display at top of info
		/// </summary>
		public void DebugShowOneComponentHierarchy(USceneComponent SceneComp, int NestLevel, bool bShowPosition)
			=> E_AActor_DebugShowOneComponentHierarchy(NativePointer, SceneComp, NestLevel, bShowPosition);
		
		
		/// <summary>
		/// Called when an instance of this class is placed (in editor) or spawned.
		/// @param	Transform			The transform the actor was constructed at.
		/// </summary>
		public void OnConstruction(FTransform Transform)
			=> E_AActor_OnConstruction(NativePointer, Transform);
		
		#endregion
		
		public static implicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AActor(Adress);
		}