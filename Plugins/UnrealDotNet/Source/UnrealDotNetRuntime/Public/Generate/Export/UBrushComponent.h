#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/BrushComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BrushComponent.h:21

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBrushComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBrushComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBrushComponent_BuildSimpleBrushCollision(UBrushComponent* Self)
	{
		Self->BuildSimpleBrushCollision();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
