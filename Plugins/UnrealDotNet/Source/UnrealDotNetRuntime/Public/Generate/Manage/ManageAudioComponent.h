#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/AudioComponent.h"
#include "ManageAudioComponent.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\AudioComponent.h:90

UCLASS()
class UNREALDOTNETRUNTIME_API UManageAudioComponent : public UAudioComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
