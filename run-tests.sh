#!/bin/bash
set -e # exit with nonzero exit code if anything fails

# create output directory
mkdir -p ./output/tests

# run tests
mono ./testrunner/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./src/VigilantChainsaw.Services.Root.Tests/bin/Release/VigilantChainsaw.Services.Root.Tests.dll --result:./output/tests/Services-Root.xml
