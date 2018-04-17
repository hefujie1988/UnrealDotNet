#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/BrushComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\BrushComponent.h:21

class E_PROTECTED_WRAP_UBrushComponent : protected UBrushComponent
{
public:
	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, OutHit, MoveFlags, Teleport);
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	bool SupportsStaticLighting_WRAP()
	{
		return SupportsStaticLighting();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBrushComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBrushComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBrushComponent_BuildSimpleBrushCollision(UBrushComponent* Self)
	{
		Self->BuildSimpleBrushCollision();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetStaticDepthPriorityGroup(UBrushComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsEditorOnly(UBrushComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddAngularImpulse(UBrushComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddAngularImpulseInRadians(UBrushComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddForce(UBrushComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddForceAtLocation(UBrushComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddForceAtLocationLocal(UBrushComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddImpulse(UBrushComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddImpulseAtLocation(UBrushComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddRadialForce(UBrushComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddRadialImpulse(UBrushComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AreAllCollideableDescendantsRelative(UBrushComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UBrushComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AreSymmetricRotations(UBrushComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_BeginDestroy(UBrushComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UBrushComponent_BeginPlay(UBrushComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UBrushComponent_CalculateMass(UBrushComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CanCharacterStepUp(UBrushComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CanEditSimulatePhysics(UBrushComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UBrushComponent_CreateRenderState_Concurrent(UBrushComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_DestroyRenderState_Concurrent(UBrushComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_FinishDestroy(UBrushComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetAngularDamping(UBrushComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetCollisionObjectType(UBrushComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetCollisionResponseToChannel(UBrushComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetComponentVelocity(UBrushComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetDiffuseBoost(UBrushComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetEmissiveBoost(UBrushComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetInertiaTensor(UBrushComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetLightAndShadowMapMemoryUsage(UBrushComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetLightMapResolution(UBrushComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetLinearDamping(UBrushComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetMass(UBrushComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetMassScale(UBrushComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetNavigationBounds(UBrushComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetNumMaterials(UBrushComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetShadowIndirectOnly(UBrushComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetSquaredDistanceToCollision(UBrushComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetStaticLightMapResolution(UBrushComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UBrushComponent_HasValidPhysicsState(UBrushComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UBrushComponent_HasValidSettingsForStaticLighting(UBrushComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_InvalidateLightingCacheDetailed(UBrushComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsAnyRigidBodyAwake(UBrushComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsGravityEnabled(UBrushComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsNavigationRelevant(UBrushComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsReadyForFinishDestroy(UBrushComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsSimulatingPhysics(UBrushComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsWorldGeometry(UBrushComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsZeroExtent(UBrushComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_MoveComponentImpl(UBrushComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UBrushComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UBrushComponent_NeedsLoadForClient(UBrushComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UBrushComponent_NeedsLoadForServer(UBrushComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnActorEnableCollisionChanged(UBrushComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnAttachmentChanged(UBrushComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnComponentCollisionSettingsChanged(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnComponentDestroyed(UBrushComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnCreatePhysicsState(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnDestroyPhysicsState(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnRegister(UBrushComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnUnregister(UBrushComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnUpdateTransform(UBrushComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostDuplicate(UBrushComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostLoad(UBrushComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PutAllRigidBodiesToSleep(UBrushComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UBrushComponent_RegisterComponentTickFunctions(UBrushComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_ScaleByMomentOfInertia(UBrushComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UBrushComponent_SendRenderTransform_Concurrent(UBrushComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllMassScale(UBrushComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllPhysicsAngularVelocity(UBrushComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllPhysicsAngularVelocityInRadians(UBrushComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllPhysicsLinearVelocity(UBrushComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllPhysicsPosition(UBrushComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAllUseCCD(UBrushComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAngularDamping(UBrushComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetCollisionObjectType(UBrushComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetCollisionProfileName(UBrushComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetCollisionResponseToAllChannels(UBrushComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetCollisionResponseToChannel(UBrushComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetCollisionResponseToChannels(UBrushComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetEnableGravity(UBrushComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetLinearDamping(UBrushComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetMassOverrideInKg(UBrushComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetMassScale(UBrushComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetNotifyRigidBodyCollision(UBrushComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetSimulatePhysics(UBrushComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetUseCCD(UBrushComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldCreatePhysicsState(UBrushComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldRecreateProxyOnUpdateTransform(UBrushComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldRenderSelected(UBrushComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UBrushComponent_SupportsStaticLighting(UBrushComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UBrushComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_UnWeldChildren(UBrushComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UBrushComponent_UnWeldFromParent(UBrushComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_UpdatePhysicsToRBChannels(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_UpdatePhysicsVolume(UBrushComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_UsesOnlyUnlitMaterials(UBrushComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UBrushComponent_WakeAllRigidBodies(UBrushComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UBrushComponent_WakeRigidBody(UBrushComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_WeldTo(UBrushComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_WeldToImplementation(UBrushComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UBrushComponent_ApplyWorldOffset(UBrushComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CalcBoundingCylinder(UBrushComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CanAttachAsChild(UBrushComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_DestroyComponent(UBrushComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_DetachFromComponent(UBrushComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_DetachFromParent(UBrushComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_DoesSocketExist(UBrushComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetSocketLocation(UBrushComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetSocketQuaternion(UBrushComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetSocketRotation(UBrushComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetSocketTransform(UBrushComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UBrushComponent_HasAnySockets(UBrushComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsAnySimulatingPhysics(UBrushComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsPrecomputedLightingValid(UBrushComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsVisible(UBrushComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsVisibleInEditor(UBrushComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnChildAttached(UBrushComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnChildDetached(UBrushComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnHiddenInGameChanged(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnVisibilityChanged(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostNetReceive(UBrushComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostRepNotifies(UBrushComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PreNetReceive(UBrushComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PropagateLightingScenarioChange(UBrushComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetRelativeScale3D(UBrushComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldCollideWhenPlacing(UBrushComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldCreateRenderState(UBrushComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UBrushComponent_Activate(UBrushComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddTickPrerequisiteActor(UBrushComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddTickPrerequisiteComponent(UBrushComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_Deactivate(UBrushComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetComponentClassCanReplicate(UBrushComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetReadableName(UBrushComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UBrushComponent_InitializeComponent(UBrushComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsActive(UBrushComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsNameStableForNetworking(UBrushComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsReadyForOwnerToAutoDestroy(UBrushComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsSupportedForNetworking(UBrushComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UBrushComponent_MarkAsEditorOnlySubobject(UBrushComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UBrushComponent_NeedsLoadForEditorGame(UBrushComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnComponentCreated(UBrushComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostInitProperties(UBrushComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostRename(UBrushComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_RemoveTickPrerequisiteActor(UBrushComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_RemoveTickPrerequisiteComponent(UBrushComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_RequiresGameThreadEndOfFrameRecreate(UBrushComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UBrushComponent_RequiresGameThreadEndOfFrameUpdates(UBrushComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UBrushComponent_SendRenderDynamicData_Concurrent(UBrushComponent* Self)
	{
		((E_PROTECTED_WRAP_UBrushComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetActive(UBrushComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetAutoActivate(UBrushComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetComponentTickEnabled(UBrushComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_SetComponentTickEnabledAsync(UBrushComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShouldActivate(UBrushComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UBrushComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UBrushComponent_ToggleActive(UBrushComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UBrushComponent_UninitializeComponent(UBrushComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UBrushComponent_AreNativePropertiesIdenticalTo(UBrushComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CheckDefaultSubobjectsInternal(UBrushComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetDesc(UBrushComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UBrushComponent_GetDetailedInfoInternal(UBrushComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsAsset(UBrushComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsFullNameStableForNetworking(UBrushComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsLocalizedResource(UBrushComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsPostLoadThreadSafe(UBrushComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UBrushComponent_IsSafeForRootSet(UBrushComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UBrushComponent_Modify(UBrushComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_NotifyObjectReferenceEliminated(UBrushComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostCDOContruct(UBrushComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostEditImport(UBrushComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UBrushComponent_PostSaveRoot(UBrushComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UBrushComponent_PreDestroyFromReplication(UBrushComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UBrushComponent_ShutdownAfterError(UBrushComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UBrushComponent_AddToCluster(UBrushComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UBrushComponent_CanBeClusterRoot(UBrushComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UBrushComponent_CanBeInCluster(UBrushComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UBrushComponent_CreateCluster(UBrushComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UBrushComponent_OnClusterMarkedAsPendingKill(UBrushComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
