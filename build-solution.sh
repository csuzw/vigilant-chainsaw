#!/bin/bash
set -e # exit with nonzero exit code if anything fails

# inject builder number
sed -i "s@AssemblyVersion(\"1.0.*\")@AssemblyVersion("${APP_VERSION}.${TRAVIS_BUILD_NUMBER}")@g" ./src/SharedAssemblyInfo.cs

xbuild /p:Configuration=Release ./src/VigilantChainsaw.sln