#!/bin/bash
set -e

buildConfig=Release
if [ $# -ge 1 ]; then
    buildConfig=$1
fi

if [ $# -ge 2 ]; then
    buildNumber=$2
fi

packagesTempFolder=packages

if [ $# -ge 3 ]; then
    packagesTempFolder=$3
fi

source $(dirname "$0")/git_tag_versioning.sh

echo "Going to build in $buildConfig mode..."
echo "Building..."

dotnet restore ./api-gatecoin-dotnet.sln #--configfile src/.nuget/NuGet.Config
dotnet publish ./api-gatecoin-dotnet.sln /p:Version=$version /p:FileVersion=$fileVersion /p:InformationVersion="${informationVersion}" --no-restore --configuration $buildConfig

echo "Packing..."
mkdir -p $packagesTempFolder
find ./ -type f -iname "api-gatecoin-dotnet.*.nupkg$" -exec rm {} \;

dotnet pack  api-gatecoin-dotnet.sln --configuration Release --verbosity Minimal /P:Version=$version

find ./ -type f | grep -i api-gatecoin-dotnet.*.nupkg$ | xargs -i cp {} $packagesTempFolder

