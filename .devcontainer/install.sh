#/bin/bash
dotnet tool install -g Microsoft.Tye --version "0.11.0-alpha.22111.1"
wget -q https://raw.githubusercontent.com/dapr/cli/master/install/install.sh -O - | /bin/bash