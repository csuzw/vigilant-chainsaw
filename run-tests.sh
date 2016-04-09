#!/bin/bash
set -e # exit with nonzero exit code if anything fails

# create output directory
mkdir -p ./output/tests

# run tests
mono ./testrunner/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./src/VigilantChainsaw.Services.Index.Tests/bin/Release/VigilantChainsaw.Services.Index.Tests.dll --result:./output/tests/Services-Index-Tests.xml
