module BuildHelpers

open Fake
open Fake.XamarinHelper

let Exec command args =
    let result = Shell.Exec(command, args)

    if result <> 0 then failwithf "%s exited with error %d" command result

let RestorePackages solutionFile =
    Exec "nuget" ("restore " + solutionFile)

let RunNUnitTests dllPath xmlPath =
    !! dllPath
      |> NUnit (fun p ->
          { p with
             DisableShadowCopy = true;
             OutputFile = xmlPath;
             ToolPath = "tools/NUnit/"
             ToolName = "nunit-console4" })

    TeamCityHelper.sendTeamCityNUnitImport xmlPath

let GetBuildCounter (str:Option<string>) =
    match str with
    | Some(v) -> v
    | None -> "Local"

let GetProjectName (str:Option<string>) =
    match str with
    | Some(n) -> n
    | None -> "LocalProject"

let UpdateAndroidBuildNumber projectFolder version build =
    let path = (projectFolder + "/Properties/AndroidManifest.xml")
    let ns = Seq.singleton(("android", "http://schemas.android.com/apk/res/android"))
    XmlPokeNS path ns "manifest/@android:versionName" build
    XmlPokeNS path ns "manifest/@android:versionCode" version

let UpdateiOSBuildNumber projectFolder releaseversion =
    Exec "/usr/libexec/PlistBuddy" ("-c \"Set :CFBundleVersion " + releaseversion + "\" " + projectFolder + "/Info.plist")
    Exec "/usr/libexec/PlistBuddy" ("-c \"Set :CFBundleShortVersionString " + releaseversion + "\" " + projectFolder + "/Info.plist")

let writeChecksumGitCheckinToFile =
   let result = Shell.Exec("git-checksum.sh")
   if result <> 0 then failwithf "exited with error %d" result

let getChecksumGitCheckin =
   StringHelper.ReadFileAsString "git-checksum.txt"