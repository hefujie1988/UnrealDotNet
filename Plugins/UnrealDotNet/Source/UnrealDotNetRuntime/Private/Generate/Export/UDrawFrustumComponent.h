#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/DrawFrustumComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\DrawFrustumComponent.h:18

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDrawFrustumComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDrawFrustumComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
