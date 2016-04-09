#!/bin/bash
set -e # exit with nonzero exit code if anything fails

docker build -t csuzw/vigilant-chainsaw-application:${APP_VERSION}.${TRAVIS_BUILD_NUMBER} ./src/VigilantChainsaw.Application/bin/Release/
docker login -e="${DOCKER_EMAIL}" -u="${DOCKER_USERNAME}" -p="${DOCKER_PASSWORD}"
docker push csuzw/vigilant-chainsaw-application:${APP_VERSION}.${TRAVIS_BUILD_NUMBER}