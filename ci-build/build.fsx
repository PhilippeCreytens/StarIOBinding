#r @"packages/FAKE/tools/FakeLib.dll"
#load "build-helpers.fsx"

open Fake
open Fake.XamarinHelper
open BuildHelpers
open System
open System.IO
open System.Linq
open HockeyAppHelper
open StringHelper


let releaseversion = getBuildParam "Release"
let buildcounter = getBuildParam "counter"
let branch = getBuildParamOrDefault "branch" "DEV"
let projectBuildSetting = if String.Equals(branch, "DEV") then "Debug" else "Release"
let projectBuildConfiguration = projectBuildSetting
let buildFolder = "buildOutput"
let projectName = "StarIOBinding"

Target "restore-packages" (fun _ ->
     String.Format("../{0}.sln", projectName)
     |> RestoreMSSolutionPackages (fun p ->
         { p with
             OutputPath = "../packages"
             Retries = 4 })
)

Target "build" (fun () ->
    CleanDirs [buildFolder + "/"+releaseversion+"/"]
    //BuildHelpers.writeChecksumGitCheckinToFile

    MSBuild (buildFolder) "Rebuild" [
        ("Configuration", projectBuildConfiguration); ("Platform", "Any CPU")
    ] [String.Format("../{0}.sln", projectName)] |> ignore
)

"restore-packages"
  ==> "build"
//  ==> "android-hockeyapp"

RunTargetOrDefault "build"