UNITY_PATH="/Applications/Unity/Hub/Editor/2019.3.8f1/Unity.app/Contents/MacOS/Unity"
PROJECT_PATH=""
echo Starting builds
echo Building Game1
$UNITY_PATH -quit -batchmode -projectPath $PROJECT_PATH -executeMethod BuildConfigs.BuildGame1
echo Finished Building Game1
echo Building Game2
$UNITY_PATH -quit -batchmode -projectPath $PROJECT_PATH -executeMethod BuildConfigs.BuildGame2
echo Finished Building Game2
echo Building Android
$UNITY_PATH -quit -batchmode -projectPath $PROJECT_PATH -executeMethod BuildConfigs.BuildAndroid
echo Finished Building Android
echo Finished Building