#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent2D.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneCaptureComponent2D(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneCaptureComponent2D>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
