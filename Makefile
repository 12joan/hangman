build:
	dotnet build

exec:
	 dotnet exec bin/Debug/netcoreapp2.0/hangman.dll

run:
	make build
	make exec
