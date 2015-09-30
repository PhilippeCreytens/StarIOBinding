#!/bin/bash

while getopts :t:p:r:c:b: FLAG; do
  case $FLAG in
    t)
      TARGET=$OPTARG
      ;;
    p)
      PAPER=$OPTARG
      ;;
    r)
      RELEASE=$OPTARG
      ;;
    c)
      COUNTER=$OPTARG
      ;;
    b)
      BRANCH=$OPTARG
      ;;
  esac
done

nuget install FAKE -OutputDirectory packages -ExcludeVersion
mono packages/FAKE/tools/Fake.exe build.fsx $TARGET paper=$PAPER release=$RELEASE counter=$COUNTER branch=$BRANCH