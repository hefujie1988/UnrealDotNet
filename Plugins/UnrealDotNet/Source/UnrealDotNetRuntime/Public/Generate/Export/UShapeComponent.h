#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/ShapeComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ShapeComponent.h:24

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UShapeComponent_bDrawOnlyIfSelected_GET(UShapeComponent* Ptr) { return Ptr->bDrawOnlyIfSelected; }
	DOTNET_EXPORT void E_PROP_UShapeComponent_bDrawOnlyIfSelected_SET(UShapeComponent* Ptr, uint8 Value) { Ptr->bDrawOnlyIfSelected = Value; }
	
	DOTNET_EXPORT auto E_PROP_UShapeComponent_bDynamicObstacle_GET(UShapeComponent* Ptr) { return Ptr->bDynamicObstacle; }
	DOTNET_EXPORT void E_PROP_UShapeComponent_bDynamicObstacle_SET(UShapeComponent* Ptr, uint8 Value) { Ptr->bDynamicObstacle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UShapeComponent_bShouldCollideWhenPlacing_GET(UShapeComponent* Ptr) { return Ptr->bShouldCollideWhenPlacing; }
	DOTNET_EXPORT void E_PROP_UShapeComponent_bShouldCollideWhenPlacing_SET(UShapeComponent* Ptr, uint8 Value) { Ptr->bShouldCollideWhenPlacing = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UShapeComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UShapeComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UShapeComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		Self->UpdateBodySetup();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
