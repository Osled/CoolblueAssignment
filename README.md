# CoolblueAssignment
## Introduction
### The soltion is Designed to run a Window Form that presents the Coolblue products information by searching the product ID and Type ID. the end-point is the Name of the products, ID, SalePrice, Product Type, Insurance calculated cost. 


## Setup
### Installation

Install **Visual Studio 2019 version 16.11** [https://docs.microsoft.com/en-us/visualstudio/releases/2019/release-notes].

Install the following **WorkLoads** during the installation of Visual Studio.
- **ASP.NET** and **Web Development**
- **.NET desktop Development**
- **Universal Windows Platform development**
- **Visual Studio extension development**


### Extentions
- Install **Nunit 3 Adapter** from the Visual studio Extentions manager.

### Packages
Access the Solution and chose "Manage Nuget Packages for Solution" to install the following packages.
- **Newtonsoft.json**
      Designed to convert Json files
- **NUnit**
      Designed to run Automated testing

## Run App
Install the Github file move to the following directory **CoolblueAssignment\Coolblue Assignment\CoolblueItemInsurance**.
Run the **CoolblueItemInsurance.sln** .
to access the app without the code access the Setup file and install the App
to access the App with Visual Studio, press the run/ Play button in visual studio

## Design Choices
### Interface
The Website runs three Panels  all three panels can be accessed through the left by pressing the buttons. 

- The Id Panel hosts Task 1 from the assignment
              - Input ID number of the product. 
              - Press Search. 
              - Display the relevent information :** Name of the products, ID, SalePrice, Product ID Type.**
              
- The IdType Panel hosts Task 2 from the assignment
              - Input ID Type number of the product. 
              - Press Search. 
              - Display the relevent information : **Product ID Type,  Product Type, Can be Insured.**
              
- The IDfull Panel hosts Task 3 from the assignment
              - Input ID number of the product. 
              - Press Search. 
              - Display the relevent information : **Name of the products, ID, SalePrice, Product ID Type,  Product Type, Can be Insured, Insurance calculated cost. **

### Code

- ApiHelper: Runs the HTTPClient to set and get the host information.
- DataProcesser: Access the Json file and creates a list, then picks the group of which the ID falls in, then returns the Data and host them in the Model of each ID and Type Json.
- ID page searchs a Json file from a web http that hosts page [https://api.npoint.io/eed1401b570f01972c9b].
- ID Type page searchs a Json file from a web http that hosts page [https://api.npoint.io/9217f1e291b1bc24edb6].
- Caluculation done: is a switch case that checks if the item is insured and if its a Laptop or a Smartphone, then calculates the total insurance cost.
- The Code that hosts the funtion of which it applies the changes of the information presented is inside the App Form. and called on pressing the Search Button.

