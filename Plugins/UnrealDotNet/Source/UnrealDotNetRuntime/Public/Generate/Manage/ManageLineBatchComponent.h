#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/LineBatchComponent.h"
#include "ManageLineBatchComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageLineBatchComponent : public ULineBatchComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS