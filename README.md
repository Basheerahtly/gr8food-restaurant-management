# GR8Food Restaurant Management System

A Windows desktop application for running a restaurant, built as a team project at Asia Pacific University (Introduction to Object Oriented Programming module, Year 1). This is the version submitted for assessment, kept unchanged.

## What it does

- **Admin:** create, update, view and remove user accounts
- **Manager:** dashboard, sales reports and customer feedback
- **Chef:** live dashboard, menu management and order handling
- **Customer:** browse the menu, cart, wallet, order history and feedback

## Built with

C#, .NET Framework 4.7.2, Windows Forms and SQL Server. Passwords are stored as SHA-256 hashes.

## My contribution

I developed the **Chef module**:

- A dashboard with a pie chart of the chef's top dishes, a bar chart of order statuses, and the chef's shift details
- Menu management with search, category filters, and adding, updating and removing dishes
- An orders screen that refreshes automatically and moves each order from Pending to In Progress to Completed

## Running it

Open `assignment .slnx` in Visual Studio on Windows. It needs a local SQL Server database named `GR8Food`, which is not included in this repository.
