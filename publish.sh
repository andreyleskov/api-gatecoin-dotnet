#!/bin/bash
set -e

# Publish 
folder=packages
nugetFeed="$1"
MyGetFeedAPIKey="$2"

find $folder/ -type f | xargs -i dotnet nuget push {} --api-key $MyGetFeedAPIKey --source $nugetFeed
