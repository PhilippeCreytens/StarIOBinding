#!/bin/bash

hockeyapp_id=$1
teamcity_buildid=$2

shortversion=$(curl \
  -H "X-HockeyAppToken: f75fa9ad835843709de63f46c1091b23" \
  https://rink.hockeyapp.net/api/2/apps/$hockeyapp_id/app_versions | jq '.["app_versions"] | sort_by(.created_at) | reverse | .[0] | .shortversion')

buildnumber_splitted=(${shortversion//./ })
buildnumber=${buildnumber_splitted[2]}
buildnumber_cleanedup=${buildnumber//\"}

echo "Get checksum of last deployed version via http://guest@grbhsttcdp01.core.local/app/rest/buildTypes/id:$teamcity_buildid/builds/number:$buildnumber_cleanedup"

curl -o lastDeploy.tmp  "http://guest@grbhsttcdp01.core.local/app/rest/buildTypes/id:$teamcity_buildid/builds/number:$buildnumber_cleanedup"
lastDeploy_checksum=`xpath lastDeploy.tmp  '/build/revisions/revision/@version'| awk -F"\"" '{print $2}'`

checksum_ofbuild=$(<git-checksum.txt)

# Prepare release notes
git log --pretty=format:"- %s" $lastDeploy_checksum..$checksum_ofbuild > git-releasenotes.txt