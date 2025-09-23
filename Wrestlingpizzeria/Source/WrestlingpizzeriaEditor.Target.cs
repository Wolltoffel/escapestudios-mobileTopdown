using UnrealBuildTool;
using System.Collections.Generic;

public class WrestlingpizzeriaEditorTarget : TargetRules
{
    public WrestlingpizzeriaEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        ExtraModuleNames.Add("Wrestlingpizzeria");
    }
}
