# 📄 Organisation Management System
## Preview
### 📌 Home Page <br/>
Home Page for Organisation Management System

### 📌 Client, Manager and Product List <br/>
This shows the views for Client, Manager and Product where it gives you the option to Edit, Delete and check Details.

### 1. Description of the project<br/>
This system was created using Visual Studio 2022 and C# as the main programming language. It was designed for a sample business named InnovationStar to support admins in managing daily operations. It is an advanced web application that is designed and developed to allow admins to manage products, plans, pricing, clients, and subscriptions. The system’s features include adding new clients, managing client details and plans, adding new products, updating product details, setting pricing and discounts, classifying business, generating reports etc. The system would store client’s, manager’s, and product’s information in the database.

This shows implementation of ASP.NET using the MVC framework, applying Data Annotations and Validations, Scaffolding.

### 2. Installation instructions<br/>
Visual Studio 2022 is supported only on 64-bit editions of Windows 10 version 1909 and higher and Windows Server 2016 and higher. <br/>
Install Visual Studio: [Link](https://visualstudio.microsoft.com/downloads/)<br/>
Install the following packages through the console: <br/>
• PM> Install-Package Microsoft.EntityFrameworkCore.Design <br/>
• PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer <br/>

### 3. Usage instructions<br/>
After downloading the file. Run the program. 

### 4. Description of technologies and tools used.<br/>
C#: The programming language used to develop the Organisation Management System. [Link](https://learn.microsoft.com/en-us/dotnet/csharp/)<br/>

### 5. Model Architecture<br/>
This provides the structure and organized approach to manage the data and logic within the InnovationStar’s Operations Management System. The reason why this architecture is suitable for the scenario is because it shows the different options an admin can choose when managing lists in InnovationStar and what the process is like in the system. It can be seen in both Figure 1 and Figure 2; the database is on the right side which represents its capability in the system to always provide data when the admin needs it as it is stored in the system. The purpose of having 4 controllers is to manage and connect the models and views. The action for home controller is needed because it serves as a entry point for admins accessing the system, that provides essential navigation options, meanwhile the action for client, manager and product controller is essential is because it provides the list for all the detailed information about the item. <br>

Figure 1: Manage Operations System 1
![1](https://github.com/JohanneChristiana/Organisation-Management-System/assets/113961547/4443e9ec-bd2f-4042-9a8f-06cb0ebdc8bd) <br>
Figure 2: Manage Operations System 2
![2](https://github.com/JohanneChristiana/Organisation-Management-System/assets/113961547/99e8c00b-ef70-427e-9579-1e00e77d3e24) <br>
Actor 1- Admin: Represents administrators who have access to manage daily operations. <br>
Actor 2- Database: Represents the data stored inside the system. <br>

### 6. Credits to external sources<br/>
• Microsoft Learn, Getting started with ASP.NET MVC 5. (2023). learn.microsoft.com. [Link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)<br/>
• Zhan, D. (2024). (NIT3112) Advance Web Application Development. Victoria University.<br/>
