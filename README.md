# Word Counter Console

Console application that takes in a user input word and sentence, and counts the instances of the provided word in the provided sentence. Project focused on error handling, parsing user input, unit testing with MSTest, and using the c# select clause.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/Word-Counter-Console
    ```
2. Change directories into the project working directory:
    ```
    cd Word-Counter-Console/WordCounter
    ```
2. Compile and Run code:
    ```
    dotnet run
    ```

## Specifications

|Behavior|Input|Output|
|:-:|:-:|:-:|
|User inputs a word, store word in SeachWord property of RepeatCounter class.|"cat"|RepeatCounter.SearchWord => "cat"|
|User inputs a sentence after the word, store sentence in Sentence property of RepeatCounter class.|"This is my cat"|RepeatCounter.Sentence => "This is my cat"|
|If user input contains numbers, throw error and ask prompt again.|"cat1"|"Invalid input, please only use letters" **reprompt**|
|If user inputs valid word and sentence, return number of instances of the word in the sentence.|"cat", "This is my cat"|"1 instance of 'cat' in 'This is my cat'."|
|WordCounter does not count instances of word within another word.|"cat", "This is my cathedral"|"0 instances of 'cat' in 'This is my cathedral'|
|WordCounter is agnostic to uppercase and lowercase letters|"cat", "This is my Cat"|"1 instance of 'cat' in 'This is my Cat'."|
|WordCounter is agnostic to punctuation|"cat", "This is my cat."|"1 instance of 'cat' in 'This is my cat.'."|

## Technologies Used

* C#
* .NET Core
* MSTest
* [Csharp-Console-template-Maker](https://github.com/PRKille/CsharpFileTemplate)
* Git

## Author

* **Jamison Cozart** - (https://github.com/jamisoncozart)

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart