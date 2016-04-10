#!/bin/bash
set -e # exit with nonzero exit code if anything fails

# create output directory
mkdir -p ./output/tests

# run tests
mono ./testrunner/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./src/VigilantChainsaw.Animal.Service.Tests/bin/Release/VigilantChainsaw.Animal.Service.Tests.dll --result:./output/tests/Animal-Service.xml
mono ./testrunner/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./src/VigilantChainsaw.Zoo.Service.Tests/bin/Release/VigilantChainsaw.Zoo.Service.Tests.dll --result:./output/tests/Zoo-Service.xml
