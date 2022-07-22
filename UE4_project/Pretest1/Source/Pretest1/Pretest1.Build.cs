// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Pretest1 : ModuleRules
{
	public Pretest1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
