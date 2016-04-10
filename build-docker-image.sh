#!/bin/bash
set -e # exit with nonzero exit code if anything fails

docker login -e="${DOCKER_EMAIL}" -u="${DOCKER_USERNAME}" -p="${DOCKER_PASSWORD}"
docker push csuzw/vigilant-chainsaw-application:latest