#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace PlayHT \
  --clientClassName PlayHTClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
