# Word Counter

#### Intermediate C# and Testing Independent Project, 6 March 2020

#### By _**Jieun Kang**_

## Description
A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It checks for full word matches only. 

## Setup/Installation Requirements

### # Install C# and .NET

**macOS**
1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)
    * Click this link will prompt a `.pkg` file download from Microsoft.
2. Open the file     
    * This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
3. Confirm the installation is successful (2.2.105)
    * Open your terminal and run the command <br/> `$ dotnet --version`    

**Windows**
1. Download [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)
    * Click this links will prompt a `.exe` file download from Microsoft.
2. Open the file
    * Follow the steps provided by the installer for your OS.
3. Confirm the installation is successful
    * Open a new Windows PowerShell window and run the command <br/> `$ dotnet --version`  

### # Clone this repository
1. Clone this project.
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/WordCounter.Solution`
    * `$ cd WordCounter.Solution`
2. Run this console application
    * `$ dotnet run` 

## Behavior Driven Development Specifications
| Behavior(Spec) <img width=800/>    | Input <img width=800/>   | Output <img width=100/>  |
| :---------------- | :----- | :-----: |
| User inputs a word and sentence, with no word matches in the sentence  | W: this <br/> S: I'm walking to the cathedral with a cat. | 0 |
| User inputs a single character word to match, and matches exist | W: a <br/> S: I'm walking to the cathedral with **_a_** cat. | 1 |
| User inputs a multi character word to match, and matches exist | W: walking <br/> S: I'm  **_walking_** to the cathedral with a cat. | 1 |
| Program should check multiple instance of the inptted word |  W: the <br/> S: I'm walking to  **_the_** cathedral with  **_the_** cat. | 2 |
| Program ignores partial matches in words | W: cat <br/> S: I'm walking to the  **_cat_** hedral with my  **_cat_** Misty. | 0 |
| Program ignores letter cases when checking matches |  W: Cat <br/> S: I'm walking to the cathedral with my **_cAT_**  Misty. | 1 |
| Program ignores punctuation(.,;:!?) when checking matches | W: cat <br/> S: I'm walking to the cathedral with my cat? cat! **_cat._**  | 3 |
| Program ignores apostrophe when checking matches | W: I <br/> S: **_I_** 'm walking to the cathedral with my cat.  | 1 |

## Technologies Used

* C#
* .NET
* MSTest

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright &copy; 2020 **_Jieun Kang_**