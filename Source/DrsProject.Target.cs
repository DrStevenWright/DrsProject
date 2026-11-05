// Copyright (c) 2026 Steven Wright. Licensed under the MIT License.

using UnrealBuildTool;
using System.Collections.Generic;

public class DrsProjectTarget : TargetRules
{
	public DrsProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("DrsProject");
	}
}
