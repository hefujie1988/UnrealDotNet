// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageBillboardComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

bool UManageBillboardComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageBillboardComponent::SetUV(int32 NewU, int32 NewUL, int32 NewV, int32 NewVL)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetUV", NewU, NewUL, NewV, NewVL);
	else
		Super::SetUV(NewU, NewUL, NewV, NewVL);
}

void UManageBillboardComponent::_Supper__SetUV(int32 NewU, int32 NewUL, int32 NewV, int32 NewVL)
{
	Super::SetUV(NewU, NewUL, NewV, NewVL);
}

void UManageBillboardComponent::OnComponentCollisionSettingsChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCollisionSettingsChanged");
	else
		Super::OnComponentCollisionSettingsChanged();
}

void UManageBillboardComponent::_Supper__OnComponentCollisionSettingsChanged()
{
	Super::OnComponentCollisionSettingsChanged();
}

void UManageBillboardComponent::PutAllRigidBodiesToSleep()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PutAllRigidBodiesToSleep");
	else
		Super::PutAllRigidBodiesToSleep();
}

void UManageBillboardComponent::_Supper__PutAllRigidBodiesToSleep()
{
	Super::PutAllRigidBodiesToSleep();
}

void UManageBillboardComponent::SetAllMassScale(float InMassScale)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllMassScale", InMassScale);
	else
		Super::SetAllMassScale(InMassScale);
}

void UManageBillboardComponent::_Supper__SetAllMassScale(float InMassScale)
{
	Super::SetAllMassScale(InMassScale);
}

void UManageBillboardComponent::SetAllUseCCD(bool InUseCCD)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAllUseCCD", InUseCCD);
	else
		Super::SetAllUseCCD(InUseCCD);
}

void UManageBillboardComponent::_Supper__SetAllUseCCD(bool InUseCCD)
{
	Super::SetAllUseCCD(InUseCCD);
}

void UManageBillboardComponent::SetAngularDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAngularDamping", InDamping);
	else
		Super::SetAngularDamping(InDamping);
}

void UManageBillboardComponent::_Supper__SetAngularDamping(float InDamping)
{
	Super::SetAngularDamping(InDamping);
}

void UManageBillboardComponent::SetEnableGravity(bool bGravityEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetEnableGravity", bGravityEnabled);
	else
		Super::SetEnableGravity(bGravityEnabled);
}

void UManageBillboardComponent::_Supper__SetEnableGravity(bool bGravityEnabled)
{
	Super::SetEnableGravity(bGravityEnabled);
}

void UManageBillboardComponent::SetLinearDamping(float InDamping)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLinearDamping", InDamping);
	else
		Super::SetLinearDamping(InDamping);
}

void UManageBillboardComponent::_Supper__SetLinearDamping(float InDamping)
{
	Super::SetLinearDamping(InDamping);
}

void UManageBillboardComponent::SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetNotifyRigidBodyCollision", bNewNotifyRigidBodyCollision);
	else
		Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageBillboardComponent::_Supper__SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	Super::SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision);
}

void UManageBillboardComponent::SetSimulatePhysics(bool bSimulate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetSimulatePhysics", bSimulate);
	else
		Super::SetSimulatePhysics(bSimulate);
}

void UManageBillboardComponent::_Supper__SetSimulatePhysics(bool bSimulate)
{
	Super::SetSimulatePhysics(bSimulate);
}

void UManageBillboardComponent::UnWeldChildren()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldChildren");
	else
		Super::UnWeldChildren();
}

void UManageBillboardComponent::_Supper__UnWeldChildren()
{
	Super::UnWeldChildren();
}

void UManageBillboardComponent::UnWeldFromParent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnWeldFromParent");
	else
		Super::UnWeldFromParent();
}

void UManageBillboardComponent::_Supper__UnWeldFromParent()
{
	Super::UnWeldFromParent();
}

void UManageBillboardComponent::UpdatePhysicsToRBChannels()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsToRBChannels");
	else
		Super::UpdatePhysicsToRBChannels();
}

void UManageBillboardComponent::_Supper__UpdatePhysicsToRBChannels()
{
	Super::UpdatePhysicsToRBChannels();
}

void UManageBillboardComponent::WakeAllRigidBodies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "WakeAllRigidBodies");
	else
		Super::WakeAllRigidBodies();
}

void UManageBillboardComponent::_Supper__WakeAllRigidBodies()
{
	Super::WakeAllRigidBodies();
}

void UManageBillboardComponent::DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromParent", bMaintainWorldPosition, bCallModify);
	else
		Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageBillboardComponent::_Supper__DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)
{
	Super::DetachFromParent(bMaintainWorldPosition, bCallModify);
}

void UManageBillboardComponent::OnAttachmentChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnAttachmentChanged");
	else
		Super::OnAttachmentChanged();
}

void UManageBillboardComponent::_Supper__OnAttachmentChanged()
{
	Super::OnAttachmentChanged();
}

void UManageBillboardComponent::OnHiddenInGameChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnHiddenInGameChanged");
	else
		Super::OnHiddenInGameChanged();
}

void UManageBillboardComponent::_Supper__OnHiddenInGameChanged()
{
	Super::OnHiddenInGameChanged();
}

void UManageBillboardComponent::OnVisibilityChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnVisibilityChanged");
	else
		Super::OnVisibilityChanged();
}

void UManageBillboardComponent::_Supper__OnVisibilityChanged()
{
	Super::OnVisibilityChanged();
}

void UManageBillboardComponent::PropagateLightingScenarioChange()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PropagateLightingScenarioChange");
	else
		Super::PropagateLightingScenarioChange();
}

void UManageBillboardComponent::_Supper__PropagateLightingScenarioChange()
{
	Super::PropagateLightingScenarioChange();
}

void UManageBillboardComponent::UpdateBounds()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateBounds");
	else
		Super::UpdateBounds();
}

void UManageBillboardComponent::_Supper__UpdateBounds()
{
	Super::UpdateBounds();
}

void UManageBillboardComponent::UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdatePhysicsVolume", bTriggerNotifiers);
	else
		Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageBillboardComponent::_Supper__UpdatePhysicsVolume(bool bTriggerNotifiers)
{
	Super::UpdatePhysicsVolume(bTriggerNotifiers);
}

void UManageBillboardComponent::Activate(bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Activate", bReset);
	else
		Super::Activate(bReset);
}

void UManageBillboardComponent::_Supper__Activate(bool bReset)
{
	Super::Activate(bReset);
}

void UManageBillboardComponent::BeginPlay()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginPlay");
	else
		Super::BeginPlay();
}

void UManageBillboardComponent::_Supper__BeginPlay()
{
	Super::BeginPlay();
}

void UManageBillboardComponent::CreateRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateRenderState_Concurrent");
	else
		Super::CreateRenderState_Concurrent();
}

void UManageBillboardComponent::_Supper__CreateRenderState_Concurrent()
{
	Super::CreateRenderState_Concurrent();
}

void UManageBillboardComponent::Deactivate()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Deactivate");
	else
		Super::Deactivate();
}

void UManageBillboardComponent::_Supper__Deactivate()
{
	Super::Deactivate();
}

void UManageBillboardComponent::DestroyComponent(bool bPromoteChildren)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyComponent", bPromoteChildren);
	else
		Super::DestroyComponent(bPromoteChildren);
}

void UManageBillboardComponent::_Supper__DestroyComponent(bool bPromoteChildren)
{
	Super::DestroyComponent(bPromoteChildren);
}

void UManageBillboardComponent::DestroyRenderState_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyRenderState_Concurrent");
	else
		Super::DestroyRenderState_Concurrent();
}

void UManageBillboardComponent::_Supper__DestroyRenderState_Concurrent()
{
	Super::DestroyRenderState_Concurrent();
}

void UManageBillboardComponent::InitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitializeComponent");
	else
		Super::InitializeComponent();
}

void UManageBillboardComponent::_Supper__InitializeComponent()
{
	Super::InitializeComponent();
}

void UManageBillboardComponent::InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvalidateLightingCacheDetailed", bInvalidateBuildEnqueuedLighting, bTranslationOnly);
	else
		Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageBillboardComponent::_Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
{
	Super::InvalidateLightingCacheDetailed(bInvalidateBuildEnqueuedLighting, bTranslationOnly);
}

void UManageBillboardComponent::OnActorEnableCollisionChanged()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnActorEnableCollisionChanged");
	else
		Super::OnActorEnableCollisionChanged();
}

void UManageBillboardComponent::_Supper__OnActorEnableCollisionChanged()
{
	Super::OnActorEnableCollisionChanged();
}

void UManageBillboardComponent::OnComponentCreated()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentCreated");
	else
		Super::OnComponentCreated();
}

void UManageBillboardComponent::_Supper__OnComponentCreated()
{
	Super::OnComponentCreated();
}

void UManageBillboardComponent::OnComponentDestroyed(bool bDestroyingHierarchy)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnComponentDestroyed", bDestroyingHierarchy);
	else
		Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageBillboardComponent::_Supper__OnComponentDestroyed(bool bDestroyingHierarchy)
{
	Super::OnComponentDestroyed(bDestroyingHierarchy);
}

void UManageBillboardComponent::OnCreatePhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnCreatePhysicsState");
	else
		Super::OnCreatePhysicsState();
}

void UManageBillboardComponent::_Supper__OnCreatePhysicsState()
{
	Super::OnCreatePhysicsState();
}

void UManageBillboardComponent::OnDestroyPhysicsState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnDestroyPhysicsState");
	else
		Super::OnDestroyPhysicsState();
}

void UManageBillboardComponent::_Supper__OnDestroyPhysicsState()
{
	Super::OnDestroyPhysicsState();
}

void UManageBillboardComponent::OnRegister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRegister");
	else
		Super::OnRegister();
}

void UManageBillboardComponent::_Supper__OnRegister()
{
	Super::OnRegister();
}

void UManageBillboardComponent::OnRep_IsActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_IsActive");
	else
		Super::OnRep_IsActive();
}

void UManageBillboardComponent::_Supper__OnRep_IsActive()
{
	Super::OnRep_IsActive();
}

void UManageBillboardComponent::OnUnregister()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnUnregister");
	else
		Super::OnUnregister();
}

void UManageBillboardComponent::_Supper__OnUnregister()
{
	Super::OnUnregister();
}

void UManageBillboardComponent::RegisterComponentTickFunctions(bool bRegister)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterComponentTickFunctions", bRegister);
	else
		Super::RegisterComponentTickFunctions(bRegister);
}

void UManageBillboardComponent::_Supper__RegisterComponentTickFunctions(bool bRegister)
{
	Super::RegisterComponentTickFunctions(bRegister);
}

void UManageBillboardComponent::SendRenderDynamicData_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderDynamicData_Concurrent");
	else
		Super::SendRenderDynamicData_Concurrent();
}

void UManageBillboardComponent::_Supper__SendRenderDynamicData_Concurrent()
{
	Super::SendRenderDynamicData_Concurrent();
}

void UManageBillboardComponent::SendRenderTransform_Concurrent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendRenderTransform_Concurrent");
	else
		Super::SendRenderTransform_Concurrent();
}

void UManageBillboardComponent::_Supper__SendRenderTransform_Concurrent()
{
	Super::SendRenderTransform_Concurrent();
}

void UManageBillboardComponent::SetActive(bool bNewActive, bool bReset)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetActive", bNewActive, bReset);
	else
		Super::SetActive(bNewActive, bReset);
}

void UManageBillboardComponent::_Supper__SetActive(bool bNewActive, bool bReset)
{
	Super::SetActive(bNewActive, bReset);
}

void UManageBillboardComponent::SetAutoActivate(bool bNewAutoActivate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetAutoActivate", bNewAutoActivate);
	else
		Super::SetAutoActivate(bNewAutoActivate);
}

void UManageBillboardComponent::_Supper__SetAutoActivate(bool bNewAutoActivate)
{
	Super::SetAutoActivate(bNewAutoActivate);
}

void UManageBillboardComponent::SetComponentTickEnabled(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabled", bEnabled);
	else
		Super::SetComponentTickEnabled(bEnabled);
}

void UManageBillboardComponent::_Supper__SetComponentTickEnabled(bool bEnabled)
{
	Super::SetComponentTickEnabled(bEnabled);
}

void UManageBillboardComponent::SetComponentTickEnabledAsync(bool bEnabled)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetComponentTickEnabledAsync", bEnabled);
	else
		Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageBillboardComponent::_Supper__SetComponentTickEnabledAsync(bool bEnabled)
{
	Super::SetComponentTickEnabledAsync(bEnabled);
}

void UManageBillboardComponent::ToggleActive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleActive");
	else
		Super::ToggleActive();
}

void UManageBillboardComponent::_Supper__ToggleActive()
{
	Super::ToggleActive();
}

void UManageBillboardComponent::UninitializeComponent()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UninitializeComponent");
	else
		Super::UninitializeComponent();
}

void UManageBillboardComponent::_Supper__UninitializeComponent()
{
	Super::UninitializeComponent();
}

void UManageBillboardComponent::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageBillboardComponent::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageBillboardComponent::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageBillboardComponent::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageBillboardComponent::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageBillboardComponent::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageBillboardComponent::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageBillboardComponent::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageBillboardComponent::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageBillboardComponent::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageBillboardComponent::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageBillboardComponent::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageBillboardComponent::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageBillboardComponent::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageBillboardComponent::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageBillboardComponent::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageBillboardComponent::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageBillboardComponent::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageBillboardComponent::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageBillboardComponent::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageBillboardComponent::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageBillboardComponent::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageBillboardComponent::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageBillboardComponent::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageBillboardComponent::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageBillboardComponent::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageBillboardComponent::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageBillboardComponent::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageBillboardComponent::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageBillboardComponent::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
