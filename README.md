\# POS-InventorySystem



\## Overview

POS-InventorySystem is a complete store management and organization system that provides comprehensive management of customers, suppliers, users, and products. The system allows recording purchase operations (importing products) and issuing corresponding purchase invoices, as well as managing sales operations and issuing corresponding sales invoices. It also tracks the identity of the user responsible for each sale or purchase transaction, ensuring transparency and accuracy in managing all administrative operations.



\## Screenshots

Below are the main screens of the system:



\*\*Login Screen\*\*

!\[Login Screen](images/LoginScreen.png)



\*\*Main Screen\*\*

!\[Main Screen](images/MainScreen.png)



\*\*List and Delete Product Screen\*\*

!\[List and Delete Product Screen](images/ListAndDeleteProductScreen.png)



\*\*Import Product Screen\*\*

!\[Import Product Screen](images/importProductScreen.png)



\*\*Purchase Invoices Screen\*\*

!\[Purchase Invoices Screen](images/PurchaseInvoicesScreen.png)



\*\*Export Products Screen\*\*

!\[Export Products Screen](images/exportProductsScreen.png)



\*\*Sales Invoices Screen\*\*

!\[Sales Invoices Screen](images/SalesInvoicesScreen.png)



\*\*Manage Customers Screen\*\* (a unified screen covering add/delete/update/list operations)

!\[Manage Customers Screen](images/ManageCustomersScreen.png)



\*\*Manage Suppliers Screen\*\* (a unified screen covering add/delete/update/list operations)

!\[Manage Suppliers Screen](images/ManageSuppliersScreen.png)



\*\*Manage Users Screen\*\* (a unified screen covering add/delete/update/list operations)

!\[Manage Users Screen](images/ManageUsersScreen.png)



\## Features

\- A main dashboard providing a quick overview of users, products, customers, and suppliers, with the ability to view full details of each list.

\- Flexible navigation between screens: each section (users, customers, suppliers, products) opens its own dedicated screen, with the ability to return to the main screen at any time.

\- Full management of products and categories, with the ability to add a new category directly while adding a product if it doesn't already exist.

\- Filtering products by category, making it easier to select the required product during sale or purchase operations.

\- Management of customer, supplier, and user data (search, add, update, delete).

\- Recording product import (purchase) operations with detailed purchase invoices.

\- Recording product export (sale) operations with detailed sales invoices.

\- Automatic inventory updates with every sale or purchase operation.

\- Applying a discount system to invoices when needed.

\- Linking every sale or purchase invoice to the user who executed it, ensuring traceability and accountability.

\- Displaying a list of all purchase and sales invoices, with the ability to click any invoice to view its full details on the same screen, and delete the invoice along with its associated details when needed.



\## Architecture

The project is divided into three main layers:



\- \*\*Database:\*\* Represents the Data Access layer, containing the database model (Entity Framework) and the classes responsible for directly interacting with the database.

\- \*\*Classes:\*\* Represents the Business Logic layer, containing the intermediary classes between the data layer and the presentation layer.

\- \*\*Screens:\*\* Represents the Presentation layer, containing the system's Windows Forms screens that the user interacts with directly.



\## Tech Stack

\- \*\*Programming Language:\*\* C#

\- \*\*UI Framework:\*\* Windows Forms

\- \*\*Database:\*\* SQL Server

\- \*\*Data Access:\*\* Entity Framework (Database First)

\- \*\*UI Enhancement Library:\*\* Krypton Toolkit

