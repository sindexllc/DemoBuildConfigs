# DemoBuildConfigs
## A demo project showing build configs for Unity

You can create builds from the `Build` menu in Unity. You could also run the `BuildAll.sh` script to make all builds in sequence.

In `BuildAll.sh` the `UNITY_PATH` might differ for your system, depending from where you run the script the `PROJECT_PATH` might differ also.

Notable files:

`BuildConfigs.cs`

`BuildAll.sh`

> Note that modern browsers will refuse to run WebGL builds localy. This is a security issue. You need to upload them to a > >  server or create a local one in order to see the results.

> The Android.apk will also require a keystore for release build.

> These are just sample builds and are not important for the demo. This demo is just to show you a way of doing builds that you will customize for your purposes anyhow.
