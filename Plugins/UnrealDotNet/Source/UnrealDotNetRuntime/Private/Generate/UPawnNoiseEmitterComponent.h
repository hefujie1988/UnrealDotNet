#pragma once

#include "CoreMinimal.h"
#include "Components/PawnNoiseEmitterComponent.h"

extern "C"
{
	DOTNET_EXPORT INT_PTR E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((UPawnNoiseEmitterComponent*)Ptr)->LastRemoteNoisePosition); }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(INT_PTR Ptr, INT_PTR Value) { ((UPawnNoiseEmitterComponent*)Ptr)->LastRemoteNoisePosition = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(INT_PTR Ptr) { return ((UPawnNoiseEmitterComponent*)Ptr)->NoiseLifetime; }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(INT_PTR Ptr, float Value) { ((UPawnNoiseEmitterComponent*)Ptr)->NoiseLifetime = Value; }
	
	DOTNET_EXPORT void E_UPawnNoiseEmitterComponent_MakeNoise(INT_PTR Self, AActor* NoiseMaker, float Loudness, INT_PTR NoiseLocation)
	{
		auto _p0 = NoiseMaker;
		auto _p1 = Loudness;
		auto _p2 = *(FVector*)NoiseLocation;
		((UPawnNoiseEmitterComponent*)Self)->MakeNoise(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(INT_PTR Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return ((UPawnNoiseEmitterComponent*)Self)->GetLastNoiseVolume(_p0);
	}

}