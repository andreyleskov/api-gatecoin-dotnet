#!/bin/bash 
set -e 
 
# Publish  
 
nugetFeed="$1" 
MyGetFeedAPIKey="$2" 
folder="$3" 
 
find $folder/ -type f | xargs -i dotnet nuget push {} --api-key $MyGetFeedAPIKey --source $nugetFeed 