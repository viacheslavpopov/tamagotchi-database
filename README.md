# Tamagotchi

<div align="center">

</div>
<p align="center">MVC Tamagotchi App, 12-16-2020</p>
<p align="center"> By Nataliya Zhuravleva & Danielle Thompson</p>

## Description

In the 90's Tamagotchis were popular. They were electronic pets that you could carry around and press buttons to feed it, play with it, and put it to sleep. If you didn't give it enough food, attention, or rest, it would die.

This web app creates your own virtual Tamagotchi pet! Give your new pet a name through our setup form. Your pet will require differing amounts of food, attention, and rest that you will need to tend to.

All the Tamagotchi pets you collect over time will be display in your home screen with the values of their individual needs (i.e. their properties).

Different buttons in your home page will call methods to feed your pet, play with your pet, and put it to sleep. These methods modify the properties of a single Tamagotchi object at a time - such as a food property.

In the land of Tamagotchi, time passes, similar to how it passes for humans. Every time you press a pet's property, the food, happiness and sleep properties of all Tamagotchis should decrease. If any of these properties get to 0, your Tamagotchi object will report that it's dead.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Pet()

| Test                                                                       | Expect                                       |
| -------------------------------------------------------------------------- | -------------------------------------------- |
| Create a Pet Object with properties: Name, Id, Food, Happiness, Rest, Life | Pet(string Name, int Id, int Food, int Life) |

|

</details>

### Tests

Describe: CreateForm(add: Tamagotchi Name)

Describe: Feed(property food(0-100)) 

Describe: Play(property happiness(0-100))

Describe: PutToSleep(property rest(0-100))

Describe: AddHealthPoints(property life(0-100))

Describe: SubtractHealthPoints(property life(0-100))

Describe: TimePass(ToDecrease(food, happiness, rest, life))

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/PierresBakery.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing Packages

- Navigate to the Bakery.Tests folder in the command line
- Use the command `dotnet restore`

##### Run Console Application

- Navigate to the Bakery folder in the command line
- Use the command `dotnet build` to compile the code
- Use the command `dotnet run` to execute the compiled code
  - Enter the type of bread, number (int) of loaves and pasteries you would like to order
  - Enjoy the console application!
  - To exit press Ctrl + C

##### View Online

- To view in browser click the GH-Pages link: [Name of App](URL)
- what to do when open online

##### Open Locally

- Click on the link to my repository: [My Repository](URL)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

## Known Bugs

TODO

## Support and Contact Details

If any errors or bugs occur with installation delete both bin and obj folders and follow the Installing Packages and Run Console Application instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- HTML
- Razor
- ASP.NET Core MVC
- C# 7.3
- .NET Core 2.2
- REPL
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

<<<<<<< HEAD
Copyright (c) 2020 Agata Kolodziej & Danielle Thompson
=======
Copyright (c) 2020 Nataliya Zhuravleva & Danielle Thompson
>>>>>>> database
