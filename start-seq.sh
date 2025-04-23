#!/bin/bash

# Pull the Datalust Seq Docker image
docker pull datalust/seq

# Start the Datalust Seq Docker container
docker run -d --name seq -p 5341:80 datalust/seq
