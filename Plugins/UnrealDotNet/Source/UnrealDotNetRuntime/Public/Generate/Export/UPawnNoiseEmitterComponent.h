#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(UPawnNoiseEmitterComponent* Ptr) { return (INT_PTR)&(Ptr->LastRemoteNoisePosition); }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(UPawnNoiseEmitterComponent* Ptr, INT_PTR Value) { Ptr->LastRemoteNoisePosition = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(UPawnNoiseEmitterComponent* Ptr) { return Ptr->NoiseLifetime; }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(UPawnNoiseEmitterComponent* Ptr, float Value) { Ptr->NoiseLifetime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnNoiseEmitterComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnNoiseEmitterComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseTime(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseTime(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_MakeNoise(UPawnNoiseEmitterComponent* Self, AActor* NoiseMaker, float Loudness, INT_PTR NoiseLocation)
	{
		auto _p0 = NoiseMaker;
		auto _p1 = Loudness;
		auto& _p2 = *(FVector*)NoiseLocation;
		Self->UPawnNoiseEmitterComponent::MakeNoise(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
