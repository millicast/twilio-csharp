# Overview
This fork was made primarily to reduce the number of extremely legacy dependencies.
By removing just `System.Collections.Specialized` we also drop a bunch of related dependencies (all of which are very old 4.3 versions):
- Microsoft.NETCore.Platforms
- Microsoft.NETCore.Targets
- System.Collections.NonGeneric
- System.Collections.Specialized
- System.Diagnostics.Debug
- System.Globalization
- System.Globalization.Extensions
- System.IO
- System.Reflection
- System.Reflection.Primitives
- System.Resources.ResourceManager
- System.Runtime
- System.Runtime.Extensions
- System.Runtime.Handles
- System.Runtime.InteropServices
- System.Text.Encoding
- System.Threading
- System.Threading.Tasks

Package given a new name `Twilio.Millicast`. Otherwise namespace is identical so no breaking changes expected.

The old requirement of `System.Collections.Specialized` was from one method in `RequestValidator` which used `NameValueCollection`. This method internally converted the NameValueCollection to a Dictionary anyways. So likely kept around for historical reasons. We don't need it.

# Syncing Upstream Changes
Currently upstream's `main` branch seems to always point at their most recent tag. Confirm first before merging.
```
git remote add upstream git@github.com:twilio/twilio-csharp.git

git fetch upstream

# local branch to sync changes to
git checkout main
git pull
git merge upstream/main
# else git merge tags/TAG_NAME

# handle conficts if any
```

Create new tag with suffix `_Millicast` which matches upstream's newest tag.

# Build Nupkg
Version number will be taken from .csproj, which is bumped on every new version.
```
git clean -dfx
dotnet build -c Release
dotnet pack -c Release -o OUTPUT_DIR ./src/Twilio/Twilio.csproj
```
