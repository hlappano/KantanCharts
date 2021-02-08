KantanCharts
-------------

@NOTE: Due to changes specific to my personal build scripts, the 'develop' branch is now the one to use rather than 'master' if you want to work with this repository.


**Essential Note on Building:**
Use command "UE4_DIR\Engine\BuildBatchFiles\RunUAT.bat" BuildPlugin -Rocket -Plugin="PATH/TO/PLUGIN/KantanCharts.uplugin" - TargetPlatforms=Win64 -Package="PATH/TO/OUTPUT/DIRECTORY/KantanCharts"
  * UE4_DIR - Engine version directory to compile under
  * TargetPlatforms - Which platforms to build for.
  * Package - Output Directory of the Package.
  * Rocket argument might be invalid. Was using an old resource.
  * Also the help argument can be useful in case of changes to arguments
    * RunUAT.bat BuildPlugin -help