#pragma once

#include "Engine.h"
#include "CoreMinimal.h"

class FUnrealDotNetEditorModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
