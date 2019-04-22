#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/Light.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_ALight(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ALight>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ALight_GetBrightness(ALight* Self)
	{
		return Self->GetBrightness();
	}

	DOTNET_EXPORT auto E_ALight_GetLightColor(ALight* Self)
	{
		return (INT_PTR) new FLinearColor(Self->GetLightColor());
	}

	DOTNET_EXPORT auto E_ALight_GetLightComponent(ALight* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetLightComponent());
	}

	DOTNET_EXPORT auto E_ALight_IsEnabled(ALight* Self)
	{
		return Self->IsEnabled();
	}

	DOTNET_EXPORT auto E_ALight_IsToggleable(ALight* Self)
	{
		return Self->IsToggleable();
	}

	DOTNET_EXPORT auto E_ALight_OnRep_bEnabled(ALight* Self)
	{
		Self->OnRep_bEnabled();
	}

	DOTNET_EXPORT auto E_ALight_SetAffectTranslucentLighting(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetBrightness(ALight* Self, float NewBrightness)
	{
		auto _p0 = NewBrightness;
		Self->SetBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetCastShadows(ALight* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastShadows(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetEnabled(ALight* Self, bool bSetEnabled)
	{
		auto _p0 = bSetEnabled;
		Self->SetEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightColor(ALight* Self, INT_PTR NewLightColor)
	{
		auto _p0 = *(FLinearColor*)NewLightColor;
		Self->SetLightColor(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionFadeDistance(ALight* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ALight_SetLightFunctionScale(ALight* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ALight_ToggleEnabled(ALight* Self)
	{
		Self->ToggleEnabled();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
