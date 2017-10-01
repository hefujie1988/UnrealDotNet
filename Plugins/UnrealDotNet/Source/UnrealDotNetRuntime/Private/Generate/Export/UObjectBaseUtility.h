#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "UObject/UObjectBaseUtility.h"

extern "C"
{
	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerIndex(UObjectBaseUtility* Self)
	{
		return ConvertForManage(Self->GetLinkerIndex());
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(UObjectBaseUtility* Self)
	{
		return ConvertForManage(Self->GetLinkerLicenseeUE4Version());
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_GetLinkerUE4Version(UObjectBaseUtility* Self)
	{
		return ConvertForManage(Self->GetLinkerUE4Version());
	}

	DOTNET_EXPORT auto E_UObjectBaseUtility_IsDefaultSubobject(UObjectBaseUtility* Self)
	{
		return ConvertForManage(Self->IsDefaultSubobject());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
