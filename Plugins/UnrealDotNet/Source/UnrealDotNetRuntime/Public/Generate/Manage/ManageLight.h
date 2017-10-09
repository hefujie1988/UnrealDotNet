#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Light.h"
#include "ManageLight.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Light.h:13

UCLASS()
class UNREALDOTNETRUNTIME_API AManageLight : public ALight
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void OnRep_bEnabled() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
