#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManagePawnNoiseEmitterComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnNoiseEmitterComponent : public UPawnNoiseEmitterComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditDefaultsOnly, Category = "C#")
	FString ManageClassName;
	
	
public:
	
	virtual void MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
