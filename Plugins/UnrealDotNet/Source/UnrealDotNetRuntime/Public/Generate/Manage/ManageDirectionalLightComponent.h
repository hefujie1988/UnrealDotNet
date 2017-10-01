#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/DirectionalLightComponent.h"
#include "ManageDirectionalLightComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageDirectionalLightComponent : public UDirectionalLightComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS