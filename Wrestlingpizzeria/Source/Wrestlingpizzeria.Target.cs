using UnrealBuildTool;
using System.Collections.Generic;

public class WrestlingpizzeriaTarget : TargetRules
{
    public WrestlingpizzeriaTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        ExtraModuleNames.Add("Wrestlingpizzeria");
    }
}
