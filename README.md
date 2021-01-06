# Tamagotchi

<div align="center">

</div>
<p align="center">MVC Tamagotchi App, 12-16-2020</p>
<p align="center"> By Carmen Kolodziej & Danielle Thompson</p>

## Description

In the 90's Tamagotchis were popular. They were electronic pets that you could carry around and press buttons to feed it, play with it, and put it to sleep. If you didn't give it enough food, attention, or rest, it would die.

This web app creates your own virtual Tamagotchi pet! Give your new pet a name through our setup form. Your pet will require differing amounts of food, attention, and rest that you will need to tend to.

All the Tamagotchi pets you collect over time will be display in your home screen with the values of their individual needs (i.e. their properties).

Different buttons in your home page will call methods to feed your pet, play with your pet, and put it to sleep. These methods modify the properties of a single Tamagotchi object at a time - such as a food property.

In the land of Tamagotchi, time passes, similar to how it passes for humans. Every time you take any action on one of your pets (play, feed, sleep), the life properties of all Tamagotchis will decrease in. If any of these properties get to 0, your Tamagotchi object will report that it's dead.

<img src="~/img/MySQL Tamagotchi DB.png">
<img src="~/img/Pets Table Screenshot.png">

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Pet()

| Test                                                                       | Expect                                       |
| -------------------------------------------------------------------------- | -------------------------------------------- |
| Create a Pet Object with properties: Name, Id, Food, Happiness, Rest, Life | Pet(string Name, int Id, int Food, int Life) |

</details>

### Tests

Describe: CreateForm(add: Tamagotchi Name)

Describe: Feed(property life(+5)) 

Describe: Play(property life(+5))

Describe: PutToSleep(property life(+10))

Describe: TimePass.ToDecrease(life(-50))

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

#### Setting up a Local Database

- Download [MySQL Server](https://dev.mysql.com/downloads/file/?id=484914).
- Download [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391).
- (For more detailed instructions if either of the above technologies are unfamiliar to you, visit [this site](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)).
- Run `dotnet build` when the project is on your local machine.
- Run `dotnet ef migrations add Initial`
  --> If there is an error stating "Unable to resolve project", this means the command wasn't run in the correct directory.
- Entity creates three files in the Migrations directory.
- Run the following command: `dotnet ef database update`.

#### MySQL Password Protection & .gitignore

Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice.

Create a file in the root directory of the project called "appsettings.json". Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=registrar;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```

Where you see "YOUR-PASSWORD-HERE" is where you put the password you created for your MySQL server. Your server name and port might vary depending on your local system. Check MySQL Workbench Connections to determine if the local host and port number match and adjust as needed.

Create a .gitignore file and add the following files & folders to it:

- obj/
- bin/
- .vscode/
- .DS_Store
- appsettings.json

##### Open Locally

* Navigate to the project folder on your Terminal or CMD.
* Run the command `code .` to open the folder in VS Code. Otherwise, find and open the project folder in the code editor of your choice.
* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application.
* `dotnet restore` to install packages listed in project's boilerplate.

## Known Bugs

No known bugs as of now. [Please report any bugs found here.](https://github.com/dani-t-codes/tamagotchi-database/issues)

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

### Under Construction
- Update software installation requirements (need to include MySQL database info)
- Figure out how to call Feed, Play, &/or Rest to update the database
- Add more styling, w/ pet images (stretch)
- As of Jan 1, 2021, need to figure out routes in controller for updating data in database & displaying data to page.
- Need to add a property for alive/dead (e.g. alive = true;) with a conditional on the pet details page - @foreach (Pet pet) @if ( life <=0, alive = false;) else (display pet details & buttons).
- Use upper cohort Tamagotchi project for reference as needed: [Tamagotchi](https://github.com/dani-t-codes/Tamagotchi).

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej & Danielle Thompson