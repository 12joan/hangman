# Hangman

This is a text-based hangman game written in C#. Words are selected at random from a list of over 1500 of the most common English words (see Acknowledgments). The game does not (currently) include an ASCII "hanging man" graphic; instead, the player is granted 15 lives which count down with each incorrect guess. 

## Getting Started

Follow these instructions to get a working copy of the game which you can play in the command line. You are free to make improvements and redistribute the code as you wish - see the [LICENSE](LICENSE) file for details.

### Prerequisites

In theory, this project can be compiled and run through Visual Studio. However, this is untested and may result in unexpected errors. If you try this, please leave comments or [create an issue](https://github.com/12joan/hangman/issues) describing any problems encountered. 

Alternatively, it can be compiled using Microsoft's command line tool `dotnet`. Instructions for installation can be found [here](https://www.microsoft.com/net/core).

### Compiling and Running

With the .NET Core SDK installed, the `dotnet` command line tool can be used to compile and run the source code. Navigate to the project root and run the following command. 

```
dotnet build
```

This should create the executable `./bin/Debug/netcoreapp2.0/hangman.dll`. To execute it, run the following command **in the same directory**. (The exact path may differ depending on the environment — use the one generated from the build command.)

```
dotnet exec bin/Debug/netcoreapp2.0/hangman.dll
```

In Windows, the `dotnet exec` may not be necessary. Instead, simply paste the correct path into the Command Prompt to play. 

```
bin\Debug\netcoreapp2.0\hangman.dll
``` 

Enjoy the game!

## Authors

* **Joseph Anderson** - [12joan](https://github.com/12joan)

## License

This project is licensed under the Unlicence - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* The default list of words comes from [an article by TalkEnglish.com](http://www.talkenglish.com/vocabulary/top-1500-nouns.aspx).
* The ASCII Art title seen in the game was generated using this [Text to ASCII Art Generator](http://patorjk.com/software/taag/).

