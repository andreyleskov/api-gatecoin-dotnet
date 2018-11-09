#!/bin/bash
set -e

buildConfig=Release
if [ $# -eq 1 ]; then
    buildConfig=$1
fi

if [ $# -eq 2 ]; then
    buildNumber=$2
fi

packagesTempFolder=packages
if [ $# -eq 3 ]; then
    packagesTempFolder=$3
fi

describe=`git describe --tags --abbrev=0`

major=`echo $describe | awk '{split($0,a,"."); print a[1]}'`
minor=`echo $describe | awk '{split($0,a,"."); print a[2]}'`
patch=`echo $describe | awk '{split($0,a,"."); print a[3]}'`

describe=`git describe --tags --always`

numericVersion=`echo $describe | awk '{split($0,a,"-"); print a[1]}'`
stage=`echo $describe | awk '{split($0,a,"-"); print a[2]}'`
commit_num=`echo $describe | awk '{split($0,a,"-"); print a[3]}'`

if [[ "${describe}" =~ ^[A-Fa-f0-9]+$ ]]; then
    version="0.0.0"
    stage=`git rev-list HEAD --count`
    patch=${DESCRIBE}
fi

fileVersion=${numericVersion}.${commit_num}

if [ "${stage}" = "" ]; then
    informationVersion=${major}.${minor}
    version=${numericVersion}
else
    informationVersion="${major}.${minor} ${stage}"
    version=${numericVersion}-${stage}${commit_num}+build.${buildNumber}  
fi


echo "Going to build in $buildConfig mode..."

echo File version is ${fileVersion}
echo Information version is ${informationVersion}
echo Version is ${version}

echo "Building..."

dotnet restore api-gatecoin-dotnet.sln #--configfile src/.nuget/NuGet.Config
dotnet publish api-gatecoin-dotnet.sln /p:Version=$version /p:FileVersion=$fileVersion /p:InformationVersion="${informationVersion}" --no-restore --configuration $buildConfig

echo "Packing..."
mkdir -p $PackagesTempFolder
find ./ -type f -iname "api-gatecoin-dotnet.*.nupkg$" -exec rm {} \;

dotnet pack  api-gatecoin-dotnet.sln --configuration Release --verbosity Minimal /P:Version=$version

find ./ -type f | grep -i api-gatecoin-dotnet.*.nupkg$ | xargs -i cp {} $packagesTempFolder

