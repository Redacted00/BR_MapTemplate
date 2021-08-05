// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BrickRigsEditorTarget : TargetRules
{
	public BrickRigsEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "BrickRigs" } );

		// Game editor
		ExtraModuleNames.AddRange(new string[] { "BrickRigsEditor" });
	}
}