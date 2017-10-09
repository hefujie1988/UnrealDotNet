#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/CapsuleComponent.h"
#include "ManageCapsuleComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\CapsuleComponent.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API UManageCapsuleComponent : public UCapsuleComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
