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


#if we are not on commit with tag, lets put information about number of commits from latest tag
describe=`git describe --tags --always`
#fallback if we have no tags at all reachable from HEAD
#tagName will be latest commit hash
if [[ "${describe}" =~ ^[A-Fa-f0-9]+$ ]]; then
    echo "No tags found, using defaults"
    major="0"
    minor="0"
    patch="0"
    numericVersion="0.0.0"
    stage=""
    commit_num=`git rev-list HEAD --count`
    #build some magic string to generalize some code below
    commit_num_and_hash="-$commit_num-aaa"
else

    tagName=`git describe --tags --abbrev=0`

    major=`echo $tagName | awk '{split($0,a,"."); print a[1]}'`
    minor=`echo $tagName | awk '{split($0,a,"."); print a[2]}'`
    patch=`echo $tagName | awk '{split($0,a,"."); print a[3]}'`
    numericVersion=`echo $tagName | awk '{split($0,a,"-"); print a[1]}'`
    stage=`echo $tagName | awk '{split($0,a,"-"); print a[2]}'`

    #commit and num will have format like '-3-abc'
    commit_num_and_hash=${describe#$tagName}
    echo "commit and hash part:${commit_num_and_hash}"
fi


if [ "${commit_num_and_hash}" = "" ]; then
    #HEAD commit has tag on it.
    echo "Found tag at HEAD commit"
    fileVersion=${numericVersion}.0
    if [ "${stage}" = "" ]; then
        # just removing empty space from the end and empty dash
        informationVersion="${major}.${minor}"
        version=${numericVersion}
    else
        informationVersion="${major}.${minor} ${stage}"
        version=${numericVersion}-${stage}
    fi
else
    echo "HEAD commit doesnt have a tag"
    #HEAD commit does not have tag on it
    commit_num=`echo $commit_num_and_hash | awk '{split($0,a,"-"); print a[2]}'`
    fileVersion=${numericVersion}.${commit_num}

    if [ "${stage}" = "" ]; then
        stage="preview"
    fi

    informationVersion="${major}.${minor} ${stage}"
    version=${numericVersion}-${stage}${commit_num}
fi


echo File version is ${fileVersion}
echo Information version is ${informationVersion}
echo Version is ${version}

echo "Going to build in $buildConfig mode..."
echo "Building..."

dotnet restore api-gatecoin-dotnet.sln #--configfile src/.nuget/NuGet.Config
dotnet publish api-gatecoin-dotnet.sln /p:Version=$version /p:FileVersion=$fileVersion /p:InformationVersion="${informationVersion}" --no-restore --configuration $buildConfig

echo "Packing..."
mkdir -p $packagesTempFolder
find ./ -type f -iname "api-gatecoin-dotnet.*.nupkg$" -exec rm {} \;

dotnet pack  api-gatecoin-dotnet.sln --configuration Release --verbosity Minimal /P:Version=$version

find ./ -type f | grep -i api-gatecoin-dotnet.*.nupkg$ | xargs -i cp {} $packagesTempFolder

