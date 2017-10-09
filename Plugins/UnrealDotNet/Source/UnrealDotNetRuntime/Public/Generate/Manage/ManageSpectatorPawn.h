#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "GameFramework/SpectatorPawn.h"
#include "ManageSpectatorPawn.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\SpectatorPawn.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API AManageSpectatorPawn : public ASpectatorPawn
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
