#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/BoxComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\BoxComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBoxComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBoxComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBoxComponent_GetScaledBoxExtent(UBoxComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetScaledBoxExtent());
	}

	DOTNET_EXPORT auto E_UBoxComponent_GetUnscaledBoxExtent(UBoxComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUnscaledBoxExtent());
	}

	DOTNET_EXPORT auto E_UBoxComponent_SetBoxExtent(UBoxComponent* Self, INT_PTR InBoxExtent, bool bUpdateOverlaps)
	{
		auto _p0 = *(FVector*)InBoxExtent;
		auto _p1 = bUpdateOverlaps;
		Self->SetBoxExtent(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
