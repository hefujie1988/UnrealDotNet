#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "GameFramework/SaveGame.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USaveGame(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USaveGame>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
