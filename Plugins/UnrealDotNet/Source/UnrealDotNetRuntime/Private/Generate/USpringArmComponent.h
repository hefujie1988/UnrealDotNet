#pragma once

#include "CoreMinimal.h"
#include "GameFramework/SpringArmComponent.h"

class E_PROTECTED_WRAP_USpringArmComponent : protected USpringArmComponent
{
	public:
	void UpdateDesiredArmLocation_WRAP(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	}

	FVector BlendLocations_WRAP(const FVector& DesiredArmLocation, const FVector& TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		return BlendLocations(DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
	}

}
;

extern "C"
{
	DOTNET_EXPORT bool E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(INT_PTR Ptr) { return ((USpringArmComponent*)Ptr)->bUseControllerViewRotation; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(INT_PTR Ptr, bool Value) { ((USpringArmComponent*)Ptr)->bUseControllerViewRotation = Value; }
	
	DOTNET_EXPORT void E_USpringArmComponent_UpdateDesiredArmLocation(INT_PTR Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT INT_PTR E_USpringArmComponent_BlendLocations(INT_PTR Self, INT_PTR DesiredArmLocation, INT_PTR TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		auto _p0 = *(FVector*)DesiredArmLocation;
		auto _p1 = *(FVector*)TraceHitLocation;
		auto _p2 = bHitSomething;
		auto _p3 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_USpringArmComponent*)Self)->BlendLocations_WRAP(_p0, _p1, _p2, _p3));
	}

}