#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/LocalMessage.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\LocalMessage.h:57

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULocalMessage(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULocalMessage>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULocalMessage_ClientReceive(ULocalMessage* Self, INT_PTR ClientData)
	{
		auto& _p0 = *(FClientReceiveData*)ClientData;
		Self->ClientReceive(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
