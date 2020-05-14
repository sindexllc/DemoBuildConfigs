using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public class BuildConfigs
{
    [MenuItem("Builds/Web Game1")]
    public static void BuildGame1()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();

        buildPlayerOptions.scenes = new[] { //The scenes we want to build
            "Assets/Scenes/Game1Scene1.unity",
            "Assets/Scenes/Game1Scene2.unity"
        };

        buildPlayerOptions.locationPathName = "../Builds/Game1"; //The location of the build, lets put it outside our project folder

        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;

        PlayerSettings.WebGL.template = "PROJECT:Game1Template"; //The preset for the first game in WebGL version
        //It is best to get someone that knows their way around web pages to make a template for you to embed the WebGL player

        BuildWithOptions(buildPlayerOptions);
    }

    [MenuItem("Builds/Web Game2")]
    public static void BuildGame2()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();

        buildPlayerOptions.scenes = new[] { //The scenes we want to build
            "Assets/Scenes/Game2Scene1.unity",
            "Assets/Scenes/Game2Scene2.unity"
        };

        buildPlayerOptions.locationPathName = "../Builds/Game2"; //The location of the build, lets put it outside our project folder

        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;

        PlayerSettings.WebGL.template = "PROJECT:Game2Template"; //The preset for the second game in WebGL version

        BuildWithOptions(buildPlayerOptions);
    }

    [MenuItem("Builds/Android")]
    public static void BuildAndroid()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();

        buildPlayerOptions.scenes = new[] {
            "Assets/Scenes/MobileMenu.unity",
            "Assets/Scenes/Game2Scene1.unity",
            "Assets/Scenes/Game2Scene2.unity",
            "Assets/Scenes/Game1Scene1.unity",
            "Assets/Scenes/Game1Scene2.unity"
        };

        PlayerSettings.Android.keystorePass = "keystorePass"; //Enter your passes here for the release version,
        PlayerSettings.Android.keyaliasPass = "keyaliaspass"; //so you dont have to enter them on every launch

        buildPlayerOptions.locationPathName = "../Builds/Android/Android.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;

        BuildWithOptions(buildPlayerOptions);
    }

    public static void BuildWithOptions(BuildPlayerOptions buildPlayerOptions)
    {
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize / 10000000 + " MB");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed! Total errors: " + summary.totalErrors);
        }
    }
}
