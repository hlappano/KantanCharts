// Copyright (C) 2015 Cameron Angus. All Rights Reserved.

using UnrealBuildTool;

public class KantanChartsEditor : ModuleRules
{
	public KantanChartsEditor(ReadOnlyTargetRules Target): base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "UnrealEd",
                "PropertyEditor",
                "EditorStyle",
                "Projects",
                "XmlParser",
            }
            );

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",        // Seemingly needed for SNumericEntryBox
                "KantanChartsDatasource",
                "KantanChartsSlate",
				"KantanChartsUMG"
            }
            );

		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
                "MainFrame",
                "ContentBrowser",
                "AssetTools",
                "AssetRegistry",
            }
            );

        PrivateIncludePathModuleNames.AddRange(
            new string[]
            {
                "MainFrame",
                "ContentBrowser",
                "AssetTools",
                "AssetRegistry",
            }
            );
    }
}
