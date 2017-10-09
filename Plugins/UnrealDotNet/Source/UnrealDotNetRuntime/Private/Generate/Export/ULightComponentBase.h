#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/LightComponentBase.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\LightComponentBase.h:14

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponentBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponentBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
