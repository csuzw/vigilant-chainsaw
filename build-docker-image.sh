#!/bin/bash
set -e # exit with nonzero exit code if anything fails

# animal
docker build -t csuzw/vigilant-chainsaw-animal:${APP_VERSION}.${TRAVIS_BUILD_NUMBER} -t csuzw/vigilant-chainsaw-animal:latest ./src/VigilantChainsaw.Animal/bin/Release/
docker login -e="${DOCKER_EMAIL}" -u="${DOCKER_USERNAME}" -p="${DOCKER_PASSWORD}"
docker push csuzw/vigilant-chainsaw-animal:latest

# zoo
docker build -t csuzw/vigilant-chainsaw-zoo:${APP_VERSION}.${TRAVIS_BUILD_NUMBER} -t csuzw/vigilant-chainsaw-zoo:latest ./src/VigilantChainsaw.Zoo/bin/Release/
docker login -e="${DOCKER_EMAIL}" -u="${DOCKER_USERNAME}" -p="${DOCKER_PASSWORD}"
docker push csuzw/vigilant-chainsaw-zoo:latest