# _Sweet Treats Bakery Management App_

#### _8.14.2020_

#### By _**Teresa Rosinski**_

# Description

This is a C# app that allows a user to add Treats and Flavors to a databse. It utilizes a many-to-many relationship between Treats and Flavors as well as Identity to allow user to register, log-in, and log-out.

# Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program

# Importing and Updating the Database

* MySql must be installed on your device
* To connect the database type in the command line: dotnet ef migrations add Initial 
* To update the database type in the command line: dotnet ef database update    


# SQL Schema Query #



# Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program creates instance of the Treat class** | N/A | N/A |
| **Program creates instance of the Flavor class** | N/A | N/A |
| **Program only allows the user to delete specific instances of treats** | "N/A" | "N/A"  |
| **Program only allows the user to delete specific instances of flavors** | "N/A" | "N/A"  |
| **Program allows the user to connect an infinite number of treats with different flavors** | "N/A" | "N/A"  |
| **Program only allows user to connect an infinite number of flavors with different treats** | "N/A" | "N/A"  |
| **Program only allows user to delete an flavor different treats** | "N/A" | "N/A"  |
| **Program only allows user to delete a treat different flavors** | "N/A" | "N/A"  |

# Support and contact details

_For question, concerns, or if you would like to make contributions to this work, please contact Teresa Rosinski at trosinski89@gmail.com_

# Technologies Used

* VSCode
* C#
* MySqL
* Entity Framework
* .NET Core
* BootStrap
* Identity 

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Teresa Rosinski_**