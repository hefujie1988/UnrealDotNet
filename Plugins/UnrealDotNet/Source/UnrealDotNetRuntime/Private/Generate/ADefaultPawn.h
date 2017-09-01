#pragma once

#include "CoreMinimal.h"
#include "GameFramework/DefaultPawn.h"

extern "C"
{
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_MovementComponentName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((ADefaultPawn*)Ptr)->MovementComponentName.ToString()); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MovementComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->MovementComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_CollisionComponentName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((ADefaultPawn*)Ptr)->CollisionComponentName.ToString()); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_CollisionComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->CollisionComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_MeshComponentName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((ADefaultPawn*)Ptr)->MeshComponentName.ToString()); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MeshComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->MeshComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT USphereComponent* E_ADefaultPawn_GetCollisionComponent(INT_PTR Self)
	{
		return ((ADefaultPawn*)Self)->GetCollisionComponent();
	}

	DOTNET_EXPORT UStaticMeshComponent* E_ADefaultPawn_GetMeshComponent(INT_PTR Self)
	{
		return ((ADefaultPawn*)Self)->GetMeshComponent();
	}

}