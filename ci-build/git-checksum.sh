#!/bin/bash

# Gets the checksum of the last succesful build.
curl -o lastBuild.tmp "http://guest@grbhsttcdp01.core.local/app/rest/buildTypes/id:WebCMS_MobileApps_Android_Application/builds/status:SUCCESS"
last_commit=`xpath lastBuild.tmp  '/build/revisions/revision/@version'| awk -F"\"" '{print $2}'`

echo $last_commit > git-checksum.txt