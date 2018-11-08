#!/bin/bash
set -e

DEFAULT_BUILD_CONFIG=Release
BUILD_CONFIG=$DEFAULT_BUILD_CONFIG
if [ $# -eq 1 ]; then
    BUILD_CONFIG=$1
fi


version="$CI_COMMIT_TAG"
branch="$CI_JOB_STAGE" # CI_COMMIT_REF_NAME
buildNumber=$CI_JOB_ID
if [ -z $version ]; then
    version=$(git tag |tail -1)
fi

informationVersion="$version-$branch+$buildNumber"
fileVersion="$version.$buildNumber"


echo "Going to build in $BUILD_CONFIG mode..."
echo "Building..."

dotnet restore api-gatecoin-dotnet.sln #--configfile src/.nuget/NuGet.Config
dotnet publish api-gatecoin-dotnet.sln /p:Version=$informationVersion /p:FileVersion=$fileVersion --no-restore --configuration $BUILD_CONFIG
