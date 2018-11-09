#!/bin/bash
set -e

version="$CI_COMMIT_TAG"
branch="$CI_JOB_STAGE" # CI_COMMIT_REF_NAME
buildNumber=$CI_JOB_ID
 
PackagesTempFolder=packages

# Pack
fullVersion="$version+$buildNumber"

mkdir -p $PackagesTempFolder
find ./ -type f -iname "api-gatecoin-dotnet.*.nupkg$" -exec rm {} \;

dotnet pack  api-gatecoin-dotnet.sln --configuration Release --verbosity Minimal /P:Version=$fullVersion

find src/ -type f | grep -i api-gatecoin-dotnet.*.nupkg$ | xargs -i cp {} $PackagesTempFolder
