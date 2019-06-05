#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/GameFramework/DefaultPawn.h"
#include "ManageDefaultPawn.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

UCLASS()
class UNREALDOTNETRUNTIME_API AManageDefaultPawn : public ADefaultPawn, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void LookUpAtRate(float Rate) override;
	virtual void MoveForward(float Val) override;
	virtual void MoveRight(float Val) override;
	virtual void MoveUp_World(float Val) override;
	virtual void TurnAtRate(float Rate) override;
	virtual void AddControllerPitchInput(float Val) override;
	virtual void AddControllerRollInput(float Val) override;
	virtual void AddControllerYawInput(float Val) override;
	virtual void DestroyPlayerInputComponent() override;
	virtual void DetachFromControllerPendingDestroy() override;
	virtual void OnRep_Controller() override;
	virtual void OnRep_PlayerState() override;
	virtual void PawnClientRestart() override;
	virtual void PawnStartFire(uint8 FireModeNum) override;
	virtual void RecalculateBaseEyeHeight() override;
	virtual void Restart() override;
	virtual void SetPlayerDefaults() override;
	virtual void SpawnDefaultController() override;
	virtual void TurnOff() override;
	virtual void UnPossessed() override;
	virtual void UpdateNavigationRelevance() override;
	virtual void BeginPlay() override;
	virtual void ClearCrossLevelReferences() override;
	virtual void Destroyed() override;
	virtual void ForceNetRelevant() override;
	virtual void ForceNetUpdate() override;
	virtual void GatherCurrentMovement() override;
	virtual void InvalidateLightingCacheDetailed(bool bTranslationOnly) override;
	virtual void K2_DestroyActor() override;
	virtual void LifeSpanExpired() override;
	virtual void MarkComponentsAsPendingKill() override;
	virtual void NotifyActorBeginCursorOver() override;
	virtual void NotifyActorEndCursorOver() override;
	virtual void OnRep_AttachmentReplication() override;
	virtual void OnRep_Instigator() override;
	virtual void OnRep_Owner() override;
	virtual void OnRep_ReplicatedMovement() override;
	virtual void OnRep_ReplicateMovement() override;
	virtual void OnReplicationPausedChanged(bool bIsReplicationPaused) override;
	virtual void OutsideWorldBounds() override;
	virtual void PostActorCreated() override;
	virtual void PostInitializeComponents() override;
	virtual void PostNetInit() override;
	virtual void PostNetReceiveLocationAndRotation() override;
	virtual void PostNetReceivePhysicState() override;
	virtual void PostNetReceiveRole() override;
	virtual void PostRegisterAllComponents() override;
	virtual void PostUnregisterAllComponents() override;
	virtual void PreInitializeComponents() override;
	virtual void PreRegisterAllComponents() override;
	virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups) override;
	virtual void RegisterActorTickFunctions(bool bRegister) override;
	virtual void RegisterAllComponents() override;
	virtual void ReregisterAllComponents() override;
	virtual void RerunConstructionScripts() override;
	virtual void Reset() override;
	virtual void RewindForReplay() override;
	virtual void SetActorHiddenInGame(bool bNewHidden) override;
	virtual void SetLifeSpan(float InLifespan) override;
	virtual void SetReplicateMovement(bool bInReplicateMovement) override;
	virtual void TearOff() override;
	virtual void TeleportSucceeded(bool bIsATest) override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void TornOff() override;
	virtual void UnregisterAllComponents(bool bForReregister) override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__LookUpAtRate(float Rate);
	void _Supper__MoveForward(float Val);
	void _Supper__MoveRight(float Val);
	void _Supper__MoveUp_World(float Val);
	void _Supper__TurnAtRate(float Rate);
	void _Supper__AddControllerPitchInput(float Val);
	void _Supper__AddControllerRollInput(float Val);
	void _Supper__AddControllerYawInput(float Val);
	void _Supper__DestroyPlayerInputComponent();
	void _Supper__DetachFromControllerPendingDestroy();
	void _Supper__OnRep_Controller();
	void _Supper__OnRep_PlayerState();
	void _Supper__PawnClientRestart();
	void _Supper__PawnStartFire(uint8 FireModeNum);
	void _Supper__RecalculateBaseEyeHeight();
	void _Supper__Restart();
	void _Supper__SetPlayerDefaults();
	void _Supper__SpawnDefaultController();
	void _Supper__TurnOff();
	void _Supper__UnPossessed();
	void _Supper__UpdateNavigationRelevance();
	void _Supper__BeginPlay();
	void _Supper__ClearCrossLevelReferences();
	void _Supper__Destroyed();
	void _Supper__ForceNetRelevant();
	void _Supper__ForceNetUpdate();
	void _Supper__GatherCurrentMovement();
	void _Supper__InvalidateLightingCacheDetailed(bool bTranslationOnly);
	void _Supper__K2_DestroyActor();
	void _Supper__LifeSpanExpired();
	void _Supper__MarkComponentsAsPendingKill();
	void _Supper__NotifyActorBeginCursorOver();
	void _Supper__NotifyActorEndCursorOver();
	void _Supper__OnRep_AttachmentReplication();
	void _Supper__OnRep_Instigator();
	void _Supper__OnRep_Owner();
	void _Supper__OnRep_ReplicatedMovement();
	void _Supper__OnRep_ReplicateMovement();
	void _Supper__OnReplicationPausedChanged(bool bIsReplicationPaused);
	void _Supper__OutsideWorldBounds();
	void _Supper__PostActorCreated();
	void _Supper__PostInitializeComponents();
	void _Supper__PostNetInit();
	void _Supper__PostNetReceiveLocationAndRotation();
	void _Supper__PostNetReceivePhysicState();
	void _Supper__PostNetReceiveRole();
	void _Supper__PostRegisterAllComponents();
	void _Supper__PostUnregisterAllComponents();
	void _Supper__PreInitializeComponents();
	void _Supper__PreRegisterAllComponents();
	void _Supper__PrestreamTextures(float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups);
	void _Supper__RegisterActorTickFunctions(bool bRegister);
	void _Supper__RegisterAllComponents();
	void _Supper__ReregisterAllComponents();
	void _Supper__RerunConstructionScripts();
	void _Supper__Reset();
	void _Supper__RewindForReplay();
	void _Supper__SetActorHiddenInGame(bool bNewHidden);
	void _Supper__SetLifeSpan(float InLifespan);
	void _Supper__SetReplicateMovement(bool bInReplicateMovement);
	void _Supper__TearOff();
	void _Supper__TeleportSucceeded(bool bIsATest);
	void _Supper__Tick(float DeltaSeconds);
	void _Supper__TornOff();
	void _Supper__UnregisterAllComponents(bool bForReregister);
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
