#!/bin/bash
set -e # exit with nonzero exit code if anything fails

docker run -d -p 8400:8400 -p 8500:8500 -p 53:53/udp -h consul-server-node --name consul progrium/consul -server -bootstrap
docker run -d --link consul:consul --name registrator -v /var/run/docker.sock:/tmp/docker.sock -h $HOSTNAME gliderlab/registrator consul://consul:8500
docker run -d -p 3579:3579 --name vigilant-chainsaw-application csuzw/vigilant-chainsaw-application